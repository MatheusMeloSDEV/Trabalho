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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            bsMAPA = new BindingSource(components);
            dataGridView1 = new DataGridView();
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
            toolStrip1 = new ToolStrip();
            btnExcluir = new ToolStripButton();
            btnExportar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnReload = new ToolStripButton();
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
            toolStripButton2 = new ToolStripButton();
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nRDataGridViewTextBoxColumn1, sRDataGridViewTextBoxColumn1, importadorDataGridViewTextBoxColumn1, previsaoDataGridViewTextBoxColumn1, terminalDataGridViewTextBoxColumn1, pendenciaDataGridViewTextBoxColumn1, CSIOriginal, lIDataGridViewTextBoxColumn1, lPCODataGridViewTextBoxColumn1, dataDeEntradaDataGridViewTextBoxColumn1, parametrizacaoDataGridViewTextBoxColumn1, sEIDataGridViewTextBoxColumn1, dataDeInspeçãoDataGridViewTextBoxColumn1, statusDoProcessoDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = bsMAPA;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 25;
            // 
            // nRDataGridViewTextBoxColumn1
            // 
            nRDataGridViewTextBoxColumn1.DataPropertyName = "NR";
            nRDataGridViewTextBoxColumn1.HeaderText = "NR";
            nRDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nRDataGridViewTextBoxColumn1.Name = "nRDataGridViewTextBoxColumn1";
            nRDataGridViewTextBoxColumn1.ReadOnly = true;
            nRDataGridViewTextBoxColumn1.Width = 50;
            // 
            // sRDataGridViewTextBoxColumn1
            // 
            sRDataGridViewTextBoxColumn1.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn1.HeaderText = "SR";
            sRDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sRDataGridViewTextBoxColumn1.Name = "sRDataGridViewTextBoxColumn1";
            sRDataGridViewTextBoxColumn1.ReadOnly = true;
            sRDataGridViewTextBoxColumn1.Width = 50;
            // 
            // importadorDataGridViewTextBoxColumn1
            // 
            importadorDataGridViewTextBoxColumn1.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn1.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            importadorDataGridViewTextBoxColumn1.Name = "importadorDataGridViewTextBoxColumn1";
            importadorDataGridViewTextBoxColumn1.ReadOnly = true;
            importadorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // previsaoDataGridViewTextBoxColumn1
            // 
            previsaoDataGridViewTextBoxColumn1.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn1.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            previsaoDataGridViewTextBoxColumn1.Name = "previsaoDataGridViewTextBoxColumn1";
            previsaoDataGridViewTextBoxColumn1.ReadOnly = true;
            previsaoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // terminalDataGridViewTextBoxColumn1
            // 
            terminalDataGridViewTextBoxColumn1.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn1.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn1.MinimumWidth = 6;
            terminalDataGridViewTextBoxColumn1.Name = "terminalDataGridViewTextBoxColumn1";
            terminalDataGridViewTextBoxColumn1.ReadOnly = true;
            terminalDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pendenciaDataGridViewTextBoxColumn1
            // 
            pendenciaDataGridViewTextBoxColumn1.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.HeaderText = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            pendenciaDataGridViewTextBoxColumn1.Name = "pendenciaDataGridViewTextBoxColumn1";
            pendenciaDataGridViewTextBoxColumn1.ReadOnly = true;
            pendenciaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // CSIOriginal
            // 
            CSIOriginal.DataPropertyName = "CSIOriginal";
            CSIOriginal.HeaderText = "CSIOriginal";
            CSIOriginal.MinimumWidth = 6;
            CSIOriginal.Name = "CSIOriginal";
            CSIOriginal.ReadOnly = true;
            CSIOriginal.Width = 125;
            // 
            // lIDataGridViewTextBoxColumn1
            // 
            lIDataGridViewTextBoxColumn1.DataPropertyName = "LI";
            lIDataGridViewTextBoxColumn1.HeaderText = "LI";
            lIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            lIDataGridViewTextBoxColumn1.Name = "lIDataGridViewTextBoxColumn1";
            lIDataGridViewTextBoxColumn1.ReadOnly = true;
            lIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lPCODataGridViewTextBoxColumn1
            // 
            lPCODataGridViewTextBoxColumn1.DataPropertyName = "LPCO";
            lPCODataGridViewTextBoxColumn1.HeaderText = "LPCO";
            lPCODataGridViewTextBoxColumn1.MinimumWidth = 6;
            lPCODataGridViewTextBoxColumn1.Name = "lPCODataGridViewTextBoxColumn1";
            lPCODataGridViewTextBoxColumn1.ReadOnly = true;
            lPCODataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataDeEntradaDataGridViewTextBoxColumn1
            // 
            dataDeEntradaDataGridViewTextBoxColumn1.DataPropertyName = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn1.HeaderText = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataDeEntradaDataGridViewTextBoxColumn1.Name = "dataDeEntradaDataGridViewTextBoxColumn1";
            dataDeEntradaDataGridViewTextBoxColumn1.ReadOnly = true;
            dataDeEntradaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // parametrizacaoDataGridViewTextBoxColumn1
            // 
            parametrizacaoDataGridViewTextBoxColumn1.DataPropertyName = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn1.HeaderText = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            parametrizacaoDataGridViewTextBoxColumn1.Name = "parametrizacaoDataGridViewTextBoxColumn1";
            parametrizacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            parametrizacaoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sEIDataGridViewTextBoxColumn1
            // 
            sEIDataGridViewTextBoxColumn1.DataPropertyName = "SEI";
            sEIDataGridViewTextBoxColumn1.HeaderText = "SEI";
            sEIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sEIDataGridViewTextBoxColumn1.Name = "sEIDataGridViewTextBoxColumn1";
            sEIDataGridViewTextBoxColumn1.ReadOnly = true;
            sEIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataDeInspeçãoDataGridViewTextBoxColumn1
            // 
            dataDeInspeçãoDataGridViewTextBoxColumn1.DataPropertyName = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn1.HeaderText = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataDeInspeçãoDataGridViewTextBoxColumn1.Name = "dataDeInspeçãoDataGridViewTextBoxColumn1";
            dataDeInspeçãoDataGridViewTextBoxColumn1.ReadOnly = true;
            dataDeInspeçãoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusDoProcessoDataGridViewTextBoxColumn1
            // 
            statusDoProcessoDataGridViewTextBoxColumn1.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn1.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            statusDoProcessoDataGridViewTextBoxColumn1.Name = "statusDoProcessoDataGridViewTextBoxColumn1";
            statusDoProcessoDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDoProcessoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExcluir, toolStripButton2, btnExportar, btnCancelar, toolStripButton1, btnReload, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(12, 4, 0, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(62, 32);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnExportar
            // 
            btnExportar.AutoSize = false;
            btnExportar.BackColor = Color.Yellow;
            btnExportar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExportar.Image = (Image)resources.GetObject("btnExportar.Image");
            btnExportar.ImageTransparentColor = Color.Magenta;
            btnExportar.Margin = new Padding(5, 4, 0, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(62, 32);
            btnExportar.Text = "Exportar";
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Alignment = ToolStripItemAlignment.Right;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.DisplayStyle = ToolStripItemDisplayStyle.None;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Margin = new Padding(0, 4, 11, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(23, 32);
            btnCancelar.Text = "toolStripButton2";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.BackgroundImage = (Image)resources.GetObject("toolStripButton1.BackgroundImage");
            toolStripButton1.BackgroundImageLayout = ImageLayout.Zoom;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Margin = new Padding(0, 4, 0, 2);
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 32);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // btnReload
            // 
            btnReload.Alignment = ToolStripItemAlignment.Right;
            btnReload.BackgroundImage = (Image)resources.GetObject("btnReload.BackgroundImage");
            btnReload.BackgroundImageLayout = ImageLayout.Zoom;
            btnReload.DisplayStyle = ToolStripItemDisplayStyle.None;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageTransparentColor = Color.Magenta;
            btnReload.Margin = new Padding(0, 4, 0, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(23, 32);
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
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
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "Pendencia", "CSIOriginal", "LI", "LPCO", "DataDeEntrada", "Prametrizacao", "SEI", "DataDeInspeção", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            CmbPesquisar.Click += CmbPesquisar_Click;
            // 
            // nRDataGridViewTextBoxColumn
            // 
            nRDataGridViewTextBoxColumn.DataPropertyName = "NR";
            nRDataGridViewTextBoxColumn.Frozen = true;
            nRDataGridViewTextBoxColumn.HeaderText = "NR";
            nRDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRDataGridViewTextBoxColumn.Name = "nRDataGridViewTextBoxColumn";
            nRDataGridViewTextBoxColumn.Width = 30;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn.Frozen = true;
            sRDataGridViewTextBoxColumn.HeaderText = "SR";
            sRDataGridViewTextBoxColumn.MinimumWidth = 6;
            sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            sRDataGridViewTextBoxColumn.Width = 30;
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.DividerWidth = 5;
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.MinimumWidth = 6;
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            importadorDataGridViewTextBoxColumn.Width = 125;
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            previsaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            terminalDataGridViewTextBoxColumn.Width = 125;
            // 
            // pendenciaDataGridViewTextBoxColumn
            // 
            pendenciaDataGridViewTextBoxColumn.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.HeaderText = "Pendência";
            pendenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pendenciaDataGridViewTextBoxColumn.Name = "pendenciaDataGridViewTextBoxColumn";
            pendenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cSIOriginalDataGridViewTextBoxColumn
            // 
            cSIOriginalDataGridViewTextBoxColumn.DataPropertyName = "CSI_Original";
            cSIOriginalDataGridViewTextBoxColumn.HeaderText = "CSI Original";
            cSIOriginalDataGridViewTextBoxColumn.MinimumWidth = 6;
            cSIOriginalDataGridViewTextBoxColumn.Name = "cSIOriginalDataGridViewTextBoxColumn";
            cSIOriginalDataGridViewTextBoxColumn.Width = 125;
            // 
            // lIDataGridViewTextBoxColumn
            // 
            lIDataGridViewTextBoxColumn.DataPropertyName = "LI";
            lIDataGridViewTextBoxColumn.HeaderText = "LI";
            lIDataGridViewTextBoxColumn.MinimumWidth = 6;
            lIDataGridViewTextBoxColumn.Name = "lIDataGridViewTextBoxColumn";
            lIDataGridViewTextBoxColumn.Width = 125;
            // 
            // lPCODataGridViewTextBoxColumn
            // 
            lPCODataGridViewTextBoxColumn.DataPropertyName = "LPCO";
            lPCODataGridViewTextBoxColumn.HeaderText = "LPCO";
            lPCODataGridViewTextBoxColumn.MinimumWidth = 6;
            lPCODataGridViewTextBoxColumn.Name = "lPCODataGridViewTextBoxColumn";
            lPCODataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeEntradaDataGridViewTextBoxColumn
            // 
            dataDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            dataDeEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDeEntradaDataGridViewTextBoxColumn.Name = "dataDeEntradaDataGridViewTextBoxColumn";
            dataDeEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // parametrizacaoDataGridViewTextBoxColumn
            // 
            parametrizacaoDataGridViewTextBoxColumn.DataPropertyName = "Parametrizacao";
            parametrizacaoDataGridViewTextBoxColumn.HeaderText = "Parametrização";
            parametrizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            parametrizacaoDataGridViewTextBoxColumn.Name = "parametrizacaoDataGridViewTextBoxColumn";
            parametrizacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEIDataGridViewTextBoxColumn
            // 
            sEIDataGridViewTextBoxColumn.DataPropertyName = "SEI";
            sEIDataGridViewTextBoxColumn.HeaderText = "SEI";
            sEIDataGridViewTextBoxColumn.MinimumWidth = 6;
            sEIDataGridViewTextBoxColumn.Name = "sEIDataGridViewTextBoxColumn";
            sEIDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeInspeçãoDataGridViewTextBoxColumn
            // 
            dataDeInspeçãoDataGridViewTextBoxColumn.DataPropertyName = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.HeaderText = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDeInspeçãoDataGridViewTextBoxColumn.Name = "dataDeInspeçãoDataGridViewTextBoxColumn";
            dataDeInspeçãoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDoProcessoDataGridViewTextBoxColumn
            // 
            statusDoProcessoDataGridViewTextBoxColumn.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            statusDoProcessoDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.BackColor = Color.MediumTurquoise;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Margin = new Padding(5, 4, 0, 2);
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(62, 32);
            toolStripButton2.Text = "Editar";
            // 
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
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
        private ToolStripButton btnExcluir;
        private ToolStripButton btnExportar;
        private ToolStripTextBox txtPesquisar;
        private ToolStripButton btnReload;
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
        private DataGridViewTextBoxColumn cSIOriginalDataGridViewTextBoxColumn1;
        private ToolStripButton toolStripButton1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CSIOriginal;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn parametrizacaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sEIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeInspeçãoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn1;
        private ToolStripButton toolStripButton2;
    }
}