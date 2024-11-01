using CLUSA;
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
        public Processo processo;
        public frmAdicionaProcesso()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new Container();
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
            dtpDatadeEmbarque = new DateTimePicker();
            dtpPrevisao = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            insSR = new TextBox();
            insNR = new TextBox();
            label10 = new Label();
            insStatusdoProcesso = new TextBox();
            label5 = new Label();
            insLI = new TextBox();
            lblDataEmbarque = new Label();
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
            Exportador = new Label();
            insImportador = new TextBox();
            bsModificaProcesso = new BindingSource(components);
            label14 = new Label();
            textBox2 = new TextBox();
            label15 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label17 = new Label();
            textBox4 = new TextBox();
            cbEmbarque = new CheckBox();
            lblPEmbarque = new Label();
            label19 = new Label();
            label21 = new Label();
            textBox6 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker4 = new DateTimePicker();
            label22 = new Label();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            label18 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            groupBox3 = new GroupBox();
            comboBox4 = new ComboBox();
            label28 = new Label();
            dateTimePicker9 = new DateTimePicker();
            label29 = new Label();
            label30 = new Label();
            dateTimePicker10 = new DateTimePicker();
            label25 = new Label();
            textBox1 = new TextBox();
            label26 = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)bsModificaProcesso).BeginInit();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMapa);
            groupBox1.Controls.Add(cbImetro);
            groupBox1.Controls.Add(cbAnvisa);
            groupBox1.Controls.Add(cbIbama);
            groupBox1.Controls.Add(cbDecex);
            groupBox1.Location = new Point(12, 497);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 75);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orgãos Anuentes";
            groupBox1.Enter += groupBox1_Enter;
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
            btnAdiciona.Location = new Point(775, 514);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(112, 32);
            btnAdiciona.TabIndex = 63;
            btnAdiciona.Text = "Adicionar";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeInspecao.Format = DateTimePickerFormat.Short;
            dtpDatadeInspecao.Location = new Point(54, 386);
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
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(55, 362);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 61;
            label13.Text = "Data de Atracação";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(481, 149);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 60;
            label12.Text = "Agente de Carga";
            // 
            // dtpDatadeEmbarque
            // 
            dtpDatadeEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeEmbarque.Format = DateTimePickerFormat.Short;
            dtpDatadeEmbarque.Location = new Point(579, 385);
            dtpDatadeEmbarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEmbarque.Name = "dtpDatadeEmbarque";
            dtpDatadeEmbarque.Size = new Size(135, 23);
            dtpDatadeEmbarque.TabIndex = 59;
            dtpDatadeEmbarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEmbarque.Visible = false;
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpPrevisao.Format = DateTimePickerFormat.Short;
            dtpPrevisao.Location = new Point(746, 385);
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
            label11.Location = new Point(625, 24);
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
            label9.Location = new Point(400, 24);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 56;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insSR.Location = new Point(666, 22);
            insSR.Name = "insSR";
            insSR.Size = new Size(136, 23);
            insSR.TabIndex = 55;
            // 
            // insNR
            // 
            insNR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insNR.Location = new Point(442, 22);
            insNR.Name = "insNR";
            insNR.Size = new Size(126, 23);
            insNR.TabIndex = 54;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(43, 425);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 52;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insStatusdoProcesso.Location = new Point(189, 424);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(684, 23);
            insStatusdoProcesso.TabIndex = 51;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(176, 153);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 50;
            label5.Text = "BL";
            // 
            // insLI
            // 
            insLI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLI.Location = new Point(209, 151);
            insLI.Name = "insLI";
            insLI.Size = new Size(199, 23);
            insLI.TabIndex = 49;
            // 
            // lblDataEmbarque
            // 
            lblDataEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDataEmbarque.AutoSize = true;
            lblDataEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataEmbarque.Location = new Point(579, 362);
            lblDataEmbarque.Name = "lblDataEmbarque";
            lblDataEmbarque.Size = new Size(134, 20);
            lblDataEmbarque.TabIndex = 48;
            lblDataEmbarque.Text = "Data de Embarque";
            lblDataEmbarque.Visible = false;
            // 
            // insParametrizacao
            // 
            insParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insParametrizacao.Location = new Point(612, 147);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(119, 23);
            insParametrizacao.TabIndex = 47;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(342, 73);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 46;
            label7.Text = "Produto";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insCSIOriginal.Location = new Point(414, 71);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(178, 23);
            insCSIOriginal.TabIndex = 45;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(89, 465);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 44;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insPendencia.Location = new Point(172, 463);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(671, 23);
            insPendencia.TabIndex = 43;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 111);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 42;
            label3.Text = "Ordem";
            // 
            // insTerminal
            // 
            insTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insTerminal.Location = new Point(112, 109);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 41;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(781, 362);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 40;
            label4.Text = "Previsão";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 111);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 39;
            label2.Text = "FLO";
            // 
            // insLPCO
            // 
            insLPCO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLPCO.Location = new Point(385, 109);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(207, 23);
            insLPCO.TabIndex = 38;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exportador.Location = new Point(37, 73);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 37;
            Exportador.Text = "Exportador";
            // 
            // insImportador
            // 
            insImportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insImportador.Location = new Point(132, 71);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 36;
            // 
            // bsModificaProcesso
            // 
            bsModificaProcesso.DataSource = typeof(Processo);
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(653, 73);
            label14.Name = "label14";
            label14.Size = new Size(125, 21);
            label14.TabIndex = 68;
            label14.Text = "Porto de Destino";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(784, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 67;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(653, 111);
            label15.Name = "label15";
            label15.Size = new Size(78, 21);
            label15.TabIndex = 66;
            label15.Text = "Free Time";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(657, 514);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 71;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(519, 530);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 25);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Desovado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(519, 530);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 25);
            checkBox2.TabIndex = 72;
            checkBox2.Text = "Amostra";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(222, 386);
            dateTimePicker1.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 74;
            dateTimePicker1.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(257, 362);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 73;
            label16.Text = "Inspeção";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(519, 523);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 25);
            checkBox3.TabIndex = 35;
            checkBox3.Text = "Desovado";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(425, 523);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(88, 25);
            checkBox4.TabIndex = 72;
            checkBox4.Text = "Amostra";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(125, 24);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 76;
            label17.Text = "Importador";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Location = new Point(220, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 75;
            // 
            // cbEmbarque
            // 
            cbEmbarque.AutoSize = true;
            cbEmbarque.Location = new Point(456, 396);
            cbEmbarque.Name = "cbEmbarque";
            cbEmbarque.Size = new Size(15, 14);
            cbEmbarque.TabIndex = 77;
            cbEmbarque.UseVisualStyleBackColor = true;
            cbEmbarque.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // lblPEmbarque
            // 
            lblPEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPEmbarque.AutoSize = true;
            lblPEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPEmbarque.Location = new Point(425, 373);
            lblPEmbarque.Name = "lblPEmbarque";
            lblPEmbarque.Size = new Size(77, 20);
            lblPEmbarque.TabIndex = 78;
            lblPEmbarque.Text = "Embarque";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(683, 24);
            label19.Name = "label19";
            label19.Size = new Size(94, 15);
            label19.TabIndex = 88;
            label19.Text = "Parametrização";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(21, 37);
            label21.Name = "label21";
            label21.Size = new Size(28, 21);
            label21.TabIndex = 85;
            label21.Text = "N°";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(55, 35);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 84;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(737, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(166, 23);
            numericUpDown1.TabIndex = 91;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(200, 47);
            dateTimePicker4.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(135, 23);
            dateTimePicker4.TabIndex = 93;
            dateTimePicker4.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker4.Visible = false;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(218, 24);
            label22.Name = "label22";
            label22.Size = new Size(99, 15);
            label22.TabIndex = 92;
            label22.Text = "Data de Registro";
            label22.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            comboBox2.Location = new Point(666, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 23);
            comboBox2.TabIndex = 94;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(dateTimePicker4);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new Point(37, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 82);
            groupBox2.TabIndex = 95;
            groupBox2.TabStop = false;
            groupBox2.Text = "DI";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(513, 24);
            label18.Name = "label18";
            label18.Size = new Size(132, 15);
            label18.TabIndex = 96;
            label18.Text = "Data de Carregamento";
            label18.Visible = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(512, 47);
            dateTimePicker3.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(135, 23);
            dateTimePicker3.TabIndex = 97;
            dateTimePicker3.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker3.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(357, 24);
            label6.Name = "label6";
            label6.Size = new Size(131, 15);
            label6.TabIndex = 94;
            label6.Text = "Data de Desembaraço";
            label6.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(355, 47);
            dateTimePicker2.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(135, 23);
            dateTimePicker2.TabIndex = 95;
            dateTimePicker2.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker2.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(dateTimePicker9);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(dateTimePicker10);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label26);
            groupBox3.Location = new Point(81, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(750, 82);
            groupBox3.TabIndex = 98;
            groupBox3.TabStop = false;
            groupBox3.Text = "LI/LPCO";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            comboBox4.Location = new Point(567, 47);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(128, 23);
            comboBox4.TabIndex = 101;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(418, 24);
            label28.Name = "label28";
            label28.Size = new Size(121, 15);
            label28.TabIndex = 102;
            label28.Text = "Data de Deferimento";
            label28.Visible = false;
            // 
            // dateTimePicker9
            // 
            dateTimePicker9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker9.Format = DateTimePickerFormat.Short;
            dateTimePicker9.Location = new Point(411, 47);
            dateTimePicker9.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker9.Name = "dateTimePicker9";
            dateTimePicker9.Size = new Size(135, 23);
            dateTimePicker9.TabIndex = 103;
            dateTimePicker9.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker9.Visible = false;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(585, 24);
            label29.Name = "label29";
            label29.Size = new Size(94, 15);
            label29.TabIndex = 98;
            label29.Text = "Parametrização";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(274, 24);
            label30.Name = "label30";
            label30.Size = new Size(99, 15);
            label30.TabIndex = 99;
            label30.Text = "Data de Registro";
            label30.Visible = false;
            // 
            // dateTimePicker10
            // 
            dateTimePicker10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker10.Format = DateTimePickerFormat.Short;
            dateTimePicker10.Location = new Point(256, 47);
            dateTimePicker10.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker10.Name = "dateTimePicker10";
            dateTimePicker10.Size = new Size(135, 23);
            dateTimePicker10.TabIndex = 100;
            dateTimePicker10.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker10.Visible = false;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(768, 24);
            label25.Name = "label25";
            label25.Size = new Size(99, 15);
            label25.TabIndex = 92;
            label25.Text = "Data de Registro";
            label25.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(60, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 84;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(26, 38);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
            // 
            // frmAdicionaProcesso
            // 
            ClientSize = new Size(941, 584);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(cbEmbarque);
            Controls.Add(label17);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label16);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(textBox2);
            Controls.Add(label15);
            Controls.Add(groupBox1);
            Controls.Add(btnAdiciona);
            Controls.Add(dtpDatadeInspecao);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dtpDatadeEmbarque);
            Controls.Add(dtpPrevisao);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(insSR);
            Controls.Add(insNR);
            Controls.Add(label10);
            Controls.Add(insStatusdoProcesso);
            Controls.Add(label5);
            Controls.Add(insLI);
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
            Controls.Add(Exportador);
            Controls.Add(insImportador);
            Controls.Add(lblPEmbarque);
            Controls.Add(lblDataEmbarque);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdicionaProcesso";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAdicionaProcesso_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)bsModificaProcesso).EndInit();
            ((ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            processo.Ref_USA = "";
            processo.Exportador = "";
            processo.Ordem = "";
            processo.FLO = "";
            processo.PortoDestino = "";
            processo.Produto = "";
            processo.AgenteDeCarga = "";
            if (processo.PossuiEmbarque)
            {
                processo.DataEmbarque = "";
            }
            else
            {
                processo.DataEmbarque = "-";
            }
            processo.BL = "";
            processo.FreeTime = 0;
            processo.DataDeAtracacao = "";
            processo.RecebOriginais = "";
            processo.FormaRecebERecebidos = "";
            processo.Inspecao = "";
            processo.StatusDoProcesso = "";
            processo.DI = "";
            processo.ParametrizacaoDI = "";
            DialogResult = DialogResult.OK;
        }

        private void frmAdicionaProcesso_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmbarque.Checked)
            {
                lblPEmbarque.Visible = false;
                lblDataEmbarque.Visible = true;
                dtpDatadeEmbarque.Visible = true;
                cbEmbarque.Location = new Point(49, 227);
            }
            else
            {
                cbEmbarque.Location = new Point(125, 227);
                lblPEmbarque.Visible = true;
                lblDataEmbarque.Visible = false;
                dtpDatadeEmbarque.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
