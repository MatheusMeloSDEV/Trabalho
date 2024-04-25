namespace Trabalho
{
    partial class frmMapa
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            bsMAPA = new BindingSource(components);
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnPesquisar = new ToolStripButton();
            txtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
            nRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            previsaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terminalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pendenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cSIOriginalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeEntradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametrizacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sEIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeInspeçãoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nRDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            previsaoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            terminalDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pendenciaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            CSIOriginal = new DataGridViewTextBoxColumn();
            lIDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lPCODataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataDeEntradaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            parametrizacaoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sEIDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataDeInspeçãoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsMAPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bsMAPA
            // 
            bsMAPA.DataMember = "ListaMapa";
            bsMAPA.DataSource = typeof(CLUSA.RepositorioMAPA);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nRDataGridViewTextBoxColumn1, sRDataGridViewTextBoxColumn1, importadorDataGridViewTextBoxColumn1, previsaoDataGridViewTextBoxColumn1, terminalDataGridViewTextBoxColumn1, pendenciaDataGridViewTextBoxColumn1, CSIOriginal, lIDataGridViewTextBoxColumn1, lPCODataGridViewTextBoxColumn1, dataDeEntradaDataGridViewTextBoxColumn1, parametrizacaoDataGridViewTextBoxColumn1, sEIDataGridViewTextBoxColumn1, dataDeInspeçãoDataGridViewTextBoxColumn1, statusDoProcessoDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = bsMAPA;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnExcluir, btnEditar, btnCancelar, btnPesquisar, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.GreenYellow;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Margin = new Padding(5, 4, 0, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(62, 32);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(5, 4, 0, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(62, 32);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.BackColor = Color.MediumTurquoise;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Margin = new Padding(5, 4, 0, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 32);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Alignment = ToolStripItemAlignment.Right;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.DisplayStyle = ToolStripItemDisplayStyle.None;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Margin = new Padding(0, 4, 0, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(23, 32);
            btnCancelar.Text = "toolStripButton2";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Alignment = ToolStripItemAlignment.Right;
            btnPesquisar.BackgroundImage = (Image)resources.GetObject("btnPesquisar.BackgroundImage");
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.DisplayStyle = ToolStripItemDisplayStyle.None;
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageTransparentColor = Color.Magenta;
            btnPesquisar.Margin = new Padding(0, 4, 0, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(23, 32);
            btnPesquisar.Text = "toolStripButton1";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Alignment = ToolStripItemAlignment.Right;
            txtPesquisar.Margin = new Padding(0, 4, 3, 0);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(250, 34);
            txtPesquisar.KeyUp += txtPesquisar_KeyUp;
            // 
            // CmbPesquisar
            // 
            CmbPesquisar.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisar.AutoSize = false;
            CmbPesquisar.Items.AddRange(new object[] { "Importador", "Navio", "Terminal", "Armazem", "Anuete" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            // 
            // nRDataGridViewTextBoxColumn
            // 
            nRDataGridViewTextBoxColumn.DataPropertyName = "NR";
            nRDataGridViewTextBoxColumn.Frozen = true;
            nRDataGridViewTextBoxColumn.HeaderText = "NR";
            nRDataGridViewTextBoxColumn.Name = "nRDataGridViewTextBoxColumn";
            nRDataGridViewTextBoxColumn.Width = 30;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn.Frozen = true;
            sRDataGridViewTextBoxColumn.HeaderText = "SR";
            sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            sRDataGridViewTextBoxColumn.Width = 30;
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.DividerWidth = 5;
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            previsaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            // 
            // pendenciaDataGridViewTextBoxColumn
            // 
            pendenciaDataGridViewTextBoxColumn.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.HeaderText = "Pendência";
            pendenciaDataGridViewTextBoxColumn.Name = "pendenciaDataGridViewTextBoxColumn";
            // 
            // cSIOriginalDataGridViewTextBoxColumn
            // 
            cSIOriginalDataGridViewTextBoxColumn.DataPropertyName = "CSI_Original";
            cSIOriginalDataGridViewTextBoxColumn.HeaderText = "CSI Original";
            cSIOriginalDataGridViewTextBoxColumn.Name = "cSIOriginalDataGridViewTextBoxColumn";
            // 
            // lIDataGridViewTextBoxColumn
            // 
            lIDataGridViewTextBoxColumn.DataPropertyName = "LI";
            lIDataGridViewTextBoxColumn.HeaderText = "LI";
            lIDataGridViewTextBoxColumn.Name = "lIDataGridViewTextBoxColumn";
            // 
            // lPCODataGridViewTextBoxColumn
            // 
            lPCODataGridViewTextBoxColumn.DataPropertyName = "LPCO";
            lPCODataGridViewTextBoxColumn.HeaderText = "LPCO";
            lPCODataGridViewTextBoxColumn.Name = "lPCODataGridViewTextBoxColumn";
            // 
            // dataDeEntradaDataGridViewTextBoxColumn
            // 
            dataDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            dataDeEntradaDataGridViewTextBoxColumn.Name = "dataDeEntradaDataGridViewTextBoxColumn";
            // 
            // parametrizacaoDataGridViewTextBoxColumn
            // 
            parametrizacaoDataGridViewTextBoxColumn.DataPropertyName = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn.HeaderText = "Parametrização";
            parametrizacaoDataGridViewTextBoxColumn.Name = "parametrizacaoDataGridViewTextBoxColumn";
            // 
            // sEIDataGridViewTextBoxColumn
            // 
            sEIDataGridViewTextBoxColumn.DataPropertyName = "SEI";
            sEIDataGridViewTextBoxColumn.HeaderText = "SEI";
            sEIDataGridViewTextBoxColumn.Name = "sEIDataGridViewTextBoxColumn";
            // 
            // dataDeInspeçãoDataGridViewTextBoxColumn
            // 
            dataDeInspeçãoDataGridViewTextBoxColumn.DataPropertyName = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.HeaderText = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.Name = "dataDeInspeçãoDataGridViewTextBoxColumn";
            // 
            // statusDoProcessoDataGridViewTextBoxColumn
            // 
            statusDoProcessoDataGridViewTextBoxColumn.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nRDataGridViewTextBoxColumn1
            // 
            nRDataGridViewTextBoxColumn1.DataPropertyName = "NR";
            nRDataGridViewTextBoxColumn1.HeaderText = "NR";
            nRDataGridViewTextBoxColumn1.Name = "nRDataGridViewTextBoxColumn1";
            nRDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sRDataGridViewTextBoxColumn1
            // 
            sRDataGridViewTextBoxColumn1.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn1.HeaderText = "SR";
            sRDataGridViewTextBoxColumn1.Name = "sRDataGridViewTextBoxColumn1";
            sRDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // importadorDataGridViewTextBoxColumn1
            // 
            importadorDataGridViewTextBoxColumn1.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn1.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn1.Name = "importadorDataGridViewTextBoxColumn1";
            importadorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // previsaoDataGridViewTextBoxColumn1
            // 
            previsaoDataGridViewTextBoxColumn1.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn1.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn1.Name = "previsaoDataGridViewTextBoxColumn1";
            previsaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // terminalDataGridViewTextBoxColumn1
            // 
            terminalDataGridViewTextBoxColumn1.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn1.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn1.Name = "terminalDataGridViewTextBoxColumn1";
            terminalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pendenciaDataGridViewTextBoxColumn1
            // 
            pendenciaDataGridViewTextBoxColumn1.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.HeaderText = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.Name = "pendenciaDataGridViewTextBoxColumn1";
            pendenciaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CSIOriginal
            // 
            CSIOriginal.DataPropertyName = "CSIOriginal";
            CSIOriginal.HeaderText = "CSIOriginal";
            CSIOriginal.Name = "CSIOriginal";
            CSIOriginal.ReadOnly = true;
            // 
            // lIDataGridViewTextBoxColumn1
            // 
            lIDataGridViewTextBoxColumn1.DataPropertyName = "LI";
            lIDataGridViewTextBoxColumn1.HeaderText = "LI";
            lIDataGridViewTextBoxColumn1.Name = "lIDataGridViewTextBoxColumn1";
            lIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lPCODataGridViewTextBoxColumn1
            // 
            lPCODataGridViewTextBoxColumn1.DataPropertyName = "LPCO";
            lPCODataGridViewTextBoxColumn1.HeaderText = "LPCO";
            lPCODataGridViewTextBoxColumn1.Name = "lPCODataGridViewTextBoxColumn1";
            lPCODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDeEntradaDataGridViewTextBoxColumn1
            // 
            dataDeEntradaDataGridViewTextBoxColumn1.DataPropertyName = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn1.HeaderText = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn1.Name = "dataDeEntradaDataGridViewTextBoxColumn1";
            dataDeEntradaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // parametrizacaoDataGridViewTextBoxColumn1
            // 
            parametrizacaoDataGridViewTextBoxColumn1.DataPropertyName = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn1.HeaderText = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn1.Name = "parametrizacaoDataGridViewTextBoxColumn1";
            parametrizacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sEIDataGridViewTextBoxColumn1
            // 
            sEIDataGridViewTextBoxColumn1.DataPropertyName = "SEI";
            sEIDataGridViewTextBoxColumn1.HeaderText = "SEI";
            sEIDataGridViewTextBoxColumn1.Name = "sEIDataGridViewTextBoxColumn1";
            sEIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDeInspeçãoDataGridViewTextBoxColumn1
            // 
            dataDeInspeçãoDataGridViewTextBoxColumn1.DataPropertyName = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn1.HeaderText = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn1.Name = "dataDeInspeçãoDataGridViewTextBoxColumn1";
            dataDeInspeçãoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDoProcessoDataGridViewTextBoxColumn1
            // 
            statusDoProcessoDataGridViewTextBoxColumn1.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn1.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn1.Name = "statusDoProcessoDataGridViewTextBoxColumn1";
            statusDoProcessoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "frmMapa";
            Text = "Planilha MAPA";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmMapa_FormClosed;
            Load += frmMapa_Load;
            ((System.ComponentModel.ISupportInitialize)bsMAPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bsMAPA;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn navioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn armazemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn containerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anueteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn capaDataGridViewCheckBoxColumn;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnEditar;
        private ToolStripTextBox txtPesquisar;
        private ToolStripButton btnPesquisar;
        private ToolStripButton btnCancelar;
        private ToolStripComboBox CmbPesquisar;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cSIOriginalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametrizacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sEIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeInspeçãoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cSIOriginalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn parametrizacaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sEIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeInspeçãoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CSIOriginal;
    }
}