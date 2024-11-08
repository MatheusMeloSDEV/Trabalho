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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BSmapa = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            BTNeditar = new ToolStripButton();
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            refUSADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            exportadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            portoDestinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fLODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            freeTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agenteDeCargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lILPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataRegistroLILPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeferimentoLILPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametrizacaoLILPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataRegistroDIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDesembaracoDIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataCarregamentoDIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            parametrizacaoDIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            possuiEmbarqueDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataDeAtracacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inspecaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataEmbarqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            previsaoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            recebOriginaisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaRecebERecebidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amostraDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            desovadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pendenciaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)BSmapa).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BSmapa
            // 
            BSmapa.DataMember = "ListaMapa";
            BSmapa.DataSource = typeof(CLUSA.RepositorioMAPA);
            BSmapa.CurrentChanged += bsMAPA_CurrentChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BTNeditar, btnCancelar, toolStripButton1, btnReload, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // BTNeditar
            // 
            BTNeditar.AutoSize = false;
            BTNeditar.BackColor = Color.MediumTurquoise;
            BTNeditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BTNeditar.Image = (Image)resources.GetObject("BTNeditar.Image");
            BTNeditar.ImageTransparentColor = Color.Magenta;
            BTNeditar.Margin = new Padding(11, 4, 0, 2);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(62, 32);
            BTNeditar.Text = "Editar";
            BTNeditar.Click += BTNeditar_Click_1;
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
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "Pendencia", "CSIOriginal", "LI", "LPCO", "DataDeEntrada", "Prametrizacao", "SEI", "DataDeInspeção", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, refUSADataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn1, sRDataGridViewTextBoxColumn1, exportadorDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, portoDestinoDataGridViewTextBoxColumn, ordemDataGridViewTextBoxColumn, fLODataGridViewTextBoxColumn, freeTimeDataGridViewTextBoxColumn, bLDataGridViewTextBoxColumn, agenteDeCargaDataGridViewTextBoxColumn, lILPCODataGridViewTextBoxColumn, dataRegistroLILPCODataGridViewTextBoxColumn, dataDeferimentoLILPCODataGridViewTextBoxColumn, parametrizacaoLILPCODataGridViewTextBoxColumn, dIDataGridViewTextBoxColumn, dataRegistroDIDataGridViewTextBoxColumn, dataDesembaracoDIDataGridViewTextBoxColumn, dataCarregamentoDIDataGridViewTextBoxColumn, parametrizacaoDIDataGridViewTextBoxColumn, possuiEmbarqueDataGridViewCheckBoxColumn, dataDeAtracacaoDataGridViewTextBoxColumn, inspecaoDataGridViewTextBoxColumn, dataEmbarqueDataGridViewTextBoxColumn, previsaoDataGridViewTextBoxColumn1, recebOriginaisDataGridViewTextBoxColumn, formaRecebERecebidosDataGridViewTextBoxColumn, amostraDataGridViewCheckBoxColumn, desovadoDataGridViewCheckBoxColumn, pendenciaDataGridViewTextBoxColumn1, statusDoProcessoDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = BSmapa;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // refUSADataGridViewTextBoxColumn
            // 
            refUSADataGridViewTextBoxColumn.DataPropertyName = "Ref_USA";
            refUSADataGridViewTextBoxColumn.HeaderText = "Ref_USA";
            refUSADataGridViewTextBoxColumn.Name = "refUSADataGridViewTextBoxColumn";
            refUSADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importadorDataGridViewTextBoxColumn1
            // 
            importadorDataGridViewTextBoxColumn1.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn1.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn1.Name = "importadorDataGridViewTextBoxColumn1";
            importadorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sRDataGridViewTextBoxColumn1
            // 
            sRDataGridViewTextBoxColumn1.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn1.HeaderText = "SR";
            sRDataGridViewTextBoxColumn1.Name = "sRDataGridViewTextBoxColumn1";
            sRDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // exportadorDataGridViewTextBoxColumn
            // 
            exportadorDataGridViewTextBoxColumn.DataPropertyName = "Exportador";
            exportadorDataGridViewTextBoxColumn.HeaderText = "Exportador";
            exportadorDataGridViewTextBoxColumn.Name = "exportadorDataGridViewTextBoxColumn";
            exportadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portoDestinoDataGridViewTextBoxColumn
            // 
            portoDestinoDataGridViewTextBoxColumn.DataPropertyName = "PortoDestino";
            portoDestinoDataGridViewTextBoxColumn.HeaderText = "PortoDestino";
            portoDestinoDataGridViewTextBoxColumn.Name = "portoDestinoDataGridViewTextBoxColumn";
            portoDestinoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // freeTimeDataGridViewTextBoxColumn
            // 
            freeTimeDataGridViewTextBoxColumn.DataPropertyName = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.HeaderText = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.Name = "freeTimeDataGridViewTextBoxColumn";
            freeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLDataGridViewTextBoxColumn
            // 
            bLDataGridViewTextBoxColumn.DataPropertyName = "BL";
            bLDataGridViewTextBoxColumn.HeaderText = "BL";
            bLDataGridViewTextBoxColumn.Name = "bLDataGridViewTextBoxColumn";
            bLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agenteDeCargaDataGridViewTextBoxColumn
            // 
            agenteDeCargaDataGridViewTextBoxColumn.DataPropertyName = "AgenteDeCarga";
            agenteDeCargaDataGridViewTextBoxColumn.HeaderText = "AgenteDeCarga";
            agenteDeCargaDataGridViewTextBoxColumn.Name = "agenteDeCargaDataGridViewTextBoxColumn";
            agenteDeCargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lILPCODataGridViewTextBoxColumn
            // 
            lILPCODataGridViewTextBoxColumn.DataPropertyName = "LI_LPCO";
            lILPCODataGridViewTextBoxColumn.HeaderText = "LI_LPCO";
            lILPCODataGridViewTextBoxColumn.Name = "lILPCODataGridViewTextBoxColumn";
            lILPCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRegistroLILPCODataGridViewTextBoxColumn
            // 
            dataRegistroLILPCODataGridViewTextBoxColumn.DataPropertyName = "DataRegistroLILPCO";
            dataRegistroLILPCODataGridViewTextBoxColumn.HeaderText = "DataRegistroLILPCO";
            dataRegistroLILPCODataGridViewTextBoxColumn.Name = "dataRegistroLILPCODataGridViewTextBoxColumn";
            dataRegistroLILPCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeferimentoLILPCODataGridViewTextBoxColumn
            // 
            dataDeferimentoLILPCODataGridViewTextBoxColumn.DataPropertyName = "DataDeferimentoLILPCO";
            dataDeferimentoLILPCODataGridViewTextBoxColumn.HeaderText = "DataDeferimentoLILPCO";
            dataDeferimentoLILPCODataGridViewTextBoxColumn.Name = "dataDeferimentoLILPCODataGridViewTextBoxColumn";
            dataDeferimentoLILPCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parametrizacaoLILPCODataGridViewTextBoxColumn
            // 
            parametrizacaoLILPCODataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoLILPCO";
            parametrizacaoLILPCODataGridViewTextBoxColumn.HeaderText = "ParametrizacaoLILPCO";
            parametrizacaoLILPCODataGridViewTextBoxColumn.Name = "parametrizacaoLILPCODataGridViewTextBoxColumn";
            parametrizacaoLILPCODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIDataGridViewTextBoxColumn
            // 
            dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            dIDataGridViewTextBoxColumn.HeaderText = "DI";
            dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            dIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRegistroDIDataGridViewTextBoxColumn
            // 
            dataRegistroDIDataGridViewTextBoxColumn.DataPropertyName = "DataRegistroDI";
            dataRegistroDIDataGridViewTextBoxColumn.HeaderText = "DataRegistroDI";
            dataRegistroDIDataGridViewTextBoxColumn.Name = "dataRegistroDIDataGridViewTextBoxColumn";
            dataRegistroDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDesembaracoDIDataGridViewTextBoxColumn
            // 
            dataDesembaracoDIDataGridViewTextBoxColumn.DataPropertyName = "DataDesembaracoDI";
            dataDesembaracoDIDataGridViewTextBoxColumn.HeaderText = "DataDesembaracoDI";
            dataDesembaracoDIDataGridViewTextBoxColumn.Name = "dataDesembaracoDIDataGridViewTextBoxColumn";
            dataDesembaracoDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCarregamentoDIDataGridViewTextBoxColumn
            // 
            dataCarregamentoDIDataGridViewTextBoxColumn.DataPropertyName = "DataCarregamentoDI";
            dataCarregamentoDIDataGridViewTextBoxColumn.HeaderText = "DataCarregamentoDI";
            dataCarregamentoDIDataGridViewTextBoxColumn.Name = "dataCarregamentoDIDataGridViewTextBoxColumn";
            dataCarregamentoDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parametrizacaoDIDataGridViewTextBoxColumn
            // 
            parametrizacaoDIDataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoDI";
            parametrizacaoDIDataGridViewTextBoxColumn.HeaderText = "ParametrizacaoDI";
            parametrizacaoDIDataGridViewTextBoxColumn.Name = "parametrizacaoDIDataGridViewTextBoxColumn";
            parametrizacaoDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // possuiEmbarqueDataGridViewCheckBoxColumn
            // 
            possuiEmbarqueDataGridViewCheckBoxColumn.DataPropertyName = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.HeaderText = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.Name = "possuiEmbarqueDataGridViewCheckBoxColumn";
            possuiEmbarqueDataGridViewCheckBoxColumn.ReadOnly = true;
            possuiEmbarqueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataDeAtracacaoDataGridViewTextBoxColumn
            // 
            dataDeAtracacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.HeaderText = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.Name = "dataDeAtracacaoDataGridViewTextBoxColumn";
            dataDeAtracacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspecaoDataGridViewTextBoxColumn
            // 
            inspecaoDataGridViewTextBoxColumn.DataPropertyName = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.HeaderText = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.Name = "inspecaoDataGridViewTextBoxColumn";
            inspecaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEmbarqueDataGridViewTextBoxColumn
            // 
            dataEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.HeaderText = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.Name = "dataEmbarqueDataGridViewTextBoxColumn";
            dataEmbarqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previsaoDataGridViewTextBoxColumn1
            // 
            previsaoDataGridViewTextBoxColumn1.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn1.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn1.Name = "previsaoDataGridViewTextBoxColumn1";
            previsaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // recebOriginaisDataGridViewTextBoxColumn
            // 
            recebOriginaisDataGridViewTextBoxColumn.DataPropertyName = "RecebOriginais";
            recebOriginaisDataGridViewTextBoxColumn.HeaderText = "RecebOriginais";
            recebOriginaisDataGridViewTextBoxColumn.Name = "recebOriginaisDataGridViewTextBoxColumn";
            recebOriginaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaRecebERecebidosDataGridViewTextBoxColumn
            // 
            formaRecebERecebidosDataGridViewTextBoxColumn.DataPropertyName = "FormaRecebERecebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.HeaderText = "FormaRecebERecebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.Name = "formaRecebERecebidosDataGridViewTextBoxColumn";
            formaRecebERecebidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amostraDataGridViewCheckBoxColumn
            // 
            amostraDataGridViewCheckBoxColumn.DataPropertyName = "Amostra";
            amostraDataGridViewCheckBoxColumn.HeaderText = "Amostra";
            amostraDataGridViewCheckBoxColumn.Name = "amostraDataGridViewCheckBoxColumn";
            amostraDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // desovadoDataGridViewCheckBoxColumn
            // 
            desovadoDataGridViewCheckBoxColumn.DataPropertyName = "Desovado";
            desovadoDataGridViewCheckBoxColumn.HeaderText = "Desovado";
            desovadoDataGridViewCheckBoxColumn.Name = "desovadoDataGridViewCheckBoxColumn";
            desovadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pendenciaDataGridViewTextBoxColumn1
            // 
            pendenciaDataGridViewTextBoxColumn1.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.HeaderText = "Pendencia";
            pendenciaDataGridViewTextBoxColumn1.Name = "pendenciaDataGridViewTextBoxColumn1";
            pendenciaDataGridViewTextBoxColumn1.ReadOnly = true;
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
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMapa";
            Text = "Planilha MAPA";
            WindowState = FormWindowState.Maximized;
            Load += frmMapa_Load;
            ((System.ComponentModel.ISupportInitialize)BSmapa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource BSmapa;
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
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn1;
        private ToolStripButton BTNeditar;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cSIOriginalDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn parametrizacaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sEIDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataDeInspeçãoDataGridViewTextBoxColumn1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refUSADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn exportadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn portoDestinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fLODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freeTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agenteDeCargaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataRegistroLILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeferimentoLILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametrizacaoLILPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataRegistroDIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDesembaracoDIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCarregamentoDIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parametrizacaoDIDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn possuiEmbarqueDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dataDeAtracacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inspecaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataEmbarqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn recebOriginaisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaRecebERecebidosDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn amostraDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn desovadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn1;
    }
}