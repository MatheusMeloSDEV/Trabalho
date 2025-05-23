using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLUSA;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Trabalho
{
    public partial class FrmMenu : Form
    {
        private readonly string _connectionString = "mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/";
        private readonly string _databaseName = "Trabalho";
        private readonly IMongoCollection<BsonDocument> _processoCollection;
        private readonly RepositorioNotificacao _notificacaoRepo;
        private Logado _logadoUsuario;
        // Mantém instâncias únicas dos formulários filhos
        private readonly Dictionary<Type, Form> _forms = new();
        private bool _logoutPeloMenu = false;

        public FrmMenu(Logado logadoUsuario)
        {
            InitializeComponent();

            _logadoUsuario = logadoUsuario ?? throw new ArgumentNullException(nameof(logadoUsuario));

            this.Shown += FrmMenu_Shown;
            // Inicializa e dispara o timer para habilitar o Exit após 3s
            timerReleaseExit = new System.Windows.Forms.Timer { Interval = 3000 };
            timerReleaseExit.Tick += TimerReleaseExit_Tick;
            MenuItemExit.Enabled = false;
            timerReleaseExit.Start();


            if (!_logadoUsuario.admin)
            {
                MenuItemAdmin.Visible = false;
            }

            // Inicializa acesso ao MongoDB
            var client = new MongoClient(_connectionString);
            var database = client.GetDatabase(_databaseName);
            _processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
            _notificacaoRepo = new RepositorioNotificacao(database);

            // Se estiver usando tema escuro:
            if (FrmLogin.Instance.Escuro)
                AplicarModoEscuro();
        }
        private async void FrmMenu_Shown(object? sender, EventArgs e)
        {
            // Aqui o form já apareceu na tela, podemos carregar sem bloquear a pintura
            await CarregarDadosProcessos();
            TCabas.Visible = true;  // se você ainda quiser mostrar as abas só após o load
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            // não chame aqui o CarregarDadosProcessos
            TCabas.Visible = false;   // se quiser só mostrar após o CarregarDados
        }

        private void TimerReleaseExit_Tick(object? sender, EventArgs e)
        {
            timerReleaseExit.Stop();
            MenuItemExit.Enabled = true;
        }

        private void AplicarModoEscuro()
        {
            MSnotificacoes.BackColor = SystemColors.ControlDark;
            // configure outros componentes se necessário...
        }

        private async Task CarregarDadosProcessos()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var processos = await _processoCollection
                    .Find(FilterDefinition<BsonDocument>.Empty)
                    .ToListAsync();

                MontarTabsProcessos(processos);
                GerarNotificacoes(processos);
                AtualizarNotificacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar processos: {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void MontarTabsProcessos(List<BsonDocument> processos)
        {
            MontarTabDataDeAtracacao(processos);
            MontarTabOrgaoAnuentes(processos);
            MontarTabFinalizados(processos);
        }
        private TabPage GetOrCreateTab(string name, string title)
        {
            var tabPage = TCabas.TabPages[name];
            if (tabPage == null)
            {
                tabPage = new TabPage(title) { Name = name };
                TCabas.TabPages.Add(tabPage);
            }
            return tabPage;
        }

        private TableLayoutPanel CriarTabela()
        {
            return new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                ColumnCount = 1
            };
        }

        private Label CriarLabel(string texto)
        {
            return new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                Margin = new Padding(5),
                Text = texto
            };
        }
        private bool EhFinalizado(BsonDocument p)
        {
            return p.Contains("DataCarregamentoDI") && p["DataCarregamentoDI"] != BsonNull.Value && !string.IsNullOrEmpty(p["DataCarregamentoDI"].ToString());
        }
        private void MontarTabDataDeAtracacao(List<BsonDocument> processos)
        {
            var tabPage = GetOrCreateTab("DataDeAtracacao", "Data de Atracação");
            tabPage.Controls.Clear();

            var table = CriarTabela();

            foreach (var p in processos)
            {
                if (EhFinalizado(p)) continue; // pula se for finalizado

                var refUsa = p.GetValue("Ref_USA", BsonNull.Value).ToString();
                var sr = p.GetValue("SR", BsonNull.Value).ToString();

                DateTime dt;
                var bval = p.GetValue("DataDeAtracacao", BsonNull.Value);
                if (bval.IsValidDateTime)
                    dt = bval.ToUniversalTime().ToLocalTime();
                else if (!DateTime.TryParse(bval.ToString(), out dt))
                    dt = DateTime.MinValue;

                var dataFmt = dt != DateTime.MinValue ? dt.ToString("dd/MM/yyyy") : "N/A";
                var dias = dt != DateTime.MinValue ? (dt.Date - DateTime.Today).Days : 0;
                var restantes = dt != DateTime.MinValue ? $"{dias} dia(s)" : "";

                table.Controls.Add(CriarLabel($"{refUsa} — {sr} — {dataFmt} — {restantes}"));
            }

            tabPage.Controls.Add(table);
        }
        private void MontarTabOrgaoAnuentes(List<BsonDocument> processos)
        {
            var tabPage = GetOrCreateTab("OrgaoAnuentes", "Órgãos Anuentes");
            tabPage.Controls.Clear();

            var table = CriarTabela();

            foreach (var p in processos)
            {
                if (EhFinalizado(p)) continue;

                var refUsa = p.GetValue("Ref_USA", BsonNull.Value).ToString();
                var importador = p.GetValue("Importador", BsonNull.Value).ToString();

                var orgaos = new Dictionary<string, string>
                {
                    { "TMapa", "MAPA" },
                    { "TDecex", "DECEX" },
                    { "TAnvisa", "ANVISA" },
                    { "TIbama", "IBAMA" },
                    { "TInmetro", "INMETRO" }
                };

                foreach (var kvp in orgaos)
                {
                    if (p.TryGetValue(kvp.Key, out var valor) && valor.IsBoolean && valor.AsBoolean)
                    {
                        table.Controls.Add(CriarLabel($"{refUsa} — {importador} — {kvp.Value}"));
                    }
                }
            }

            tabPage.Controls.Add(table);
        }


        private void MontarTabFinalizados(List<BsonDocument> processos)
        {
            var tabPage = GetOrCreateTab("Finalizados", "Finalizados");
            tabPage.Controls.Clear();

            var table = CriarTabela();

            foreach (var p in processos)
            {
                if (!EhFinalizado(p)) continue;

                var refUsa = p.GetValue("Ref_USA", BsonNull.Value).ToString();

                string dataFormatada = "N/A";
                if (p.TryGetValue("DataCarregamentoDI", out var dataVal))
                {
                    if (dataVal.IsValidDateTime)
                    {
                        var dt = dataVal.ToUniversalTime().ToLocalTime();
                        dataFormatada = dt.ToString("dd/MM/yyyy");
                    }
                    else if (DateTime.TryParse(dataVal.ToString(), out var dtParsed))
                    {
                        dataFormatada = dtParsed.ToString("dd/MM/yyyy");
                    }
                }

                table.Controls.Add(CriarLabel($"{refUsa} — Finalizado em: {dataFormatada}"));
            }

            tabPage.Controls.Add(table);
        }


        private void GerarNotificacoes(List<BsonDocument> processos)
        {
            var novas = new List<Notificacao>();

            foreach (var p in processos)
            {
                string refUsa = p.GetValue("Ref_USA", BsonNull.Value)?.ToString() ?? "";
                if (!DateTime.TryParse(p.GetValue("DataDeAtracacao", BsonNull.Value)?.ToString(), out var dt))
                    continue;

                int dias = (dt - DateTime.Today).Days;

                // até 15 dias
                if (dias <= 15 && dias >= 0)
                {
                    var msg15 = $"Processo {refUsa}: Dar entrada no Mapa/Anvisa";
                    if (!_notificacaoRepo.ExisteNotificacao(refUsa, msg15))
                    {
                        novas.Add(new Notificacao
                        {
                            RefUsa = refUsa,
                            Mensagem = msg15,
                            DataCriacao = DateTime.Now,
                            Visualizado = false
                        });
                    }
                }
                // até 5 dias
                if (dias <= 5 && dias >= 0)
                {
                    var msg5 = $"Processo {refUsa}: Redestinar container ao terminal";
                    if (!_notificacaoRepo.ExisteNotificacao(refUsa, msg5))
                    {
                        novas.Add(new Notificacao
                        {
                            RefUsa = refUsa,
                            Mensagem = msg5,
                            DataCriacao = DateTime.Now,
                            Visualizado = false
                        });
                    }
                }
            }

            // persiste somente as realmente novas
            foreach (var n in novas)
                _notificacaoRepo.SalvarNotificacao(n);
        }


        private void AtualizarNotificacoes()
        {
            MenuItemNotifications.DropDownItems.Clear();

            var pendentes = _notificacaoRepo.ObterNotificacoesNaoVisualizadas();

            // Atualiza o texto do menu com a contagem
            int qtd = pendentes.Count;
            MenuItemNotifications.Text = qtd > 0
                ? $"Notificações ({qtd})"
                : "Notificações";

            if (!pendentes.Any())
            {
                MenuItemNotifications.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = "Sem notificações",
                    Enabled = false
                });
                return;
            }

            foreach (var notif in pendentes)
            {
                var item = new ToolStripMenuItem
                {
                    Text = notif.Mensagem ?? "",
                    Tag = notif.RefUsa
                };
                item.MouseDown += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right &&
                        sender is ToolStripMenuItem mnu &&
                        mnu.Tag is string refUsa &&
                        !string.IsNullOrEmpty(refUsa))
                    {
                        var resp = MessageBox.Show(
                            $"Deseja finalizar a notificação {refUsa}?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (resp == DialogResult.Yes)
                        {
                            _notificacaoRepo.MarcarComoVisualizado(refUsa, mnu.Text);
                            AtualizarNotificacoes();
                            MessageBox.Show("Notificação finalizada.", "Sucesso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                };
                MenuItemNotifications.DropDownItems.Add(item);
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_logoutPeloMenu && e.CloseReason == CloseReason.UserClosing)
            {
                // Usuário clicou no X: fecha tudo mesmo
                Application.Exit(); // encerra a aplicação inteira
            }
            else if (_logoutPeloMenu)
            {
                // Logout via menu: deixa fechar normalmente e volta para o login
                this.DialogResult = DialogResult.OK;
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            _logoutPeloMenu = true; // sinaliza que é logout via menu
            new FrmLogin().Show();
            this.Close();
        }
        // exemplos de handlers de menu
        private void MenuItemHome_Click(object sender, EventArgs e)
        {
            TCabas.Visible = true;
            foreach (var f in MdiChildren) f.Close();
            _ = CarregarDadosProcessos();
        }
        private T ShowSingleFormOfType<T>() where T : Form, new()
        {
            TCabas.Visible = false;
            foreach (var kvp in _forms.ToList())
            {
                if (kvp.Key != typeof(T))
                {
                    kvp.Value.Close();
                    _forms.Remove(kvp.Key);
                }
            }

            if (_forms.TryGetValue(typeof(T), out var form) && !form.IsDisposed)
            {
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                form.BringToFront();
                return (T)form;
            }

            var novo = new T { MdiParent = this };
            novo.Show();
            _forms[typeof(T)] = novo;
            return novo;
        }
        private void MenuItemMaximize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Maximized;
        private void MenuItemMinimize_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Minimized;
        private void MenuItemMap_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmMapa>();
        private void MenuItemAnvisa_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmAnvisa>();
        private void MenuItemDecex_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmDecex>();
        private void MenuItemIbama_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmIbama>();
        private void MenuItemImetro_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmImetro>();
        private void MenuItemProcess_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmProcesso>();
        private void MenuItemAdmin_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmAdmin>();
        private void MenuItemFinanceiro_Click(object sender, EventArgs e)
            => ShowSingleFormOfType<FrmFinanceiro>();
    }
}
