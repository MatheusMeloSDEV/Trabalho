namespace Trabalho
{
    partial class FrmModificaTransacao
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblValor;
        private NumericUpDown nudValor;
        private Label lblTipo;
        private ComboBox cbTipo;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblData;
        private DateTimePicker dtData;
        private Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblValor = new Label();
            nudValor = new NumericUpDown();
            lblTipo = new Label();
            cbTipo = new ComboBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblData = new Label();
            dtData = new DateTimePicker();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 15);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(80, 12);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(150, 23);
            txtDescricao.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 44);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(80, 41);
            nudValor.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(150, 23);
            nudValor.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(240, 15);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Entrada", "Saida" });
            cbTipo.Location = new Point(279, 12);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(176, 23);
            cbTipo.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(240, 44);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(305, 41);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(150, 23);
            txtCategoria.TabIndex = 7;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 76);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 8;
            lblData.Text = "Data:";
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(80, 72);
            dtData.Name = "dtData";
            dtData.Size = new Size(150, 23);
            dtData.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(305, 72);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmModificaTransacao
            // 
            ClientSize = new Size(474, 111);
            Controls.Add(btnSalvar);
            Controls.Add(dtData);
            Controls.Add(lblData);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(nudValor);
            Controls.Add(lblValor);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Name = "FrmModificaTransacao";
            Text = "Editar Transação";
            Load += FrmEditarTransacao_Load;
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
