namespace Trabalho
{
    partial class FrmMapa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BSmapa = new System.Windows.Forms.BindingSource(components);
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            BtnEditar = new System.Windows.Forms.ToolStripButton();
            BtnCancelar = new System.Windows.Forms.ToolStripButton();
            TxtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            CmbPesquisar = new System.Windows.Forms.ToolStripComboBox();
            BtnPesquisar = new System.Windows.Forms.ToolStripButton();
            BtnReload = new System.Windows.Forms.ToolStripButton();
            dataGridView1 = new System.Windows.Forms.DataGridView();

            // 
            // BSmapa
            // 
            // A propriedade DataSource será atribuída no FrmMapa_Load ou em outro local conforme necessário.
            // Não há configurações adicionais necessárias aqui no designer.

            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            toolStrip1.BackColor = System.Drawing.Color.LightGray;
            toolStrip1.AutoSize = false;
            toolStrip1.Height = 40;

            BtnEditar.Text = "Editar";
            BtnCancelar.Text = "Cancelar";
            TxtPesquisar.Size = new System.Drawing.Size(250, 25);
            CmbPesquisar.Size = new System.Drawing.Size(175, 25);
            BtnPesquisar.Text = "Pesquisar";
            BtnReload.Text = "Recarregar";

            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                BtnEditar,
                new System.Windows.Forms.ToolStripSeparator(),
                BtnCancelar,
                new System.Windows.Forms.ToolStripSeparator(),
                TxtPesquisar,
                CmbPesquisar,
                BtnPesquisar,
                BtnReload
            });

            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            toolStrip1.Size = new System.Drawing.Size(800, 40);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";

            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Bottom
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.Location = new System.Drawing.Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(776, 397);
            dataGridView1.TabIndex = 1;
            // Caso existam colunas a serem configuradas, isso é feito no FrmMapa.cs ou diretamente no modo designer do Visual Studio

            // 
            // FrmMapa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMapa";
            Text = "Planilha MAPA";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMapa_Load;

            ((System.ComponentModel.ISupportInitialize)BSmapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource BSmapa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnPesquisar;
        private System.Windows.Forms.ToolStripButton BtnReload;
        private System.Windows.Forms.ToolStripTextBox TxtPesquisar;
        private System.Windows.Forms.ToolStripComboBox CmbPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
