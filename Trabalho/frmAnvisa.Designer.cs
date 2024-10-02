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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnvisa));
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            previsaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terminalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pendenciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lPCODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeEntradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeInspeçãoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDoProcessoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsAnvisa = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            btnExcluir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnPesquisar = new ToolStripButton();
            txtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAnvisa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nRDataGridViewTextBoxColumn, sRDataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn, previsaoDataGridViewTextBoxColumn, terminalDataGridViewTextBoxColumn, pendenciaDataGridViewTextBoxColumn, lIDataGridViewTextBoxColumn, lPCODataGridViewTextBoxColumn, dataDeEntradaDataGridViewTextBoxColumn, dataDeInspeçãoDataGridViewTextBoxColumn, statusDoProcessoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsAnvisa;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(14, 55);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 529);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nRDataGridViewTextBoxColumn
            // 
            nRDataGridViewTextBoxColumn.DataPropertyName = "NR";
            nRDataGridViewTextBoxColumn.HeaderText = "NR";
            nRDataGridViewTextBoxColumn.MinimumWidth = 6;
            nRDataGridViewTextBoxColumn.Name = "nRDataGridViewTextBoxColumn";
            nRDataGridViewTextBoxColumn.ReadOnly = true;
            nRDataGridViewTextBoxColumn.Width = 125;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            sRDataGridViewTextBoxColumn.HeaderText = "SR";
            sRDataGridViewTextBoxColumn.MinimumWidth = 6;
            sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            sRDataGridViewTextBoxColumn.ReadOnly = true;
            sRDataGridViewTextBoxColumn.Width = 125;
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.MinimumWidth = 6;
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            importadorDataGridViewTextBoxColumn.ReadOnly = true;
            importadorDataGridViewTextBoxColumn.Width = 125;
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            previsaoDataGridViewTextBoxColumn.ReadOnly = true;
            previsaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            terminalDataGridViewTextBoxColumn.ReadOnly = true;
            terminalDataGridViewTextBoxColumn.Width = 125;
            // 
            // pendenciaDataGridViewTextBoxColumn
            // 
            pendenciaDataGridViewTextBoxColumn.DataPropertyName = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.HeaderText = "Pendencia";
            pendenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pendenciaDataGridViewTextBoxColumn.Name = "pendenciaDataGridViewTextBoxColumn";
            pendenciaDataGridViewTextBoxColumn.ReadOnly = true;
            pendenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // lIDataGridViewTextBoxColumn
            // 
            lIDataGridViewTextBoxColumn.DataPropertyName = "LI";
            lIDataGridViewTextBoxColumn.HeaderText = "LI";
            lIDataGridViewTextBoxColumn.MinimumWidth = 6;
            lIDataGridViewTextBoxColumn.Name = "lIDataGridViewTextBoxColumn";
            lIDataGridViewTextBoxColumn.ReadOnly = true;
            lIDataGridViewTextBoxColumn.Width = 125;
            // 
            // lPCODataGridViewTextBoxColumn
            // 
            lPCODataGridViewTextBoxColumn.DataPropertyName = "LPCO";
            lPCODataGridViewTextBoxColumn.HeaderText = "LPCO";
            lPCODataGridViewTextBoxColumn.MinimumWidth = 6;
            lPCODataGridViewTextBoxColumn.Name = "lPCODataGridViewTextBoxColumn";
            lPCODataGridViewTextBoxColumn.ReadOnly = true;
            lPCODataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeEntradaDataGridViewTextBoxColumn
            // 
            dataDeEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn.HeaderText = "DataDeEntrada";
            dataDeEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDeEntradaDataGridViewTextBoxColumn.Name = "dataDeEntradaDataGridViewTextBoxColumn";
            dataDeEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            dataDeEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeInspeçãoDataGridViewTextBoxColumn
            // 
            dataDeInspeçãoDataGridViewTextBoxColumn.DataPropertyName = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.HeaderText = "DataDeInspeção";
            dataDeInspeçãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDeInspeçãoDataGridViewTextBoxColumn.Name = "dataDeInspeçãoDataGridViewTextBoxColumn";
            dataDeInspeçãoDataGridViewTextBoxColumn.ReadOnly = true;
            dataDeInspeçãoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDoProcessoDataGridViewTextBoxColumn
            // 
            statusDoProcessoDataGridViewTextBoxColumn.DataPropertyName = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.HeaderText = "StatusDoProcesso";
            statusDoProcessoDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDoProcessoDataGridViewTextBoxColumn.Name = "statusDoProcessoDataGridViewTextBoxColumn";
            statusDoProcessoDataGridViewTextBoxColumn.ReadOnly = true;
            statusDoProcessoDataGridViewTextBoxColumn.Width = 125;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExcluir, btnEditar, btnCancelar, btnPesquisar, txtPesquisar, CmbPesquisar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(914, 51);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(11, 4, 0, 2);
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
            btnCancelar.Size = new Size(29, 45);
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
            btnPesquisar.Size = new Size(29, 45);
            btnPesquisar.Text = "toolStripButton1";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Alignment = ToolStripItemAlignment.Right;
            txtPesquisar.Margin = new Padding(0, 4, 3, 0);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(285, 47);
            // 
            // CmbPesquisar
            // 
            CmbPesquisar.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisar.AutoSize = false;
            CmbPesquisar.Items.AddRange(new object[] { "NR", "SR", "Importador", "Previsao", "Terminal", "Pendencia", "LI", "LPCO", "DataDeEntrada", "DataDeInspeção", "StatusDoProcesso" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(138, 28);
            // 
            // frmAnvisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAnvisa";
            Text = "frmAnvisa";
            WindowState = FormWindowState.Maximized;
            Load += frmAnvisa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAnvisa).EndInit();
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
        private ToolStripButton btnExcluir;
        private BindingSource bsAnvisa;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pendenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lPCODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeInspeçãoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDoProcessoDataGridViewTextBoxColumn;
    }
}