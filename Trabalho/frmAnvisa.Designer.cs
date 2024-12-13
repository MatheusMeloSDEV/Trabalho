namespace Trabalho
{
    partial class frmAnvisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnvisa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bsAnvisa = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnEditar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnPesquisar = new ToolStripButton();
            txtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            refUSADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exportadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            navioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terminalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            origemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tEmbarqueDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataDeAtracacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inspecaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataEmbarqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nCMDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataRegistroLPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeferimentoLPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametrizacaoLPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amostraDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pendenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsAnvisa).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bsAnvisa
            // 
            bsAnvisa.DataMember = "ListaAnvisa";
            bsAnvisa.DataSource = typeof(CLUSA.RepositorioAnvisa);
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEditar, btnCancelar, btnPesquisar, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(6, 0, 1, 0);
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
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
            // 
            // CmbPesquisar
            // 
            CmbPesquisar.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisar.AutoSize = false;
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "Pendencia", "LI", "LPCO", "DataDeEntrada", "DataDeInspeção", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, refUSADataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn, sRDataGridViewTextBoxColumn, exportadorDataGridViewTextBoxColumn, navioDataGridViewTextBoxColumn, terminalDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, origemDataGridViewTextBoxColumn, tEmbarqueDataGridViewCheckBoxColumn, dataDeAtracacaoDataGridViewTextBoxColumn, inspecaoDataGridViewTextBoxColumn, dataEmbarqueDataGridViewTextBoxColumn, nCMDataGridViewTextBoxColumn, lIDataGridViewTextBoxColumn, lPCODataGridViewTextBoxColumn, dataRegistroLPCODataGridViewTextBoxColumn, dataDeferimentoLPCODataGridViewTextBoxColumn, parametrizacaoLPCODataGridViewTextBoxColumn, amostraDataGridViewCheckBoxColumn, pendenciaDataGridViewTextBoxColumn, statusDoProcessoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsAnvisa;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // refUSADataGridViewTextBoxColumn
            // 
            refUSADataGridViewTextBoxColumn.DataPropertyName = "Ref_USA";
            refUSADataGridViewTextBoxColumn.HeaderText = "Ref USA";
            refUSADataGridViewTextBoxColumn.Name = "refUSADataGridViewTextBoxColumn";
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            // 
            // sRDataGridViewTextBoxColumn
            // 
            sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn.HeaderText = "SR";
            sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            // 
            // exportadorDataGridViewTextBoxColumn
            // 
            exportadorDataGridViewTextBoxColumn.DataPropertyName = "Exportador";
            exportadorDataGridViewTextBoxColumn.HeaderText = "Exportador";
            exportadorDataGridViewTextBoxColumn.Name = "exportadorDataGridViewTextBoxColumn";
            // 
            // navioDataGridViewTextBoxColumn
            // 
            navioDataGridViewTextBoxColumn.DataPropertyName = "Navio";
            navioDataGridViewTextBoxColumn.HeaderText = "Navio";
            navioDataGridViewTextBoxColumn.Name = "navioDataGridViewTextBoxColumn";
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // origemDataGridViewTextBoxColumn
            // 
            origemDataGridViewTextBoxColumn.DataPropertyName = "Origem";
            origemDataGridViewTextBoxColumn.HeaderText = "Origem";
            origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            // 
            // tEmbarqueDataGridViewCheckBoxColumn
            // 
            tEmbarqueDataGridViewCheckBoxColumn.DataPropertyName = "TEmbarque";
            tEmbarqueDataGridViewCheckBoxColumn.HeaderText = "TEmbarque";
            tEmbarqueDataGridViewCheckBoxColumn.Name = "tEmbarqueDataGridViewCheckBoxColumn";
            tEmbarqueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataDeAtracacaoDataGridViewTextBoxColumn
            // 
            dataDeAtracacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.HeaderText = "Data De Atracação";
            dataDeAtracacaoDataGridViewTextBoxColumn.Name = "dataDeAtracacaoDataGridViewTextBoxColumn";
            // 
            // inspecaoDataGridViewTextBoxColumn
            // 
            inspecaoDataGridViewTextBoxColumn.DataPropertyName = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.HeaderText = "Inspeção";
            inspecaoDataGridViewTextBoxColumn.Name = "inspecaoDataGridViewTextBoxColumn";
            // 
            // dataEmbarqueDataGridViewTextBoxColumn
            // 
            dataEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.HeaderText = "Data de Embarque";
            dataEmbarqueDataGridViewTextBoxColumn.Name = "dataEmbarqueDataGridViewTextBoxColumn";
            // 
            // nCMDataGridViewTextBoxColumn
            // 
            nCMDataGridViewTextBoxColumn.DataPropertyName = "NCM";
            nCMDataGridViewTextBoxColumn.HeaderText = "NCM";
            nCMDataGridViewTextBoxColumn.Name = "nCMDataGridViewTextBoxColumn";
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
            // dataRegistroLPCODataGridViewTextBoxColumn
            // 
            dataRegistroLPCODataGridViewTextBoxColumn.DataPropertyName = "DataRegistroLPCO";
            dataRegistroLPCODataGridViewTextBoxColumn.HeaderText = "Data de Registro LPCO";
            dataRegistroLPCODataGridViewTextBoxColumn.Name = "dataRegistroLPCODataGridViewTextBoxColumn";
            // 
            // dataDeferimentoLPCODataGridViewTextBoxColumn
            // 
            dataDeferimentoLPCODataGridViewTextBoxColumn.DataPropertyName = "DataDeferimentoLPCO";
            dataDeferimentoLPCODataGridViewTextBoxColumn.HeaderText = "Data de Deferimento LPCO";
            dataDeferimentoLPCODataGridViewTextBoxColumn.Name = "dataDeferimentoLPCODataGridViewTextBoxColumn";
            // 
            // parametrizacaoLPCODataGridViewTextBoxColumn
            // 
            parametrizacaoLPCODataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoLPCO";
            parametrizacaoLPCODataGridViewTextBoxColumn.HeaderText = "Parametrização LPCO";
            parametrizacaoLPCODataGridViewTextBoxColumn.Name = "parametrizacaoLPCODataGridViewTextBoxColumn";
            // 
            // amostraDataGridViewCheckBoxColumn
            // 
            amostraDataGridViewCheckBoxColumn.DataPropertyName = "Amostra";
            amostraDataGridViewCheckBoxColumn.HeaderText = "Amostra";
            amostraDataGridViewCheckBoxColumn.Name = "amostraDataGridViewCheckBoxColumn";
            // 
            // pendenciaDataGridViewTextBoxColumn
            // 
            pendenciaDataGridViewTextBoxColumn.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.HeaderText = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.Name = "pendenciaDataGridViewTextBoxColumn";
            // 
            // statusDoProcessoDataGridViewTextBoxColumn
            // 
            statusDoProcessoDataGridViewTextBoxColumn.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "Status Do Processo";
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            // 
            // frmAnvisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "frmAnvisa";
            Text = "frmAnvisa";
            WindowState = FormWindowState.Maximized;
            Load += frmAnvisa_Load;
            ((System.ComponentModel.ISupportInitialize)bsAnvisa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton btnEditar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnPesquisar;
        private ToolStripTextBox txtPesquisar;
        private ToolStripComboBox CmbPesquisar;
        private BindingSource bsAnvisa;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn lILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refUSADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exportadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn navioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tEmbarqueDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataDeAtracacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inspecaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataEmbarqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nCMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataRegistroLPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeferimentoLPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametrizacaoLPCODataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn amostraDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn;
    }
}