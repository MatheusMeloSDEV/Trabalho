namespace Trabalho
{
    partial class FrmIbama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIbama));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BsIbama = new BindingSource(components);
            ToolStripMain = new ToolStrip();
            BtnEditar = new ToolStripButton();
            BtnCancelar = new ToolStripButton();
            BtnPesquisar = new ToolStripButton();
            TxtPesquisa = new ToolStripTextBox();
            CmbPesquisa = new ToolStripComboBox();
            DgvIbama = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColRefUSA = new DataGridViewTextBoxColumn();
            ColImportador = new DataGridViewTextBoxColumn();
            ColSR = new DataGridViewTextBoxColumn();
            ColExportador = new DataGridViewTextBoxColumn();
            ColNavio = new DataGridViewTextBoxColumn();
            ColTerminal = new DataGridViewTextBoxColumn();
            ColProduto = new DataGridViewTextBoxColumn();
            ColOrigem = new DataGridViewTextBoxColumn();
            ColTEmbarque = new DataGridViewCheckBoxColumn();
            ColDataDeAtracacao = new DataGridViewTextBoxColumn();
            ColInspecao = new DataGridViewTextBoxColumn();
            ColDataEmbarque = new DataGridViewTextBoxColumn();
            ColNCM = new DataGridViewTextBoxColumn();
            ColLI = new DataGridViewTextBoxColumn();
            ColLPCO = new DataGridViewTextBoxColumn();
            ColDataRegistroLPCO = new DataGridViewTextBoxColumn();
            ColDataDeferimentoLPCO = new DataGridViewTextBoxColumn();
            ColParametrizacaoLPCO = new DataGridViewTextBoxColumn();
            ColAmostra = new DataGridViewCheckBoxColumn();
            ColPendencia = new DataGridViewTextBoxColumn();
            ColStatusDoProcesso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)BsIbama).BeginInit();
            ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvIbama).BeginInit();
            SuspendLayout();
            // 
            // BsIbama
            // 
            BsIbama.DataMember = "ListaIbama";
            BsIbama.DataSource = typeof(CLUSA.RepositorioIbama);
            // 
            // ToolStripMain
            // 
            ToolStripMain.AutoSize = false;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.ImageScalingSize = new Size(20, 20);
            ToolStripMain.Items.AddRange(new ToolStripItem[] { BtnEditar, BtnCancelar, BtnPesquisar, TxtPesquisa, CmbPesquisa });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Padding = new Padding(6, 0, 1, 0);
            ToolStripMain.RenderMode = ToolStripRenderMode.System;
            ToolStripMain.Size = new Size(800, 38);
            ToolStripMain.TabIndex = 10;
            // 
            // BtnEditar
            // 
            BtnEditar.AutoSize = false;
            BtnEditar.BackColor = Color.MediumTurquoise;
            BtnEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(62, 32);
            BtnEditar.Text = "Editar";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Alignment = ToolStripItemAlignment.Right;
            BtnCancelar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(62, 32);
            BtnCancelar.Text = "Cancelar";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Alignment = ToolStripItemAlignment.Right;
            BtnPesquisar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(62, 32);
            BtnPesquisar.Text = "Pesquisar";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Alignment = ToolStripItemAlignment.Right;
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(250, 34);
            // 
            // CmbPesquisa
            // 
            CmbPesquisa.Alignment = ToolStripItemAlignment.Right;
            CmbPesquisa.AutoSize = false;
            CmbPesquisa.Items.AddRange(new object[] { "Ref USA", "Importador", "Terminal", "Pendencias", "LI", "LPCO" });
            CmbPesquisa.Name = "CmbCriterioPesquisa";
            CmbPesquisa.Size = new Size(121, 23);
            // 
            // DgvIbama
            // 
            DgvIbama.AllowUserToAddRows = false;
            DgvIbama.AllowUserToDeleteRows = false;
            DgvIbama.AutoGenerateColumns = false;
            DgvIbama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvIbama.Columns.AddRange(new DataGridViewColumn[]
            {
                ColId, ColRefUSA, ColImportador, ColSR, ColExportador, ColNavio, ColTerminal, ColProduto,
                ColOrigem, ColTEmbarque, ColDataDeAtracacao, ColInspecao, ColDataEmbarque, ColNCM,
                ColLI, ColLPCO, ColDataRegistroLPCO, ColDataDeferimentoLPCO, ColParametrizacaoLPCO,
                ColAmostra, ColPendencia, ColStatusDoProcesso
            });
            DgvIbama.DataSource = BsIbama;
            DgvIbama.Location = new Point(12, 41);
            DgvIbama.Name = "DgvIbama";
            DgvIbama.RowHeadersVisible = false;
            DgvIbama.Size = new Size(776, 397);
            DgvIbama.TabIndex = 11;
            // 
            // ColId
            // 
            ColId.HeaderText = "Id";
            ColId.Name = "ColId";
            // 
            // ColRefUSA
            // 
            ColRefUSA.HeaderText = "Ref USA";
            ColRefUSA.Name = "ColRefUSA";
            // 
            // ColImportador
            // 
            ColImportador.HeaderText = "Importador";
            ColImportador.Name = "ColImportador";
            // 
            // ColSR
            // 
            ColSR.HeaderText = "SR";
            ColSR.Name = "ColSR";
            // 
            // ColExportador
            // 
            ColExportador.HeaderText = "Exportador";
            ColExportador.Name = "ColExportador";
            // 
            // ColNavio
            // 
            ColNavio.HeaderText = "Navio";
            ColNavio.Name = "ColNavio";
            // 
            // ColTerminal
            // 
            ColTerminal.HeaderText = "Terminal";
            ColTerminal.Name = "ColTerminal";
            // 
            // ColProduto
            // 
            ColProduto.HeaderText = "Produto";
            ColProduto.Name = "ColProduto";
            // 
            // ColOrigem
            // 
            ColOrigem.HeaderText = "Origem";
            ColOrigem.Name = "ColOrigem";
            // 
            // ColTEmbarque
            // 
            ColTEmbarque.HeaderText = "Embarque (T)";
            ColTEmbarque.Name = "ColTEmbarque";
            // 
            // ColDataDeAtracacao
            // 
            ColDataDeAtracacao.HeaderText = "Data de Atracação";
            ColDataDeAtracacao.Name = "ColDataDeAtracacao";
            // 
            // ColInspecao
            // 
            ColInspecao.HeaderText = "Inspeção";
            ColInspecao.Name = "ColInspecao";
            // 
            // ColDataEmbarque
            // 
            ColDataEmbarque.HeaderText = "Data de Embarque";
            ColDataEmbarque.Name = "ColDataEmbarque";
            // 
            // ColNCM
            // 
            ColNCM.HeaderText = "NCM";
            ColNCM.Name = "ColNCM";
            // 
            // ColLI
            // 
            ColLI.HeaderText = "LI";
            ColLI.Name = "ColLI";
            // 
            // ColLPCO
            // 
            ColLPCO.HeaderText = "LPCO";
            ColLPCO.Name = "ColLPCO";
            // 
            // ColDataRegistroLPCO
            // 
            ColDataRegistroLPCO.HeaderText = "Data Registro LPCO";
            ColDataRegistroLPCO.Name = "ColDataRegistroLPCO";
            // 
            // ColDataDeferimentoLPCO
            // 
            ColDataDeferimentoLPCO.HeaderText = "Data Deferimento LPCO";
            ColDataDeferimentoLPCO.Name = "ColDataDeferimentoLPCO";
            // 
            // ColParametrizacaoLPCO
            // 
            ColParametrizacaoLPCO.HeaderText = "Parametrização LPCO";
            ColParametrizacaoLPCO.Name = "ColParametrizacaoLPCO";
            // 
            // ColAmostra
            // 
            ColAmostra.HeaderText = "Amostra";
            ColAmostra.Name = "ColAmostra";
            // 
            // ColPendencia
            // 
            ColPendencia.HeaderText = "Pendência";
            ColPendencia.Name = "ColPendencia";
            // 
            // ColStatusDoProcesso
            // 
            ColStatusDoProcesso.HeaderText = "Status do Processo";
            ColStatusDoProcesso.Name = "ColStatusDoProcesso";
            // 
            // FrmIbama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvIbama);
            Controls.Add(ToolStripMain);
            Name = "FrmIbama";
            Text = "Gestão de Processos Ibama";
            Load += FrmIbama_Load;
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BsIbama).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvIbama).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip ToolStripMain;
        private ToolStripButton BtnEditar;
        private ToolStripButton BtnCancelar;
        private ToolStripButton BtnPesquisar;
        private ToolStripTextBox TxtPesquisa;
        private ToolStripComboBox CmbPesquisa;
        private BindingSource BsIbama;
        private DataGridView DgvIbama;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColRefUSA;
        private DataGridViewTextBoxColumn ColImportador;
        private DataGridViewTextBoxColumn ColSR;
        private DataGridViewTextBoxColumn ColExportador;
        private DataGridViewTextBoxColumn ColNavio;
        private DataGridViewTextBoxColumn ColTerminal;
        private DataGridViewTextBoxColumn ColProduto;
        private DataGridViewTextBoxColumn ColOrigem;
        private DataGridViewCheckBoxColumn ColTEmbarque;
        private DataGridViewTextBoxColumn ColDataDeAtracacao;
        private DataGridViewTextBoxColumn ColInspecao;
        private DataGridViewTextBoxColumn ColDataEmbarque;
        private DataGridViewTextBoxColumn ColNCM;
        private DataGridViewTextBoxColumn ColLI;
        private DataGridViewTextBoxColumn ColLPCO;
        private DataGridViewTextBoxColumn ColDataRegistroLPCO;
        private DataGridViewTextBoxColumn ColDataDeferimentoLPCO;
        private DataGridViewTextBoxColumn ColParametrizacaoLPCO;
        private DataGridViewCheckBoxColumn ColAmostra;
        private DataGridViewTextBoxColumn ColPendencia;
        private DataGridViewTextBoxColumn ColStatusDoProcesso;
    }
}
