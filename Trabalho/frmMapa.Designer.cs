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
            bsMAPA = new BindingSource(components);
            btnMAPAEnviar = new Button();
            btnMAPAExcluir = new Button();
            btnMAPAEditar = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)bsMAPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bsMAPA
            // 
            bsMAPA.DataMember = "ListaMapa";
            bsMAPA.DataSource = typeof(CLUSA.RepositorioMAPA);
            // 
            // btnMAPAEnviar
            // 
            btnMAPAEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnMAPAEnviar.Cursor = Cursors.Hand;
            btnMAPAEnviar.Location = new Point(12, 12);
            btnMAPAEnviar.MaximumSize = new Size(75, 23);
            btnMAPAEnviar.MinimumSize = new Size(75, 23);
            btnMAPAEnviar.Name = "btnMAPAEnviar";
            btnMAPAEnviar.Size = new Size(75, 23);
            btnMAPAEnviar.TabIndex = 1;
            btnMAPAEnviar.Text = "Adicionar";
            btnMAPAEnviar.UseVisualStyleBackColor = true;
            btnMAPAEnviar.Click += btnMAPAEnviar_Click;
            // 
            // btnMAPAExcluir
            // 
            btnMAPAExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnMAPAExcluir.Cursor = Cursors.Hand;
            btnMAPAExcluir.Location = new Point(140, 12);
            btnMAPAExcluir.MaximumSize = new Size(75, 23);
            btnMAPAExcluir.MinimumSize = new Size(75, 23);
            btnMAPAExcluir.Name = "btnMAPAExcluir";
            btnMAPAExcluir.Size = new Size(75, 23);
            btnMAPAExcluir.TabIndex = 2;
            btnMAPAExcluir.Text = "Excluir";
            btnMAPAExcluir.UseVisualStyleBackColor = true;
            btnMAPAExcluir.Click += btnMAPAExcluir_Click;
            // 
            // btnMAPAEditar
            // 
            btnMAPAEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnMAPAEditar.Cursor = Cursors.Hand;
            btnMAPAEditar.Location = new Point(278, 12);
            btnMAPAEditar.MaximumSize = new Size(75, 23);
            btnMAPAEditar.MinimumSize = new Size(75, 23);
            btnMAPAEditar.Name = "btnMAPAEditar";
            btnMAPAEditar.Size = new Size(75, 23);
            btnMAPAEditar.TabIndex = 3;
            btnMAPAEditar.Text = "Editar";
            btnMAPAEditar.UseVisualStyleBackColor = true;
            btnMAPAEditar.Click += btnMAPAEditar_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(428, 12);
            button4.MaximumSize = new Size(75, 23);
            button4.MinimumSize = new Size(75, 23);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(571, 12);
            button5.MaximumSize = new Size(75, 23);
            button5.MinimumSize = new Size(75, 23);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(713, 12);
            button6.MaximumSize = new Size(75, 23);
            button6.MinimumSize = new Size(75, 23);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
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
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnMAPAEditar);
            Controls.Add(btnMAPAExcluir);
            Controls.Add(btnMAPAEnviar);
            Controls.Add(dataGridView1);
            Name = "frmMapa";
            Text = "Planilha MAPA";
            WindowState = FormWindowState.Maximized;
            Load += frmMapa_Load;
            ((System.ComponentModel.ISupportInitialize)bsMAPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMAPAEnviar;
        private Button btnMAPAExcluir;
        private Button btnMAPAEditar;
        private Button button4;
        private Button button5;
        private Button button6;
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
    }
}