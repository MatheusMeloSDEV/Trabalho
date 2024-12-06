using CLUSA;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Trabalho
{
    public partial class frmMenu : Form
    {
        frmMapa mapa;
        frmADMIN admin;
        frmDecex decex;
        frmMenu instance;
        frmProcesso processo;
        frmAnvisa anvisa;

        public frmMenu()
        {
            InitializeComponent();
            instance = this;
            if (frmLogin.instance.logado.admin == false)
            {
                aDMINToolStripMenuItem.Visible = false;
            }
            tLiberaSaida.Interval = 3000;
            tLiberaSaida.Tick += new System.EventHandler(this.tLiberaSaida_Tick);
            sairToolStripMenuItem.Enabled = false;
            tLiberaSaida.Start();
            if (frmLogin.instance.escuro)
            {
                DarkMode();
            }

        }

        private void CarregarDadosProcessos()
        {
            var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var database = client.GetDatabase("Trabalho");
            var processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
            var notificacaoRepo = new RepositorioNotificacao(database);

            try
            {
                // Obter todos os processos
                var processos = processoCollection.Find(new BsonDocument()).ToList();
                Console.WriteLine($"Foram encontrados {processos.Count} processos no banco de dados.");

                // Verificar se a TabPage "Data de Atracação" já existe
                TabPage tabPage = tabControl1.TabPages["Data de Atracação"];
                if (tabPage == null)
                {
                    tabPage = new TabPage("Data de Atracação")
                    {
                        Name = "Data de Atracação"
                    };
                    tabControl1.TabPages.Add(tabPage);
                }
                else
                {
                    tabPage.Controls.Clear();
                }

                // Criar um TableLayoutPanel para organizar os dados
                var tableLayout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    ColumnCount = 1
                };

                // Preencher o TableLayoutPanel com os dados dos processos
                foreach (var processo in processos)
                {
                    string refUsa = processo.Contains("Ref_USA") ? processo["Ref_USA"].AsString : "N/A";
                    string sr = processo.Contains("SR") ? processo["SR"].AsString : "N/A";
                    string dataAtracacao = processo.Contains("DataDeAtracacao") ? processo["DataDeAtracacao"].AsString : "N/A";

                    // Calcular o tempo restante
                    string diasRestantes = string.Empty;
                    if (DateTime.TryParse(dataAtracacao, out DateTime dataAtracacaoDt))
                    {
                        int dias = (dataAtracacaoDt - DateTime.Today).Days;
                        diasRestantes = $"{dias} dia(s)";

                        // Verificar se há necessidade de gerar notificações
                        string mensagem = null;
                        if (dias == 5)
                        {
                            mensagem = $"Processo {refUsa}: Redestinar container ao terminal";
                        }
                        else if (dias == 15)
                        {
                            mensagem = $"Processo {refUsa}: Dar entrada no Mapa/Anvisa";
                        }

                        // Criar ou atualizar a notificação no banco
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

                    // Criar uma Label para exibir o processo
                    var label = new Label
                    {
                        AutoSize = true,
                        Text = $"{refUsa} - {sr} - {dataAtracacao} - {diasRestantes}",
                        Font = new System.Drawing.Font("Segoe UI", 10F),
                        Margin = new Padding(5)
                    };

                    // Adicionar a Label ao TableLayoutPanel
                    tableLayout.Controls.Add(label);
                }

                // Adicionar o TableLayoutPanel à TabPage
                tabPage.Controls.Add(tableLayout);

                // Atualizar notificações no MenuStrip
                AtualizarNotificacoes();

                Console.WriteLine("Dados carregados com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar processos: {ex.Message}");
            }
        }


        private void AtualizarNotificacoes()
        {
            var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var database = client.GetDatabase("Trabalho");
            var processoCollection = database.GetCollection<BsonDocument>("PROCESSO");
            var notificacaoRepo = new RepositorioNotificacao(database);

            var processos = processoCollection.Find(new BsonDocument()).ToList();

            // Gerar ou atualizar notificações
            foreach (var processo in processos)
            {
                string refUsa = processo.Contains("Ref_USA") ? processo["Ref_USA"].AsString : "N/A";
                string dataAtracacao = processo.Contains("DataDeAtracacao") ? processo["DataDeAtracacao"].AsString : "N/A";

                if (DateTime.TryParse(dataAtracacao, out DateTime dataAtracacaoDt))
                {
                    int diasRestantes = (dataAtracacaoDt - DateTime.Today).Days;

                    string mensagem = null;
                    if (diasRestantes == 5)
                    {
                        mensagem = $"Processo {refUsa}: Redestinar container ao terminal";
                    }
                    else if (diasRestantes == 15)
                    {
                        mensagem = $"Processo {refUsa}: Dar entrada no Mapa/Anvisa";
                    }

                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        // Antes de salvar, verificar se já está visualizado
                        var notificacaoExistente = notificacaoRepo.ObterNotificacaoPorRefUsa(refUsa);
                        var visualizado = notificacaoExistente?.Visualizado ?? false;

                        var notificacao = new Notificacao
                        {
                            RefUsa = refUsa,
                            Mensagem = mensagem,
                            DataCriacao = DateTime.Now,
                            Visualizado = visualizado // Preserva o estado atual de visualizado
                        };

                        notificacaoRepo.SalvarNotificacao(notificacao);
                    }
                }
            }

            // Exibir notificações no MenuStrip
            var notificacoesNaoVisualizadas = notificacaoRepo.ObterNotificacoesNaoVisualizadas();
            notificacoesDropDownButton.DropDownItems.Clear();

            foreach (var notificacao in notificacoesNaoVisualizadas)
            {
                var menuItem = new ToolStripMenuItem
                {
                    Text = notificacao.Mensagem,
                    Tag = notificacao.RefUsa
                };

                menuItem.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Right) // Verificar se o botão direito foi clicado
                    {
                        // Exibir uma mensagem de confirmação
                        var confirmResult = MessageBox.Show(
                            $"Tem certeza de que deseja finalizar a notificação para o processo {notificacao.RefUsa}?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Marcar como visualizado e remover do MenuStrip
                            notificacaoRepo.MarcarComoVisualizado(notificacao.RefUsa);
                            notificacoesDropDownButton.DropDownItems.Remove(menuItem);

                            // Opcional: Exibir um feedback ao usuário
                            MessageBox.Show("Notificação finalizada com sucesso.",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                };


                notificacoesDropDownButton.DropDownItems.Add(menuItem);
            }

            if (notificacoesDropDownButton.DropDownItems.Count == 0)
            {
                notificacoesDropDownButton.DropDownItems.Add(new ToolStripMenuItem
                {
                    Text = "Sem notificações",
                    Enabled = false
                });
            }
        }



        public void TestarSalvarNotificacao()
        {
            var client = new MongoClient("mongodb+srv://dev:dev@cluster0.cn10nzt.mongodb.net/");
            var database = client.GetDatabase("Trabalho");
            var notificacaoRepo = new RepositorioNotificacao(database);

            var notificacao = new Notificacao
            {
                RefUsa = "TEST123",
                Mensagem = "Testando notificação",
                DataCriacao = DateTime.Now,
                Visualizado = false
            };

            notificacaoRepo.SalvarNotificacao(notificacao);
        }


        private void mAPAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (mapa == null)
            {
                tabControl1.Visible = false;
                frmMapa MapaForm = new frmMapa();

                MapaForm.MdiParent = this;
                MapaForm.Show();
            }
            else
            {
                mapa.Activate();
            }
        }

        private void DarkMode()
        {
            menuStrip1.BackColor = SystemColors.ControlDark;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                tabControl1.Visible = false;
                frmADMIN ADMINForm = new frmADMIN();

                ADMINForm.MdiParent = this;
                ADMINForm.Show();

            }
            else
            {
                admin.Activate();
            }
        }

        private void decexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decex == null)
            {
                tabControl1.Visible = false;
                frmDecex DecexForm = new frmDecex();

                DecexForm.MdiParent = this;
                DecexForm.Show();
            }
            else
            {
                decex.Activate();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            CarregarDadosProcessos();
            tabControl1.Visible = true;
        }

        private void tLiberaSaida_Tick(object sender, EventArgs e)
        {
            tLiberaSaida.Stop();
            sairToolStripMenuItem.Enabled = true;
        }

        private void processoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processo == null)
            {
                tabControl1.Visible = false;
                frmProcesso ProcessoForm = new frmProcesso();

                ProcessoForm.MdiParent = this;
                ProcessoForm.Show();

            }
            else
            {
                processo.Activate();
            }
        }

        private void anvisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (anvisa == null)
            {
                tabControl1.Visible = false;
                frmAnvisa AnvisaForm = new frmAnvisa();

                AnvisaForm.MdiParent = this;
                AnvisaForm.Show();

            }
            else
            {
                anvisa.Activate();
            }
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            foreach (Form childForm in this.MdiChildren)
            {
                // Fecha cada formulário filho
                childForm.Close();
            }
            CarregarDadosProcessos();
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void DisplayNotifications()
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestarSalvarNotificacao();  
        }
    }
}
