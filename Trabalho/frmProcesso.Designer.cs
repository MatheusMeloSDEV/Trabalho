using System.Windows.Forms;

namespace Trabalho
{
    partial class FrmProcesso
    {
        private System.ComponentModel.IContainer components = null;

        // ToolStrip e controles
        private ToolStrip ToolStrip1;
        private ToolStripButton BtnAdicionar;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnExcluir;
        private ToolStripButton BtnExportar;
        private ToolStripButton BtnPesquisar;
        private ToolStripButton BtnCancelar;
        private ToolStripTextBox TxtPesquisar;
        private ToolStripComboBox CmbPesquisar;

        // DataGridView
        private DataGridView DataGridView1;

        // BindingSource
        private BindingSource BsProcesso;

        /// <summary>
        /// Liberar recursos utilizados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                BsProcesso.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BsProcesso = new BindingSource(components);

            #region ToolStrip Configuração

            ToolStrip1 = new ToolStrip
            {
                GripStyle = ToolStripGripStyle.Hidden,
                RenderMode = ToolStripRenderMode.System,
                BackColor = Color.WhiteSmoke,
                AutoSize = false,
                Height = 40,
                Padding = new Padding(5, 5, 5, 5)
            };

            // Fonte padrão para botões
            var defaultFont = new Font("Segoe UI", 10);

            // Botão Adicionar
            BtnAdicionar = new ToolStripButton
            {
                Text = "Adicionar",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.botao-adicionar.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText,
            };
            BtnAdicionar.Click += BtnAdicionar_Click;

            // Botão Editar
            BtnEditar = new ToolStripButton
            {
                Text = "Editar",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.botao-editar.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText
            };
            BtnEditar.Click += BtnEditar_Click;

            // Botão Excluir
            BtnExcluir = new ToolStripButton
            {
                Text = "Excluir",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.excluir.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText,
            };
            BtnExcluir.Click += BtnExcluir_Click;

            // Botão Exportar
            BtnExportar = new ToolStripButton
            {
                Text = "Exportar",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.exportar.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText,
            };
            BtnExportar.Click += BtnExportar_Click;

            // Botão Pesquisar
            BtnPesquisar = new ToolStripButton
            {
                Text = "Pesquisar",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.lupa-de-pesquisa.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Alignment = ToolStripItemAlignment.Right
            };
            BtnPesquisar.Click += BtnPesquisar_Click;

            // Botão Cancelar
            BtnCancelar = new ToolStripButton
            {
                Text = "Cancelar",
                Font = defaultFont,
                Image = CarregarImagemDoRecurso("Trabalho.Imagens.cancelar.png"),
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Alignment = ToolStripItemAlignment.Right
            };
            BtnCancelar.Click += BtnCancelar_Click;

            // Campo de Texto para Pesquisar
            TxtPesquisar = new ToolStripTextBox
            {
                Font = defaultFont,
                Size = new Size(200, 25),
                Alignment = ToolStripItemAlignment.Right
            };

            // ComboBox para Seleção de Campo
            CmbPesquisar = new ToolStripComboBox
            {
                Font = defaultFont,
                Size = new Size(150, 25),
                Alignment = ToolStripItemAlignment.Right,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            CmbPesquisar.SelectedIndexChanged += CmbPesquisar_SelectedIndexChanged;

            // Adicionar itens ao ToolStrip
            ToolStrip1.Items.AddRange(new ToolStripItem[]
            {
                BtnAdicionar,
                new ToolStripSeparator(),
                BtnEditar,
                new ToolStripSeparator(),
                BtnExcluir,
                new ToolStripSeparator(),
                BtnExportar,
                new ToolStripSeparator(),
                BtnCancelar,
                new ToolStripSeparator { Alignment = ToolStripItemAlignment.Right },
                BtnPesquisar,
                CmbPesquisar,
                TxtPesquisar
            });

            #endregion

            #region DataGridView Configuração

            DataGridView1 = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoGenerateColumns = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                EnableHeadersVisualStyles = false,
                Location = new Point(12, 50),
                Name = "DataGridView1",
                ReadOnly = true,
                RowHeadersVisible = false,
                RowTemplate = { Height = 25 },
                Size = new Size(776, 388),
                BorderStyle = BorderStyle.FixedSingle,
                BackgroundColor = Color.White,
            };

            DataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

            // Estilo do cabeçalho
            DataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True
            };

            // Estilo das células
            DataGridView1.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10),
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightBlue,
                SelectionForeColor = Color.Black,
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            // Ajuste automático das colunas
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo alternado nas linhas
            DataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.WhiteSmoke
            };

            #endregion

            #region Form Configuração

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView1);
            Controls.Add(ToolStrip1);
            Text = "Gerenciamento de Processos";
            WindowState = FormWindowState.Maximized;
            ControlBox = false;

            Load += FrmProcesso_Load;

            #endregion
        }
    }
}
