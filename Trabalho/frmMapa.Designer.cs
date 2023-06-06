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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            bsMAPA = new BindingSource(components);
            btnMAPAEnviar = new Button();
            btnMAPAExcluir = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMAPA).BeginInit();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, importadorDataGridViewTextBoxColumn, navioDataGridViewTextBoxColumn, previsaoDataGridViewTextBoxColumn, terminalDataGridViewTextBoxColumn, armazemDataGridViewTextBoxColumn, containerDataGridViewTextBoxColumn, anueteDataGridViewTextBoxColumn, cEDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, capaDataGridViewCheckBoxColumn });
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
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // importadorDataGridViewTextBoxColumn
            // 
            importadorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            importadorDataGridViewTextBoxColumn.DataPropertyName = "Importador";
            importadorDataGridViewTextBoxColumn.HeaderText = "Importador";
            importadorDataGridViewTextBoxColumn.Name = "importadorDataGridViewTextBoxColumn";
            importadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navioDataGridViewTextBoxColumn
            // 
            navioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            navioDataGridViewTextBoxColumn.DataPropertyName = "Navio";
            navioDataGridViewTextBoxColumn.HeaderText = "Navio";
            navioDataGridViewTextBoxColumn.Name = "navioDataGridViewTextBoxColumn";
            navioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previsaoDataGridViewTextBoxColumn
            // 
            previsaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            previsaoDataGridViewTextBoxColumn.DataPropertyName = "Previsao";
            previsaoDataGridViewTextBoxColumn.HeaderText = "Previsao";
            previsaoDataGridViewTextBoxColumn.Name = "previsaoDataGridViewTextBoxColumn";
            previsaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            terminalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            terminalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // armazemDataGridViewTextBoxColumn
            // 
            armazemDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            armazemDataGridViewTextBoxColumn.DataPropertyName = "Armazem";
            armazemDataGridViewTextBoxColumn.HeaderText = "Armazem";
            armazemDataGridViewTextBoxColumn.Name = "armazemDataGridViewTextBoxColumn";
            armazemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerDataGridViewTextBoxColumn
            // 
            containerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            containerDataGridViewTextBoxColumn.DataPropertyName = "Container";
            containerDataGridViewTextBoxColumn.HeaderText = "Container";
            containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            containerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anueteDataGridViewTextBoxColumn
            // 
            anueteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            anueteDataGridViewTextBoxColumn.DataPropertyName = "Anuete";
            anueteDataGridViewTextBoxColumn.HeaderText = "Anuete";
            anueteDataGridViewTextBoxColumn.Name = "anueteDataGridViewTextBoxColumn";
            anueteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEDataGridViewTextBoxColumn
            // 
            cEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cEDataGridViewTextBoxColumn.DataPropertyName = "CE";
            cEDataGridViewTextBoxColumn.HeaderText = "CE";
            cEDataGridViewTextBoxColumn.Name = "cEDataGridViewTextBoxColumn";
            cEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capaDataGridViewCheckBoxColumn
            // 
            capaDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            capaDataGridViewCheckBoxColumn.DataPropertyName = "Capa";
            capaDataGridViewCheckBoxColumn.HeaderText = "Capa";
            capaDataGridViewCheckBoxColumn.Name = "capaDataGridViewCheckBoxColumn";
            capaDataGridViewCheckBoxColumn.ReadOnly = true;
            capaDataGridViewCheckBoxColumn.Width = 40;
            // 
            // bsMAPA
            // 
            bsMAPA.DataSource = typeof(CLUSA.MAPA);
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
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(278, 12);
            button3.MaximumSize = new Size(75, 23);
            button3.MinimumSize = new Size(75, 23);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
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
            // frmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnMAPAExcluir);
            Controls.Add(btnMAPAEnviar);
            Controls.Add(dataGridView1);
            Name = "frmMapa";
            Text = "Planilha MAPA";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMAPA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnMAPAEnviar;
        private Button btnMAPAExcluir;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private BindingSource bsMAPA;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
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