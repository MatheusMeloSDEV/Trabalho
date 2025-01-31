using CLUSA;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Trabalho
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            if (!FrmLogin.Instance.Logado.admin)
            {
                MenuItemAdmin.Visible = false;
            }

            timerReleaseExit.Interval = 3000;
            timerReleaseExit.Tick += TimerReleaseExit_Tick;
            MenuItemExit.Enabled = false;
            timerReleaseExit.Start();

            if (FrmLogin.Instance.Escuro)
            {
                AplicarModoEscuro();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            _ = CarregarDadosProcessos();
            TCabas.Visible = true;
        }

        private async Task CarregarDadosProcessos()
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
                var database = client.GetDatabase("Trabalho");
                var processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
                var notificacaoRepo = new RepositorioNotificacao(database);

                var processos = await processoCollection.Find(new BsonDocument()).ToListAsync();
                Console.WriteLine($"Foram encontrados {processos.Count} processos no banco de dados.");

                var tabPage = TCabas.TabPages["DataDeAtracacao"] ??
                              new TabPage("Data de Atracação") { Name = "DataDeAtracacao" };

                if (!TCabas.TabPages.Contains(tabPage))
                {
                    TCabas.TabPages.Add(tabPage);
                }
                tabPage.Controls.Clear();

                var tableLayout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    ColumnCount = 1
                };

                foreach (var processo in processos)
                {
                    string refUsa = processo.Contains("Ref_USA") ? processo["Ref_USA"].AsString : "N/A";
                    string sr = processo.Contains("SR") ? processo["SR"].AsString : "N/A";
                    string dataAtracacao = processo.Contains("DataDeAtracacao") ? processo["DataDeAtracacao"].AsString : "N/A";

                    string diasRestantes = string.Empty;
                    if (DateTime.TryParse(dataAtracacao, out DateTime atracacaoDate))
                    {
                        int dias = (atracacaoDate - DateTime.Today).Days;
                        diasRestantes = $"{dias} dia(s)";

                        string? mensagem = null;
                        if (dias == 5)
                            mensagem = $"Processo {refUsa}: Redestinar container ao terminal";
                        else if (dias == 15)
                            mensagem = $"Processo {refUsa}: Dar entrada no Mapa/Anvisa";

                        if (!string.IsNullOrEmpty(mensagem))
                        {
                            var notificacao = new Notificacao
                            {
                                RefUsa = refUsa,
                                Mensagem = mensagem,
                                DataCriacao = DateTime.Now,
                                Visualizado = false
                            };

                            notificacaoRepo.SalvarNotificacao(notificacao);
                        }
                    }

                    var label = new Label
                    {
                        AutoSize = true,
                        Text = $"{refUsa} - {sr} - {dataAtracacao} - {diasRestantes}",
                        Font = new System.Drawing.Font("Segoe UI", 10F),
                        Margin = new Padding(5)
                    };

                    tableLayout.Controls.Add(label);
                }

                tabPage.Controls.Add(tableLayout);

                AtualizarNotificacoes();

                Console.WriteLine("Dados carregados com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar processos: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void AtualizarNotificacoes()
        {
            var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var database = client.GetDatabase("Trabalho");
            var notificacaoRepo = new RepositorioNotificacao(database);

            var processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
            var processos = processoCollection.Find(new BsonDocument()).ToList();

            foreach (var processo in processos)
            {
                string refUsa = processo.Contains("Ref_USA") ? processo["Ref_USA"].AsString : "N/A";
                string dataAtracacao = processo.Contains("DataDeAtracacao") ? processo["DataDeAtracacao"].AsString : "N/A";

                if (DateTime.TryParse(dataAtracacao, out DateTime atracacaoDate))
                {
                    int dias = (atracacaoDate - DateTime.Today).Days;
                    string mensagem = dias switch
                    {
                        5 => $"Processo {refUsa}: Redestinar container ao terminal",
                        15 => $"Processo {refUsa}: Dar entrada no Mapa/Anvisa",
                        _ => string.Empty
                    };

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        var notificacao = new Notificacao
                        {
                            RefUsa = refUsa,
                            Mensagem = mensagem,
                            DataCriacao = DateTime.Now,
                            Visualizado = false
                        };
                        notificacaoRepo.SalvarNotificacao(notificacao);
                    }
                }
            }

            var notificacoesNaoVisualizadas = notificacaoRepo.ObterNotificacoesNaoVisualizadas();
            MenuItemNotifications.DropDownItems.Clear();

            foreach (var notificacao in notificacoesNaoVisualizadas)
            {
                var menuItem = new ToolStripMenuItem
                {
                    Text = notificacao.Mensagem,
                    Tag = notificacao.RefUsa
                };

                menuItem.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var confirmResult = MessageBox.Show(
                            $"Deseja finalizar a notificação {notificacao.RefUsa}?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {
                            notificacaoRepo.MarcarComoVisualizado(notificacao.RefUsa);
                            MenuItemNotifications.DropDownItems.Remove(menuItem);
                            MessageBox.Show("Notificação finalizada com sucesso.",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                };

                MenuItemNotifications.DropDownItems.Add(menuItem);
            }

            if (!MenuItemNotifications.DropDownItems.OfType<ToolStripItem>().Any())
            {
                MenuItemNotifications.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = "Sem notificações",
                    Enabled = false
                });
            }
        }

        private void TimerReleaseExit_Tick(object? sender, EventArgs e)
        {
            timerReleaseExit.Stop();
            MenuItemExit.Enabled = true;
        }

        private void AplicarModoEscuro()
        {
            MSnotificacoes.BackColor = SystemColors.ControlDark;
        }

        private void MenuItemHome_Click(object sender, EventArgs e)
        {
            TCabas.Visible = true;
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            _ = CarregarDadosProcessos();
        }

        private void MenuItemMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private readonly Dictionary<Type, Form> _forms = new();

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

            if (_forms.TryGetValue(typeof(T), out var existingForm) && !existingForm.IsDisposed)
            {
                existingForm.WindowState = FormWindowState.Maximized;
                existingForm.Show();
                existingForm.BringToFront();
                existingForm.Activate();
                return (T)existingForm;
            }

            var newForm = new T { MdiParent = this };
            newForm.Show();

            _forms[typeof(T)] = newForm;
            return newForm;
        }
        private void MenuItemMap_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmMapa>();
        private void MenuItemAnvisa_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmAnvisa>();
        private void MenuItemDecex_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmDecex>();
        private void MenuItemIbama_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmIbama>();
        private void MenuItemImetro_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmImetro>();
        private void MenuItemProcess_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmProcesso>();
        private void MenuItemAdmin_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmAdmin>();
        private void MenuItemFinanceiro_Click(object sender, EventArgs e) => ShowSingleFormOfType<FrmFinanceiro>();

    }
}
