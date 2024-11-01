namespace Trabalho
{
    partial class frmProcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesso));
            dataGridView1 = new DataGridView();
            bsProcesso = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnPesquisar = new ToolStripButton();
            txtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tDecexDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            tAnvisaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            tMapaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            tImetroDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            tIbamaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            refUSADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exportadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fLODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            portoDestinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agenteDeCargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            possuiEmbarqueDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataEmbarqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lILPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            freeTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeAtracacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recebOriginaisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaRecebERecebidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inspecaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            desovadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            amostraDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametrizacaoDIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProcesso).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tDecexDataGridViewCheckBoxColumn, tAnvisaDataGridViewCheckBoxColumn, tMapaDataGridViewCheckBoxColumn, tImetroDataGridViewCheckBoxColumn, tIbamaDataGridViewCheckBoxColumn, refUSADataGridViewTextBoxColumn, exportadorDataGridViewTextBoxColumn, ordemDataGridViewTextBoxColumn, fLODataGridViewTextBoxColumn, portoDestinoDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, agenteDeCargaDataGridViewTextBoxColumn, possuiEmbarqueDataGridViewCheckBoxColumn, dataEmbarqueDataGridViewTextBoxColumn, bLDataGridViewTextBoxColumn, lILPCODataGridViewTextBoxColumn, freeTimeDataGridViewTextBoxColumn, dataDeAtracacaoDataGridViewTextBoxColumn, recebOriginaisDataGridViewTextBoxColumn, formaRecebERecebidosDataGridViewTextBoxColumn, inspecaoDataGridViewTextBoxColumn, desovadoDataGridViewCheckBoxColumn, amostraDataGridViewCheckBoxColumn, dIDataGridViewTextBoxColumn, parametrizacaoDIDataGridViewTextBoxColumn, statusDoProcessoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsProcesso;
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
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // bsProcesso
            // 
            bsProcesso.DataMember = "ListaProcesso";
            bsProcesso.DataSource = typeof(CLUSA.RepositorioProcesso);
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
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.GreenYellow;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Margin = new Padding(11, 4, 0, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(62, 32);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Alignment = ToolStripItemAlignment.Right;
            txtPesquisar.Margin = new Padding(0, 4, 3, 0);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(250, 34);
            txtPesquisar.Click += txtPesquisar_Click;
            // 
            // CmbPesquisar
            // 
            CmbPesquisar.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisar.AutoSize = false;
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            CmbPesquisar.Click += CmbPesquisar_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tDecexDataGridViewCheckBoxColumn
            // 
            tDecexDataGridViewCheckBoxColumn.DataPropertyName = "TDecex";
            tDecexDataGridViewCheckBoxColumn.HeaderText = "TDecex";
            tDecexDataGridViewCheckBoxColumn.Name = "tDecexDataGridViewCheckBoxColumn";
            tDecexDataGridViewCheckBoxColumn.ReadOnly = true;
            tDecexDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tAnvisaDataGridViewCheckBoxColumn
            // 
            tAnvisaDataGridViewCheckBoxColumn.DataPropertyName = "TAnvisa";
            tAnvisaDataGridViewCheckBoxColumn.HeaderText = "TAnvisa";
            tAnvisaDataGridViewCheckBoxColumn.Name = "tAnvisaDataGridViewCheckBoxColumn";
            tAnvisaDataGridViewCheckBoxColumn.ReadOnly = true;
            tAnvisaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tMapaDataGridViewCheckBoxColumn
            // 
            tMapaDataGridViewCheckBoxColumn.DataPropertyName = "TMapa";
            tMapaDataGridViewCheckBoxColumn.HeaderText = "TMapa";
            tMapaDataGridViewCheckBoxColumn.Name = "tMapaDataGridViewCheckBoxColumn";
            tMapaDataGridViewCheckBoxColumn.ReadOnly = true;
            tMapaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tImetroDataGridViewCheckBoxColumn
            // 
            tImetroDataGridViewCheckBoxColumn.DataPropertyName = "TImetro";
            tImetroDataGridViewCheckBoxColumn.HeaderText = "TImetro";
            tImetroDataGridViewCheckBoxColumn.Name = "tImetroDataGridViewCheckBoxColumn";
            tImetroDataGridViewCheckBoxColumn.ReadOnly = true;
            tImetroDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tIbamaDataGridViewCheckBoxColumn
            // 
            tIbamaDataGridViewCheckBoxColumn.DataPropertyName = "TIbama";
            tIbamaDataGridViewCheckBoxColumn.HeaderText = "TIbama";
            tIbamaDataGridViewCheckBoxColumn.Name = "tIbamaDataGridViewCheckBoxColumn";
            tIbamaDataGridViewCheckBoxColumn.ReadOnly = true;
            tIbamaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // refUSADataGridViewTextBoxColumn
            // 
            refUSADataGridViewTextBoxColumn.DataPropertyName = "Ref_USA";
            refUSADataGridViewTextBoxColumn.HeaderText = "Ref USA";
            refUSADataGridViewTextBoxColumn.Name = "refUSADataGridViewTextBoxColumn";
            refUSADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exportadorDataGridViewTextBoxColumn
            // 
            exportadorDataGridViewTextBoxColumn.DataPropertyName = "Exportador";
            exportadorDataGridViewTextBoxColumn.HeaderText = "Exportador";
            exportadorDataGridViewTextBoxColumn.Name = "exportadorDataGridViewTextBoxColumn";
            exportadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordemDataGridViewTextBoxColumn
            // 
            ordemDataGridViewTextBoxColumn.DataPropertyName = "Ordem";
            ordemDataGridViewTextBoxColumn.HeaderText = "Ordem";
            ordemDataGridViewTextBoxColumn.Name = "ordemDataGridViewTextBoxColumn";
            ordemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fLODataGridViewTextBoxColumn
            // 
            fLODataGridViewTextBoxColumn.DataPropertyName = "FLO";
            fLODataGridViewTextBoxColumn.HeaderText = "FLO";
            fLODataGridViewTextBoxColumn.Name = "fLODataGridViewTextBoxColumn";
            fLODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portoDestinoDataGridViewTextBoxColumn
            // 
            portoDestinoDataGridViewTextBoxColumn.DataPropertyName = "PortoDestino";
            portoDestinoDataGridViewTextBoxColumn.HeaderText = "Porto de Destino";
            portoDestinoDataGridViewTextBoxColumn.Name = "portoDestinoDataGridViewTextBoxColumn";
            portoDestinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agenteDeCargaDataGridViewTextBoxColumn
            // 
            agenteDeCargaDataGridViewTextBoxColumn.DataPropertyName = "AgenteDeCarga";
            agenteDeCargaDataGridViewTextBoxColumn.HeaderText = "Agente De Carga";
            agenteDeCargaDataGridViewTextBoxColumn.Name = "agenteDeCargaDataGridViewTextBoxColumn";
            agenteDeCargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // possuiEmbarqueDataGridViewCheckBoxColumn
            // 
            possuiEmbarqueDataGridViewCheckBoxColumn.DataPropertyName = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.HeaderText = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.Name = "possuiEmbarqueDataGridViewCheckBoxColumn";
            possuiEmbarqueDataGridViewCheckBoxColumn.ReadOnly = true;
            possuiEmbarqueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataEmbarqueDataGridViewTextBoxColumn
            // 
            dataEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.HeaderText = "Data Embarque";
            dataEmbarqueDataGridViewTextBoxColumn.Name = "dataEmbarqueDataGridViewTextBoxColumn";
            dataEmbarqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLDataGridViewTextBoxColumn
            // 
            bLDataGridViewTextBoxColumn.DataPropertyName = "BL";
            bLDataGridViewTextBoxColumn.HeaderText = "BL";
            bLDataGridViewTextBoxColumn.Name = "bLDataGridViewTextBoxColumn";
            bLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lILPCODataGridViewTextBoxColumn
            // 
            lILPCODataGridViewTextBoxColumn.DataPropertyName = "LI_LPCO";
            lILPCODataGridViewTextBoxColumn.HeaderText = "LI/LPCO";
            lILPCODataGridViewTextBoxColumn.Name = "lILPCODataGridViewTextBoxColumn";
            lILPCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeTimeDataGridViewTextBoxColumn
            // 
            freeTimeDataGridViewTextBoxColumn.DataPropertyName = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.HeaderText = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.Name = "freeTimeDataGridViewTextBoxColumn";
            freeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeAtracacaoDataGridViewTextBoxColumn
            // 
            dataDeAtracacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.HeaderText = "Data De Atracação";
            dataDeAtracacaoDataGridViewTextBoxColumn.Name = "dataDeAtracacaoDataGridViewTextBoxColumn";
            dataDeAtracacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recebOriginaisDataGridViewTextBoxColumn
            // 
            recebOriginaisDataGridViewTextBoxColumn.DataPropertyName = "RecebOriginais";
            recebOriginaisDataGridViewTextBoxColumn.HeaderText = "Recebimento docs Originais";
            recebOriginaisDataGridViewTextBoxColumn.Name = "recebOriginaisDataGridViewTextBoxColumn";
            recebOriginaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaRecebERecebidosDataGridViewTextBoxColumn
            // 
            formaRecebERecebidosDataGridViewTextBoxColumn.DataPropertyName = "FormaRecebERecebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.HeaderText = "Forma de Recebimento E Documentos Recebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.Name = "formaRecebERecebidosDataGridViewTextBoxColumn";
            formaRecebERecebidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspecaoDataGridViewTextBoxColumn
            // 
            inspecaoDataGridViewTextBoxColumn.DataPropertyName = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.HeaderText = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.Name = "inspecaoDataGridViewTextBoxColumn";
            inspecaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desovadoDataGridViewCheckBoxColumn
            // 
            desovadoDataGridViewCheckBoxColumn.DataPropertyName = "Desovado";
            desovadoDataGridViewCheckBoxColumn.HeaderText = "Desovado";
            desovadoDataGridViewCheckBoxColumn.Name = "desovadoDataGridViewCheckBoxColumn";
            desovadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // amostraDataGridViewCheckBoxColumn
            // 
            amostraDataGridViewCheckBoxColumn.DataPropertyName = "Amostra";
            amostraDataGridViewCheckBoxColumn.HeaderText = "Amostra";
            amostraDataGridViewCheckBoxColumn.Name = "amostraDataGridViewCheckBoxColumn";
            amostraDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dIDataGridViewTextBoxColumn
            // 
            dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            dIDataGridViewTextBoxColumn.HeaderText = "DI";
            dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            dIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parametrizacaoDIDataGridViewTextBoxColumn
            // 
            parametrizacaoDIDataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoDI";
            parametrizacaoDIDataGridViewTextBoxColumn.HeaderText = "Parametrização";
            parametrizacaoDIDataGridViewTextBoxColumn.Name = "parametrizacaoDIDataGridViewTextBoxColumn";
            parametrizacaoDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDoProcessoDataGridViewTextBoxColumn
            // 
            statusDoProcessoDataGridViewTextBoxColumn.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            statusDoProcessoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "frmProcesso";
            Text = "frmProcesso";
            WindowState = FormWindowState.Maximized;
            Load += frmProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProcesso).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnEditar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnPesquisar;
        private ToolStripTextBox txtPesquisar;
        private ToolStripComboBox CmbPesquisar;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnExcluir;
        private BindingSource bsProcesso;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Previsao;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tDecexDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn tAnvisaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn tMapaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn tImetroDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn tIbamaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn refUSADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exportadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fLODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn portoDestinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agenteDeCargaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn possuiEmbarqueDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataEmbarqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freeTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeAtracacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recebOriginaisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaRecebERecebidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inspecaoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn desovadoDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn amostraDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametrizacaoDIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn;
    }
}