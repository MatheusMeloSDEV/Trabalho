using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;            // Timer vem daqui
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
        // Mantém instâncias únicas dos formulários filhos
            private readonly Dictionary<Type, Form> _forms = new();

        public FrmMenu()
        {
            InitializeComponent();

            this.Shown += FrmMenu_Shown;
            // Inicializa e dispara o timer para habilitar o Exit após 3s
            timerReleaseExit = new System.Windows.Forms.Timer { Interval = 3000 };
            timerReleaseExit.Tick += TimerReleaseExit_Tick;
            MenuItemExit.Enabled = false;
            timerReleaseExit.Start();

            if (FrmLogin.Instance.Logado.admin == false)
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

        private void TimerReleaseExit_Tick(object sender, EventArgs e)
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

                MontarTabProcessos(processos);
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

        private void MontarTabProcessos(List<BsonDocument> processos)
        {
            var tabPage = TCabas.TabPages["DataDeAtracacao"];
            if (tabPage == null)
            {
                tabPage = new TabPage("Data de Atracação") { Name = "DataDeAtracacao" };
                TCabas.TabPages.Add(tabPage);
            }
            tabPage.Controls.Clear();

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                ColumnCount = 1
            };

            foreach (var p in processos)
            {
                var refUsa = p.GetValue("Ref_USA", BsonNull.Value).ToString();
                var sr = p.GetValue("SR", BsonNull.Value).ToString();

                // extrai BsonDateTime se existir, senão tenta converter string
                DateTime dt;
                var bval = p.GetValue("DataDeAtracacao", BsonNull.Value);
                if (bval.IsValidDateTime)
                    dt = bval.ToUniversalTime().ToLocalTime();
                else if (!DateTime.TryParse(bval.ToString(), out dt))
                    dt = DateTime.MinValue;

                var dataFmt = dt != DateTime.MinValue
                    ? dt.ToString("dd/MM/yyyy")
                    : "N/A";

                var dias = dt != DateTime.MinValue
                    ? (dt.Date - DateTime.Today).Days
                    : 0;
                var restantes = dt != DateTime.MinValue
                    ? $"{dias} dia(s)"
                    : "";

                var lbl = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F),
                    Margin = new Padding(5),
                    Text = $"{refUsa} — {sr} — {dataFmt} — {restantes}"
                };
                table.Controls.Add(lbl);
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
                    Tag = notif.RefUsa  // pode ser string vazia, mas Tag aceita
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

        // exemplos de handlers de menu
        private void MenuItemHome_Click(object sender, EventArgs e)
        {
            TCabas.Visible = true;
            foreach (var f in MdiChildren) f.Close();
            _ = CarregarDadosProcessos();
        }
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
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
