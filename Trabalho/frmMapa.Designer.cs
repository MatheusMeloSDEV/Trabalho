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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            bsMAPA = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sRDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            navioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            previsaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            terminalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            armazemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            containerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anueteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnPesquisar = new ToolStripButton();
            txtPesquisar = new ToolStripTextBox();
            CmbPesquisar = new ToolStripComboBox();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nRDataGridViewTextBoxColumn, sRDataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn, navioDataGridViewTextBoxColumn, previsaoDataGridViewTextBoxColumn, terminalDataGridViewTextBoxColumn, armazemDataGridViewTextBoxColumn, containerDataGridViewTextBoxColumn, anueteDataGridViewTextBoxColumn, cEDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, capaDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bsMAPA;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 397);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nRDataGridViewTextBoxColumn
            // 
            nRDataGridViewTextBoxColumn.DataPropertyName = "NR";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nRDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nRDataGridViewTextBoxColumn.HeaderText = "N/Ref";
            nRDataGridViewTextBoxColumn.Name = "nRDataGridViewTextBoxColumn";
            nRDataGridViewTextBoxColumn.ReadOnly = true;
            nRDataGridViewTextBoxColumn.Width = 50;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            sRDataGridViewTextBoxColumn.DataPropertyName = "SR";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sRDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            sRDataGridViewTextBoxColumn.HeaderText = "S/Ref";
            sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            sRDataGridViewTextBoxColumn.ReadOnly = true;
            sRDataGridViewTextBoxColumn.Width = 50;
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.MinimumWidth = 60;
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            importadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navioDataGridViewTextBoxColumn
            // 
            navioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            navioDataGridViewTextBoxColumn.DataPropertyName = "Navio";
            navioDataGridViewTextBoxColumn.HeaderText = "Navio";
            navioDataGridViewTextBoxColumn.MinimumWidth = 60;
            navioDataGridViewTextBoxColumn.Name = "navioDataGridViewTextBoxColumn";
            navioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.MinimumWidth = 60;
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            previsaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.MinimumWidth = 60;
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            terminalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // armazemDataGridViewTextBoxColumn
            // 
            armazemDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            armazemDataGridViewTextBoxColumn.DataPropertyName = "Armazem";
            armazemDataGridViewTextBoxColumn.HeaderText = "Armazem";
            armazemDataGridViewTextBoxColumn.MinimumWidth = 60;
            armazemDataGridViewTextBoxColumn.Name = "armazemDataGridViewTextBoxColumn";
            armazemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerDataGridViewTextBoxColumn
            // 
            containerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            containerDataGridViewTextBoxColumn.DataPropertyName = "Container";
            containerDataGridViewTextBoxColumn.HeaderText = "Container";
            containerDataGridViewTextBoxColumn.MinimumWidth = 60;
            containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            containerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anueteDataGridViewTextBoxColumn
            // 
            anueteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            anueteDataGridViewTextBoxColumn.DataPropertyName = "Anuete";
            anueteDataGridViewTextBoxColumn.HeaderText = "Anuete";
            anueteDataGridViewTextBoxColumn.MinimumWidth = 60;
            anueteDataGridViewTextBoxColumn.Name = "anueteDataGridViewTextBoxColumn";
            anueteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEDataGridViewTextBoxColumn
            // 
            cEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cEDataGridViewTextBoxColumn.DataPropertyName = "CE";
            cEDataGridViewTextBoxColumn.HeaderText = "CE";
            cEDataGridViewTextBoxColumn.MinimumWidth = 60;
            cEDataGridViewTextBoxColumn.Name = "cEDataGridViewTextBoxColumn";
            cEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 83;
            // 
            // capaDataGridViewCheckBoxColumn
            // 
            capaDataGridViewCheckBoxColumn.DataPropertyName = "Capa";
            capaDataGridViewCheckBoxColumn.HeaderText = "Capa";
            capaDataGridViewCheckBoxColumn.Name = "capaDataGridViewCheckBoxColumn";
            capaDataGridViewCheckBoxColumn.ReadOnly = true;
            capaDataGridViewCheckBoxColumn.Width = 40;
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
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Alignment = ToolStripItemAlignment.Right;
            txtPesquisar.Margin = new Padding(0, 4, 3, 0);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(250, 34);
            txtPesquisar.KeyUp += txtPesquisar_KeyUp;
            txtPesquisar.Click += toolStripTextBox1_Click;
            // 
            // CmbPesquisar
            // 
            CmbPesquisar.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisar.AutoSize = false;
            CmbPesquisar.Items.AddRange(new object[] { "Importador", "Navio", "Terminal", "Armazem", "Anuete" });
            CmbPesquisar.Margin = new Padding(1, 5, 5, 0);
            CmbPesquisar.Name = "CmbPesquisar";
            CmbPesquisar.Size = new Size(121, 23);
            CmbPesquisar.Click += CmbPesquisar_Click;
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn navioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn previsaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
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
    }
}