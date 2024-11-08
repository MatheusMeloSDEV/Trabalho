namespace Trabalho
{
    partial class frmDecex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecex));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bsDecex = new BindingSource(components);
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
            previsaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recebOriginaisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaRecebERecebidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amostraDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            desovadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            pendenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsDecex).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bsDecex
            // 
            bsDecex.DataMember = "ListaDecex";
            bsDecex.DataSource = typeof(CLUSA.RepositorioDecex);
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEditar, btnCancelar, btnPesquisar, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(6, 0, 1, 0);
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 9;
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
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "Pendencia", "LI", "DataDeEntrada", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            CmbPesquisar.Click += CmbPesquisar_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, refUSADataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn, sRDataGridViewTextBoxColumn, exportadorDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn, portoDestinoDataGridViewTextBoxColumn, ordemDataGridViewTextBoxColumn, fLODataGridViewTextBoxColumn, freeTimeDataGridViewTextBoxColumn, bLDataGridViewTextBoxColumn, agenteDeCargaDataGridViewTextBoxColumn, lILPCODataGridViewTextBoxColumn, dataRegistroLILPCODataGridViewTextBoxColumn, dataDeferimentoLILPCODataGridViewTextBoxColumn, parametrizacaoLILPCODataGridViewTextBoxColumn, dIDataGridViewTextBoxColumn, dataRegistroDIDataGridViewTextBoxColumn, dataDesembaracoDIDataGridViewTextBoxColumn, dataCarregamentoDIDataGridViewTextBoxColumn, parametrizacaoDIDataGridViewTextBoxColumn, possuiEmbarqueDataGridViewCheckBoxColumn, dataDeAtracacaoDataGridViewTextBoxColumn, inspecaoDataGridViewTextBoxColumn, dataEmbarqueDataGridViewTextBoxColumn, previsaoDataGridViewTextBoxColumn, recebOriginaisDataGridViewTextBoxColumn, formaRecebERecebidosDataGridViewTextBoxColumn, amostraDataGridViewCheckBoxColumn, desovadoDataGridViewCheckBoxColumn, pendenciaDataGridViewTextBoxColumn, statusDoProcessoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsDecex;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 10;
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
            refUSADataGridViewTextBoxColumn.HeaderText = "Ref_USA";
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
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // portoDestinoDataGridViewTextBoxColumn
            // 
            portoDestinoDataGridViewTextBoxColumn.DataPropertyName = "PortoDestino";
            portoDestinoDataGridViewTextBoxColumn.HeaderText = "PortoDestino";
            portoDestinoDataGridViewTextBoxColumn.Name = "portoDestinoDataGridViewTextBoxColumn";
            // 
            // ordemDataGridViewTextBoxColumn
            // 
            ordemDataGridViewTextBoxColumn.DataPropertyName = "Ordem";
            ordemDataGridViewTextBoxColumn.HeaderText = "Ordem";
            ordemDataGridViewTextBoxColumn.Name = "ordemDataGridViewTextBoxColumn";
            // 
            // fLODataGridViewTextBoxColumn
            // 
            fLODataGridViewTextBoxColumn.DataPropertyName = "FLO";
            fLODataGridViewTextBoxColumn.HeaderText = "FLO";
            fLODataGridViewTextBoxColumn.Name = "fLODataGridViewTextBoxColumn";
            // 
            // freeTimeDataGridViewTextBoxColumn
            // 
            freeTimeDataGridViewTextBoxColumn.DataPropertyName = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.HeaderText = "FreeTime";
            freeTimeDataGridViewTextBoxColumn.Name = "freeTimeDataGridViewTextBoxColumn";
            // 
            // bLDataGridViewTextBoxColumn
            // 
            bLDataGridViewTextBoxColumn.DataPropertyName = "BL";
            bLDataGridViewTextBoxColumn.HeaderText = "BL";
            bLDataGridViewTextBoxColumn.Name = "bLDataGridViewTextBoxColumn";
            // 
            // agenteDeCargaDataGridViewTextBoxColumn
            // 
            agenteDeCargaDataGridViewTextBoxColumn.DataPropertyName = "AgenteDeCarga";
            agenteDeCargaDataGridViewTextBoxColumn.HeaderText = "AgenteDeCarga";
            agenteDeCargaDataGridViewTextBoxColumn.Name = "agenteDeCargaDataGridViewTextBoxColumn";
            // 
            // lILPCODataGridViewTextBoxColumn
            // 
            lILPCODataGridViewTextBoxColumn.DataPropertyName = "LI_LPCO";
            lILPCODataGridViewTextBoxColumn.HeaderText = "LI_LPCO";
            lILPCODataGridViewTextBoxColumn.Name = "lILPCODataGridViewTextBoxColumn";
            // 
            // dataRegistroLILPCODataGridViewTextBoxColumn
            // 
            dataRegistroLILPCODataGridViewTextBoxColumn.DataPropertyName = "DataRegistroLILPCO";
            dataRegistroLILPCODataGridViewTextBoxColumn.HeaderText = "DataRegistroLILPCO";
            dataRegistroLILPCODataGridViewTextBoxColumn.Name = "dataRegistroLILPCODataGridViewTextBoxColumn";
            // 
            // dataDeferimentoLILPCODataGridViewTextBoxColumn
            // 
            dataDeferimentoLILPCODataGridViewTextBoxColumn.DataPropertyName = "DataDeferimentoLILPCO";
            dataDeferimentoLILPCODataGridViewTextBoxColumn.HeaderText = "DataDeferimentoLILPCO";
            dataDeferimentoLILPCODataGridViewTextBoxColumn.Name = "dataDeferimentoLILPCODataGridViewTextBoxColumn";
            // 
            // parametrizacaoLILPCODataGridViewTextBoxColumn
            // 
            parametrizacaoLILPCODataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoLILPCO";
            parametrizacaoLILPCODataGridViewTextBoxColumn.HeaderText = "ParametrizacaoLILPCO";
            parametrizacaoLILPCODataGridViewTextBoxColumn.Name = "parametrizacaoLILPCODataGridViewTextBoxColumn";
            // 
            // dIDataGridViewTextBoxColumn
            // 
            dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            dIDataGridViewTextBoxColumn.HeaderText = "DI";
            dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            // 
            // dataRegistroDIDataGridViewTextBoxColumn
            // 
            dataRegistroDIDataGridViewTextBoxColumn.DataPropertyName = "DataRegistroDI";
            dataRegistroDIDataGridViewTextBoxColumn.HeaderText = "DataRegistroDI";
            dataRegistroDIDataGridViewTextBoxColumn.Name = "dataRegistroDIDataGridViewTextBoxColumn";
            // 
            // dataDesembaracoDIDataGridViewTextBoxColumn
            // 
            dataDesembaracoDIDataGridViewTextBoxColumn.DataPropertyName = "DataDesembaracoDI";
            dataDesembaracoDIDataGridViewTextBoxColumn.HeaderText = "DataDesembaracoDI";
            dataDesembaracoDIDataGridViewTextBoxColumn.Name = "dataDesembaracoDIDataGridViewTextBoxColumn";
            // 
            // dataCarregamentoDIDataGridViewTextBoxColumn
            // 
            dataCarregamentoDIDataGridViewTextBoxColumn.DataPropertyName = "DataCarregamentoDI";
            dataCarregamentoDIDataGridViewTextBoxColumn.HeaderText = "DataCarregamentoDI";
            dataCarregamentoDIDataGridViewTextBoxColumn.Name = "dataCarregamentoDIDataGridViewTextBoxColumn";
            // 
            // parametrizacaoDIDataGridViewTextBoxColumn
            // 
            parametrizacaoDIDataGridViewTextBoxColumn.DataPropertyName = "ParametrizacaoDI";
            parametrizacaoDIDataGridViewTextBoxColumn.HeaderText = "ParametrizacaoDI";
            parametrizacaoDIDataGridViewTextBoxColumn.Name = "parametrizacaoDIDataGridViewTextBoxColumn";
            // 
            // possuiEmbarqueDataGridViewCheckBoxColumn
            // 
            possuiEmbarqueDataGridViewCheckBoxColumn.DataPropertyName = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.HeaderText = "PossuiEmbarque";
            possuiEmbarqueDataGridViewCheckBoxColumn.Name = "possuiEmbarqueDataGridViewCheckBoxColumn";
            possuiEmbarqueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataDeAtracacaoDataGridViewTextBoxColumn
            // 
            dataDeAtracacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.HeaderText = "DataDeAtracacao";
            dataDeAtracacaoDataGridViewTextBoxColumn.Name = "dataDeAtracacaoDataGridViewTextBoxColumn";
            // 
            // inspecaoDataGridViewTextBoxColumn
            // 
            inspecaoDataGridViewTextBoxColumn.DataPropertyName = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.HeaderText = "Inspecao";
            inspecaoDataGridViewTextBoxColumn.Name = "inspecaoDataGridViewTextBoxColumn";
            // 
            // dataEmbarqueDataGridViewTextBoxColumn
            // 
            dataEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.HeaderText = "DataEmbarque";
            dataEmbarqueDataGridViewTextBoxColumn.Name = "dataEmbarqueDataGridViewTextBoxColumn";
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            // 
            // recebOriginaisDataGridViewTextBoxColumn
            // 
            recebOriginaisDataGridViewTextBoxColumn.DataPropertyName = "RecebOriginais";
            recebOriginaisDataGridViewTextBoxColumn.HeaderText = "RecebOriginais";
            recebOriginaisDataGridViewTextBoxColumn.Name = "recebOriginaisDataGridViewTextBoxColumn";
            // 
            // formaRecebERecebidosDataGridViewTextBoxColumn
            // 
            formaRecebERecebidosDataGridViewTextBoxColumn.DataPropertyName = "FormaRecebERecebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.HeaderText = "FormaRecebERecebidos";
            formaRecebERecebidosDataGridViewTextBoxColumn.Name = "formaRecebERecebidosDataGridViewTextBoxColumn";
            // 
            // amostraDataGridViewCheckBoxColumn
            // 
            amostraDataGridViewCheckBoxColumn.DataPropertyName = "Amostra";
            amostraDataGridViewCheckBoxColumn.HeaderText = "Amostra";
            amostraDataGridViewCheckBoxColumn.Name = "amostraDataGridViewCheckBoxColumn";
            // 
            // desovadoDataGridViewCheckBoxColumn
            // 
            desovadoDataGridViewCheckBoxColumn.DataPropertyName = "Desovado";
            desovadoDataGridViewCheckBoxColumn.HeaderText = "Desovado";
            desovadoDataGridViewCheckBoxColumn.Name = "desovadoDataGridViewCheckBoxColumn";
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
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            // 
            // frmDecex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "frmDecex";
            Text = "frmDecex";
            WindowState = FormWindowState.Maximized;
            Load += frmDecex_Load;
            ((System.ComponentModel.ISupportInitialize)bsDecex).EndInit();
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
        private BindingSource bsDecex;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refUSADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recebOriginaisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaRecebERecebidosDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn amostraDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn desovadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn;
    }
}