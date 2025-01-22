using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));

            // MenuStrip
            MSnotificacoes = new MenuStrip
            {
                BackColor = SystemColors.Control,
                Location = new Point(0, 0),
                Name = "MSnotificacoes",
                Size = new Size(878, 24),
                TabIndex = 1,
                Text = "MSnotificacoes"
            };

            // Notificações
            MenuItemNotifications = new ToolStripMenuItem
            {
                Name = "MenuItemNotifications",
                Size = new Size(101, 20),
                Text = "Notificações",
                TextImageRelation = TextImageRelation.TextBeforeImage
            };

            // Menu principal
            MenuItemMain = new ToolStripMenuItem
            {
                Name = "MenuItemMain",
                Size = new Size(50, 20),
                Text = "Menu"
            };
            MenuItemMain.DropDownItems.AddRange(new ToolStripItem[]
            {
                MenuItemHome = new ToolStripMenuItem
                {
                    Name = "MenuItemHome",
                    Size = new Size(129, 22),
                    Text = "Início"
                },
                MenuItemMaximize = new ToolStripMenuItem
                {
                    Name = "MenuItemMaximize",
                    Size = new Size(129, 22),
                    Text = "Maximizar"
                },
                MenuItemExit = new ToolStripMenuItem
                {
                    Name = "MenuItemExit",
                    Size = new Size(129, 22),
                    Text = "Sair"
                }
            });

            MenuItemHome.Click += MenuItemHome_Click;
            MenuItemMaximize.Click += MenuItemMaximize_Click;
            MenuItemExit.Click += MenuItemExit_Click;

            // Planilhas
            MenuItemSheets = new ToolStripMenuItem
            {
                Name = "MenuItemSheets",
                Size = new Size(66, 20),
                Text = "Planilhas"
            };
            MenuItemSheets.DropDownItems.AddRange(new ToolStripItem[]
            {
                MenuItemProcess = new ToolStripMenuItem
                {
                    Name = "MenuItemProcess",
                    Size = new Size(121, 22),
                    Text = "Processo"
                },
                MenuItemMap = new ToolStripMenuItem
                {
                    Name = "MenuItemMap",
                    Size = new Size(121, 22),
                    Text = "Mapa"
                },
                MenuItemAnvisa = new ToolStripMenuItem
                {
                    Name = "MenuItemAnvisa",
                    Size = new Size(121, 22),
                    Text = "Anvisa"
                },
                MenuItemDecex = new ToolStripMenuItem
                {
                    Name = "MenuItemDecex",
                    Size = new Size(121, 22),
                    Text = "Decex"
                },
                MenuItemIbama = new ToolStripMenuItem
                {
                    Name = "MenuItemIbama",
                    Size = new Size(121, 22),
                    Text = "Ibama"
                },
                MenuItemImetro = new ToolStripMenuItem
                {
                    Name = "MenuItemImetro",
                    Size = new Size(121, 22),
                    Text = "Imetro"
                }
            });

            MenuItemProcess.Click += MenuItemProcess_Click;
            MenuItemMap.Click += MenuItemMap_Click;
            MenuItemAnvisa.Click += MenuItemAnvisa_Click;
            MenuItemDecex.Click += MenuItemDecex_Click;
            MenuItemIbama.Click += MenuItemIbama_Click;
            MenuItemImetro.Click += MenuItemImetro_Click;

            // Administrador
            MenuItemAdmin = new ToolStripMenuItem
            {
                Name = "MenuItemAdmin",
                Size = new Size(95, 20),
                Text = "Administrador"
            };
            MenuItemAdmin.Click += MenuItemAdmin_Click;

            // Adicionar itens ao MenuStrip
            MSnotificacoes.Items.AddRange(new ToolStripItem[]
            {
                MenuItemNotifications,
                MenuItemMain,
                MenuItemSheets,
                MenuItemAdmin
            });

            // Timer
            timerReleaseExit = new System.Windows.Forms.Timer(components)
            {
                Interval = 1000 // Exemplo de intervalo, ajuste conforme necessário
            };
            timerReleaseExit.Tick += TimerReleaseExit_Tick;

            // TabControl
            TCabas = new TabControl
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Location = new Point(160, 68),
                Name = "TCabas",
                SelectedIndex = 0,
                Size = new Size(528, 323),
                SizeMode = TabSizeMode.FillToRight,
                TabIndex = 5
            };

            // Configuração do Formulário
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 448);
            ControlBox = false;
            Controls.Add(TCabas);
            Controls.Add(MSnotificacoes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = MSnotificacoes;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área de trabalho";
            WindowState = FormWindowState.Maximized;

            MSnotificacoes.ResumeLayout(false);
            MSnotificacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MSnotificacoes;
        private ToolStripMenuItem MenuItemNotifications;
        private ToolStripMenuItem MenuItemMain;
        private ToolStripMenuItem MenuItemHome;
        private ToolStripMenuItem MenuItemMaximize;
        private ToolStripMenuItem MenuItemExit;
        private ToolStripMenuItem MenuItemSheets;
        private ToolStripMenuItem MenuItemProcess;
        private ToolStripMenuItem MenuItemMap;
        private ToolStripMenuItem MenuItemAnvisa;
        private ToolStripMenuItem MenuItemDecex;
        private ToolStripMenuItem MenuItemIbama;
        private ToolStripMenuItem MenuItemImetro;
        private ToolStripMenuItem MenuItemAdmin;
        private System.Windows.Forms.Timer timerReleaseExit;
        private TabControl TCabas;
    }
}
