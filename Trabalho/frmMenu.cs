using CLUSA;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmMenu : Form
    {
        private FrmMapa? _mapaForm;
        private FrmAdmin? _adminForm;
        private FrmDecex? _decexForm;
        private FrmProcesso? _processoForm;
        private FrmAnvisa? _anvisaForm;

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
                ApplyDarkMode();
            }
            LoadProcessData();
            ImagensBotoes();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x200000; // WS_MINIMIZEBOX: Remove o estilo que permite minimizar
                return cp;
            }
        }

        private void ImagensBotoes()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("Trabalho.Imagens.icon_edit.png");
            if (stream != null)
            {
                MenuItemNotifications.Image = Image.FromStream(stream);
            }
        }

        private async void LoadProcessData()
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
                var database = client.GetDatabase("Trabalho");
                var processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
                var notificacaoRepo = new RepositorioNotificacao(database);

                var processos = await processoCollection.Find(new BsonDocument()).ToListAsync();
                Console.WriteLine($"Found {processos.Count} processes in the database.");

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
                    string refUsa = processo.Contains("RefUsa") ? processo["RefUsa"].AsString : "N/A";
                    string sr = processo.Contains("SR") ? processo["SR"].AsString : "N/A";
                    string dataAtracacao = processo.Contains("DataDeAtracacao") ? processo["DataDeAtracacao"].AsString : "N/A";

                    string diasRestantes = string.Empty;
                    if (DateTime.TryParse(dataAtracacao, out DateTime dataAtracacaoDt))
                    {
                        int dias = (dataAtracacaoDt - DateTime.Today).Days;
                        diasRestantes = $"{dias} dia(s)";

                        string? mensagem = null;

                        if (dias >= 0 && dias <= 5)
                        {
                            mensagem = $"Processo {refUsa}: Redestinar container ao terminal";
                        }
                        else if (dias >= 0 && dias <= 15)
                        {
                            mensagem = $"Processo {refUsa}: Dar entrada no Mapa/Anvisa";
                        }

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
                UpdateNotifications();
                Console.WriteLine("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading process data: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void UpdateNotifications()
        {
            var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var database = client.GetDatabase("Trabalho");
            var notificacaoRepo = new RepositorioNotificacao(database);

            var notificacoesNaoVisualizadas = notificacaoRepo.ObterNotificacoesNaoVisualizadas();
            MenuItemNotifications.DropDownItems.Clear();

            Console.WriteLine($"Notificações não visualizadas: {notificacoesNaoVisualizadas.Count}");

            if (notificacoesNaoVisualizadas.Any())
            {
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
                            if (MessageBox.Show(
                                    $"Deseja finalizar a notificação {notificacao.RefUsa}?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                notificacaoRepo.MarcarComoVisualizado(notificacao.RefUsa);
                                MenuItemNotifications.DropDownItems.Remove(menuItem);
                                LoadProcessData();
                                Console.WriteLine($"Notificação {notificacao.RefUsa} removida.");
                            }
                        }
                    };

                    MenuItemNotifications.DropDownItems.Add(menuItem);
                }

                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                using var stream = assembly.GetManifestResourceStream("Trabalho.Imagens.botao-ativar-notificacoes.png");
                if (stream != null)
                {
                    MenuItemNotifications.Image = Image.FromStream(stream);
                }
            }
            else
            {
                MenuItemNotifications.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = "Sem notificações",
                    Enabled = false
                });

                var assembly = System.Reflection.Assembly.GetExecutingAssembly();
                using var stream = assembly.GetManifestResourceStream("Trabalho.Imagens.botao-de-notificacoes.png");
                if (stream != null)
                {
                    MenuItemNotifications.Image = Image.FromStream(stream);
                }
            }
        }

        private void TimerReleaseExit_Tick(object? sender, EventArgs e)
        {
            timerReleaseExit.Stop();
            MenuItemExit.Enabled = true;
        }

        private void ApplyDarkMode()
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
            LoadProcessData();
        }

        private void OpenForm<T>(ref T? form) where T : Form, new()
        {
            foreach (var childForm in MdiChildren)
            {
                childForm.Close();
            }

            SuspendLayout();

            if (form == null || form.IsDisposed)
            {
                form = new T
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                form.Show();
                form.Refresh();
            }
            else
            {
                if (form.MdiParent != this)
                {
                    form.MdiParent = this;
                }

                form.WindowState = FormWindowState.Normal;
                form.WindowState = FormWindowState.Maximized;
                form.BringToFront();
                form.Show();
                form.Refresh();
            }

            ResumeLayout();
        }

        private void MenuItemMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new();
            frmLogin.Show();
        }

        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            TCabas.Visible = true;
        }

        private void MenuItemMap_Click(object sender, EventArgs e) { TCabas.Visible = false; OpenForm(ref _mapaForm); }
        private void MenuItemAnvisa_Click(object sender, EventArgs e) { TCabas.Visible = false; OpenForm(ref _anvisaForm); }
        private void MenuItemDecex_Click(object sender, EventArgs e) { TCabas.Visible = false; OpenForm(ref _decexForm); }
        private void MenuItemProcess_Click(object sender, EventArgs e) { TCabas.Visible = false; OpenForm(ref _processoForm); }
        private void MenuItemAdmin_Click(object sender, EventArgs e) { TCabas.Visible = false; OpenForm(ref _adminForm); }
    }
}
