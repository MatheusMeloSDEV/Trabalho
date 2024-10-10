using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class frmAdicionaProcesso : Form
    {
        public frmAdicionaProcesso()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbMapa = new CheckBox();
            cbImetro = new CheckBox();
            cbAnvisa = new CheckBox();
            cbIbama = new CheckBox();
            cbDecex = new CheckBox();
            btnAdiciona = new Button();
            dtpDatadeInspecao = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            dtpDatadeEntrada = new DateTimePicker();
            dtpPrevisao = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            insSR = new TextBox();
            insNR = new TextBox();
            label10 = new Label();
            insStatusdoProcesso = new TextBox();
            label5 = new Label();
            insLI = new TextBox();
            label6 = new Label();
            insParametrizacao = new TextBox();
            label7 = new Label();
            insCSIOriginal = new TextBox();
            label8 = new Label();
            insPendencia = new TextBox();
            label3 = new Label();
            insTerminal = new TextBox();
            label4 = new Label();
            label2 = new Label();
            insLPCO = new TextBox();
            label1 = new Label();
            insImportador = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMapa);
            groupBox1.Controls.Add(cbImetro);
            groupBox1.Controls.Add(cbAnvisa);
            groupBox1.Controls.Add(cbIbama);
            groupBox1.Controls.Add(cbDecex);
            groupBox1.Location = new Point(31, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 74);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orgãos Anuentes";
            // 
            // cbMapa
            // 
            cbMapa.AutoSize = true;
            cbMapa.Location = new Point(27, 32);
            cbMapa.Name = "cbMapa";
            cbMapa.Size = new Size(56, 19);
            cbMapa.TabIndex = 30;
            cbMapa.Text = "Mapa";
            cbMapa.UseVisualStyleBackColor = true;
            // 
            // cbImetro
            // 
            cbImetro.AutoSize = true;
            cbImetro.Location = new Point(283, 32);
            cbImetro.Name = "cbImetro";
            cbImetro.Size = new Size(61, 19);
            cbImetro.TabIndex = 34;
            cbImetro.Text = "Imetro";
            cbImetro.UseVisualStyleBackColor = true;
            // 
            // cbAnvisa
            // 
            cbAnvisa.AutoSize = true;
            cbAnvisa.Location = new Point(89, 32);
            cbAnvisa.Name = "cbAnvisa";
            cbAnvisa.Size = new Size(61, 19);
            cbAnvisa.TabIndex = 31;
            cbAnvisa.Text = "Anvisa";
            cbAnvisa.UseVisualStyleBackColor = true;
            // 
            // cbIbama
            // 
            cbIbama.AutoSize = true;
            cbIbama.Location = new Point(220, 32);
            cbIbama.Name = "cbIbama";
            cbIbama.Size = new Size(59, 19);
            cbIbama.TabIndex = 33;
            cbIbama.Text = "Ibama";
            cbIbama.UseVisualStyleBackColor = true;
            // 
            // cbDecex
            // 
            cbDecex.AutoSize = true;
            cbDecex.Location = new Point(156, 32);
            cbDecex.Name = "cbDecex";
            cbDecex.Size = new Size(58, 19);
            cbDecex.TabIndex = 32;
            cbDecex.Text = "Decex";
            cbDecex.UseVisualStyleBackColor = true;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdiciona.Location = new Point(712, 419);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(130, 42);
            btnAdiciona.TabIndex = 63;
            btnAdiciona.Text = "Adicionar";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeInspecao.Location = new Point(422, 245);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(135, 23);
            dtpDatadeInspecao.TabIndex = 62;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(429, 221);
            label13.Name = "label13";
            label13.Size = new Size(128, 21);
            label13.TabIndex = 61;
            label13.Text = "Data de Inspeção";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(521, 169);
            label12.Name = "label12";
            label12.Size = new Size(116, 21);
            label12.TabIndex = 60;
            label12.Text = "Parametrização";
            // 
            // dtpDatadeEntrada
            // 
            dtpDatadeEntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeEntrada.Location = new Point(247, 245);
            dtpDatadeEntrada.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEntrada.Name = "dtpDatadeEntrada";
            dtpDatadeEntrada.Size = new Size(135, 23);
            dtpDatadeEntrada.TabIndex = 59;
            dtpDatadeEntrada.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpPrevisao.Location = new Point(585, 245);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 58;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(487, 47);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 57;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(335, 47);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 56;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insSR.Location = new Point(528, 45);
            insSR.Name = "insSR";
            insSR.Size = new Size(100, 23);
            insSR.TabIndex = 55;
            // 
            // insNR
            // 
            insNR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insNR.Location = new Point(377, 45);
            insNR.Name = "insNR";
            insNR.Size = new Size(100, 23);
            insNR.TabIndex = 54;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(117, 298);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 52;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insStatusdoProcesso.Location = new Point(263, 298);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(558, 23);
            insStatusdoProcesso.TabIndex = 51;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(187, 173);
            label5.Name = "label5";
            label5.Size = new Size(22, 21);
            label5.TabIndex = 50;
            label5.Text = "LI";
            // 
            // insLI
            // 
            insLI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLI.Location = new Point(215, 171);
            insLI.Name = "insLI";
            insLI.Size = new Size(204, 23);
            insLI.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(262, 221);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 48;
            label6.Text = "Data de Entrada";
            // 
            // insParametrizacao
            // 
            insParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insParametrizacao.Location = new Point(643, 167);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(128, 23);
            insParametrizacao.TabIndex = 47;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(521, 94);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 46;
            label7.Text = "CSI Original";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insCSIOriginal.Location = new Point(620, 92);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(151, 23);
            insCSIOriginal.TabIndex = 45;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(221, 354);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 44;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insPendencia.Location = new Point(304, 352);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(380, 23);
            insPendencia.TabIndex = 43;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(187, 132);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 42;
            label3.Text = "Terminal";
            // 
            // insTerminal
            // 
            insTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insTerminal.Location = new Point(262, 130);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 41;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(615, 221);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 40;
            label4.Text = "Previsão";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 132);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 39;
            label2.Text = "LPCO";
            // 
            // insLPCO
            // 
            insLPCO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLPCO.Location = new Point(576, 130);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(195, 23);
            insLPCO.TabIndex = 38;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(187, 94);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 37;
            label1.Text = "Importador";
            // 
            // insImportador
            // 
            insImportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insImportador.Location = new Point(282, 92);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 36;
            // 
            // frmAdicionaProcesso
            // 
            ClientSize = new Size(941, 498);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btnAdiciona);
            Controls.Add(dtpDatadeInspecao);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dtpDatadeEntrada);
            Controls.Add(dtpPrevisao);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(insSR);
            Controls.Add(insNR);
            Controls.Add(label10);
            Controls.Add(insStatusdoProcesso);
            Controls.Add(label5);
            Controls.Add(insLI);
            Controls.Add(label6);
            Controls.Add(insParametrizacao);
            Controls.Add(label7);
            Controls.Add(insCSIOriginal);
            Controls.Add(label8);
            Controls.Add(insPendencia);
            Controls.Add(label3);
            Controls.Add(insTerminal);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(insLPCO);
            Controls.Add(label1);
            Controls.Add(insImportador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdicionaProcesso";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {

        }
    }
}
