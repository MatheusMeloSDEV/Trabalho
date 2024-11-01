namespace Trabalho
{
    partial class frmModificaProcesso
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
            bsModificaProcesso = new BindingSource(components);
            groupBox3 = new GroupBox();
            label31 = new Label();
            label27 = new Label();
            label20 = new Label();
            comboBox4 = new ComboBox();
            dateTimePicker8 = new DateTimePicker();
            dateTimePicker5 = new DateTimePicker();
            label28 = new Label();
            label23 = new Label();
            dateTimePicker9 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            label29 = new Label();
            label24 = new Label();
            label30 = new Label();
            dateTimePicker10 = new DateTimePicker();
            label25 = new Label();
            dateTimePicker7 = new DateTimePicker();
            textBox1 = new TextBox();
            label26 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label19 = new Label();
            label22 = new Label();
            dateTimePicker4 = new DateTimePicker();
            textBox6 = new TextBox();
            label1 = new Label();
            label21 = new Label();
            numericUpDown1 = new NumericUpDown();
            cbEmbarque = new CheckBox();
            label17 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            label14 = new Label();
            textBox2 = new TextBox();
            label15 = new Label();
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
            lblPEmbarque = new Label();
            lblDataEmbarque = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // bsModificaProcesso
            // 
            bsModificaProcesso.DataSource = typeof(CLUSA.Processo);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(dateTimePicker8);
            groupBox3.Controls.Add(dateTimePicker5);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(dateTimePicker9);
            groupBox3.Controls.Add(dateTimePicker6);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(dateTimePicker10);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(dateTimePicker7);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label26);
            groupBox3.Location = new Point(35, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(834, 82);
            groupBox3.TabIndex = 177;
            groupBox3.TabStop = false;
            groupBox3.Text = "LI/LPCO";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(1193, 34);
            label31.Name = "label31";
            label31.Size = new Size(116, 21);
            label31.TabIndex = 129;
            label31.Text = "Parametrização";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(1781, 24);
            label27.Name = "label27";
            label27.Size = new Size(132, 15);
            label27.TabIndex = 104;
            label27.Text = "Data de Carregamento";
            label27.Visible = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(2415, 24);
            label20.Name = "label20";
            label20.Size = new Size(132, 15);
            label20.TabIndex = 96;
            label20.Text = "Data de Carregamento";
            label20.Visible = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            comboBox4.Location = new Point(690, 38);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(128, 23);
            comboBox4.TabIndex = 101;
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker8.Format = DateTimePickerFormat.Short;
            dateTimePicker8.Location = new Point(1780, 47);
            dateTimePicker8.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(135, 23);
            dateTimePicker8.TabIndex = 105;
            dateTimePicker8.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker8.Visible = false;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker5.Location = new Point(2414, 47);
            dateTimePicker5.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(135, 23);
            dateTimePicker5.TabIndex = 97;
            dateTimePicker5.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker5.Visible = false;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(1625, 24);
            label28.Name = "label28";
            label28.Size = new Size(131, 15);
            label28.TabIndex = 102;
            label28.Text = "Data de Desembaraço";
            label28.Visible = false;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(2259, 24);
            label23.Name = "label23";
            label23.Size = new Size(131, 15);
            label23.TabIndex = 94;
            label23.Text = "Data de Desembaraço";
            label23.Visible = false;
            // 
            // dateTimePicker9
            // 
            dateTimePicker9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker9.Format = DateTimePickerFormat.Short;
            dateTimePicker9.Location = new Point(1623, 47);
            dateTimePicker9.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker9.Name = "dateTimePicker9";
            dateTimePicker9.Size = new Size(135, 23);
            dateTimePicker9.TabIndex = 103;
            dateTimePicker9.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker9.Visible = false;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker6.Location = new Point(2257, 47);
            dateTimePicker6.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(135, 23);
            dateTimePicker6.TabIndex = 95;
            dateTimePicker6.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker6.Visible = false;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(1951, 24);
            label29.Name = "label29";
            label29.Size = new Size(94, 15);
            label29.TabIndex = 98;
            label29.Text = "Parametrização";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(2585, 24);
            label24.Name = "label24";
            label24.Size = new Size(94, 15);
            label24.TabIndex = 88;
            label24.Text = "Parametrização";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(1486, 24);
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
            dateTimePicker10.Location = new Point(1468, 47);
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
            label25.Location = new Point(2120, 24);
            label25.Name = "label25";
            label25.Size = new Size(99, 15);
            label25.TabIndex = 92;
            label25.Text = "Data de Registro";
            label25.Visible = false;
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker7.Location = new Point(2102, 47);
            dateTimePicker7.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(135, 23);
            dateTimePicker7.TabIndex = 93;
            dateTimePicker7.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker7.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(73, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 84;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(39, 36);
            label26.Name = "label26";
            label26.Size = new Size(28, 21);
            label26.TabIndex = 85;
            label26.Text = "N°";
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
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new Point(35, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 82);
            groupBox2.TabIndex = 176;
            groupBox2.TabStop = false;
            groupBox2.Text = "DI";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1781, 24);
            label18.Name = "label18";
            label18.Size = new Size(132, 15);
            label18.TabIndex = 96;
            label18.Text = "Data de Carregamento";
            label18.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Verde", "Amarelo", "Vermelho" });
            comboBox2.Location = new Point(690, 34);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 23);
            comboBox2.TabIndex = 94;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(1780, 47);
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
            label6.Location = new Point(1625, 24);
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
            dateTimePicker2.Location = new Point(1623, 47);
            dateTimePicker2.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(135, 23);
            dateTimePicker2.TabIndex = 95;
            dateTimePicker2.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker2.Visible = false;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(1951, 24);
            label19.Name = "label19";
            label19.Size = new Size(94, 15);
            label19.TabIndex = 88;
            label19.Text = "Parametrização";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(1486, 24);
            label22.Name = "label22";
            label22.Size = new Size(99, 15);
            label22.TabIndex = 92;
            label22.Text = "Data de Registro";
            label22.Visible = false;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(1468, 47);
            dateTimePicker4.MinDate = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(135, 23);
            dateTimePicker4.TabIndex = 93;
            dateTimePicker4.Value = new DateTime(2024, 10, 17, 0, 0, 0, 0);
            dateTimePicker4.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(73, 34);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 84;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1193, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 128;
            label1.Text = "Parametrização";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(39, 35);
            label21.Name = "label21";
            label21.Size = new Size(28, 21);
            label21.TabIndex = 85;
            label21.Text = "N°";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(733, 118);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(166, 23);
            numericUpDown1.TabIndex = 175;
            // 
            // cbEmbarque
            // 
            cbEmbarque.AutoSize = true;
            cbEmbarque.Location = new Point(452, 405);
            cbEmbarque.Name = "cbEmbarque";
            cbEmbarque.Size = new Size(15, 14);
            cbEmbarque.TabIndex = 172;
            cbEmbarque.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(121, 33);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 171;
            label17.Text = "Importador";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Location = new Point(216, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 170;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(218, 395);
            dateTimePicker1.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 169;
            dateTimePicker1.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(253, 371);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 168;
            label16.Text = "Inspeção";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(649, 82);
            label14.Name = "label14";
            label14.Size = new Size(125, 21);
            label14.TabIndex = 167;
            label14.Text = "Porto de Destino";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(780, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 166;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(649, 120);
            label15.Name = "label15";
            label15.Size = new Size(78, 21);
            label15.TabIndex = 165;
            label15.Text = "Free Time";
            // 
            // dtpDatadeInspecao
            // 
            dtpDatadeInspecao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeInspecao.Format = DateTimePickerFormat.Short;
            dtpDatadeInspecao.Location = new Point(50, 395);
            dtpDatadeInspecao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeInspecao.Name = "dtpDatadeInspecao";
            dtpDatadeInspecao.Size = new Size(135, 23);
            dtpDatadeInspecao.TabIndex = 164;
            dtpDatadeInspecao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(51, 371);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 163;
            label13.Text = "Data de Atracação";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(338, 157);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 162;
            label12.Text = "Agente de Carga";
            // 
            // dtpDatadeEmbarque
            // 
            dtpDatadeEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDatadeEmbarque.Format = DateTimePickerFormat.Short;
            dtpDatadeEmbarque.Location = new Point(575, 394);
            dtpDatadeEmbarque.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEmbarque.Name = "dtpDatadeEmbarque";
            dtpDatadeEmbarque.Size = new Size(135, 23);
            dtpDatadeEmbarque.TabIndex = 161;
            dtpDatadeEmbarque.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpDatadeEmbarque.Visible = false;
            // 
            // dtpPrevisao
            // 
            dtpPrevisao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpPrevisao.Format = DateTimePickerFormat.Short;
            dtpPrevisao.Location = new Point(742, 394);
            dtpPrevisao.MinDate = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            dtpPrevisao.Name = "dtpPrevisao";
            dtpPrevisao.Size = new Size(135, 23);
            dtpPrevisao.TabIndex = 160;
            dtpPrevisao.Value = new DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(621, 33);
            label11.Name = "label11";
            label11.Size = new Size(35, 21);
            label11.TabIndex = 159;
            label11.Text = "S/R";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(396, 33);
            label9.Name = "label9";
            label9.Size = new Size(38, 21);
            label9.TabIndex = 158;
            label9.Text = "N/R";
            // 
            // insSR
            // 
            insSR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insSR.Location = new Point(662, 31);
            insSR.Name = "insSR";
            insSR.Size = new Size(136, 23);
            insSR.TabIndex = 157;
            // 
            // insNR
            // 
            insNR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insNR.Location = new Point(438, 31);
            insNR.Name = "insNR";
            insNR.Size = new Size(126, 23);
            insNR.TabIndex = 156;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(39, 434);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 155;
            label10.Text = "Status do Processo";
            // 
            // insStatusdoProcesso
            // 
            insStatusdoProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insStatusdoProcesso.Location = new Point(185, 433);
            insStatusdoProcesso.Name = "insStatusdoProcesso";
            insStatusdoProcesso.Size = new Size(684, 23);
            insStatusdoProcesso.TabIndex = 154;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 161);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 153;
            label5.Text = "BL";
            // 
            // insLI
            // 
            insLI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLI.Location = new Point(66, 159);
            insLI.Name = "insLI";
            insLI.Size = new Size(199, 23);
            insLI.TabIndex = 152;
            // 
            // insParametrizacao
            // 
            insParametrizacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insParametrizacao.Location = new Point(469, 155);
            insParametrizacao.Name = "insParametrizacao";
            insParametrizacao.Size = new Size(119, 23);
            insParametrizacao.TabIndex = 150;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(338, 82);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 149;
            label7.Text = "Produto";
            // 
            // insCSIOriginal
            // 
            insCSIOriginal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insCSIOriginal.Location = new Point(410, 80);
            insCSIOriginal.Name = "insCSIOriginal";
            insCSIOriginal.Size = new Size(178, 23);
            insCSIOriginal.TabIndex = 148;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(85, 474);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 147;
            label8.Text = "Pendência";
            // 
            // insPendencia
            // 
            insPendencia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insPendencia.Location = new Point(168, 472);
            insPendencia.Name = "insPendencia";
            insPendencia.Size = new Size(671, 23);
            insPendencia.TabIndex = 146;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 120);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 145;
            label3.Text = "Ordem";
            // 
            // insTerminal
            // 
            insTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insTerminal.Location = new Point(108, 118);
            insTerminal.Name = "insTerminal";
            insTerminal.Size = new Size(157, 23);
            insTerminal.TabIndex = 144;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(777, 371);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 143;
            label4.Text = "Previsão";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(338, 120);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 142;
            label2.Text = "FLO";
            // 
            // insLPCO
            // 
            insLPCO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insLPCO.Location = new Point(381, 118);
            insLPCO.Name = "insLPCO";
            insLPCO.Size = new Size(207, 23);
            insLPCO.TabIndex = 141;
            // 
            // Exportador
            // 
            Exportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exportador.AutoSize = true;
            Exportador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exportador.Location = new Point(33, 82);
            Exportador.Name = "Exportador";
            Exportador.Size = new Size(86, 21);
            Exportador.TabIndex = 140;
            Exportador.Text = "Exportador";
            // 
            // insImportador
            // 
            insImportador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insImportador.Location = new Point(128, 80);
            insImportador.Name = "insImportador";
            insImportador.Size = new Size(137, 23);
            insImportador.TabIndex = 139;
            // 
            // lblPEmbarque
            // 
            lblPEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPEmbarque.AutoSize = true;
            lblPEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPEmbarque.Location = new Point(421, 382);
            lblPEmbarque.Name = "lblPEmbarque";
            lblPEmbarque.Size = new Size(77, 20);
            lblPEmbarque.TabIndex = 173;
            lblPEmbarque.Text = "Embarque";
            // 
            // lblDataEmbarque
            // 
            lblDataEmbarque.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDataEmbarque.AutoSize = true;
            lblDataEmbarque.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataEmbarque.Location = new Point(575, 371);
            lblDataEmbarque.Name = "lblDataEmbarque";
            lblDataEmbarque.Size = new Size(134, 20);
            lblDataEmbarque.TabIndex = 151;
            lblDataEmbarque.Text = "Data de Embarque";
            lblDataEmbarque.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.Location = new Point(662, 510);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 32);
            btnCancelar.TabIndex = 179;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Location = new Point(780, 510);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 32);
            btnEditar.TabIndex = 178;
            btnEditar.Text = "Adicionar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmModificaProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 554);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(cbEmbarque);
            Controls.Add(label17);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(textBox2);
            Controls.Add(label15);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmModificaProcesso";
            Text = "frmModificaProcesso";
            Load += frmModificaProcesso_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaProcesso).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsModificaProcesso;
        private GroupBox groupBox3;
        private Label label31;
        private Label label27;
        private Label label20;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker8;
        private DateTimePicker dateTimePicker5;
        private Label label28;
        private Label label23;
        private DateTimePicker dateTimePicker9;
        private DateTimePicker dateTimePicker6;
        private Label label29;
        private Label label24;
        private Label label30;
        private DateTimePicker dateTimePicker10;
        private Label label25;
        private DateTimePicker dateTimePicker7;
        private TextBox textBox1;
        private Label label26;
        private GroupBox groupBox2;
        private Label label18;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label19;
        private Label label22;
        private DateTimePicker dateTimePicker4;
        private TextBox textBox6;
        private Label label1;
        private Label label21;
        private NumericUpDown numericUpDown1;
        private CheckBox cbEmbarque;
        private Label label17;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label16;
        private Label label14;
        private TextBox textBox2;
        private Label label15;
        private DateTimePicker dtpDatadeInspecao;
        private Label label13;
        private Label label12;
        private DateTimePicker dtpDatadeEmbarque;
        private DateTimePicker dtpPrevisao;
        private Label label11;
        private Label label9;
        private TextBox insSR;
        private TextBox insNR;
        private Label label10;
        private TextBox insStatusdoProcesso;
        private Label label5;
        private TextBox insLI;
        private TextBox insParametrizacao;
        private Label label7;
        private TextBox insCSIOriginal;
        private Label label8;
        private TextBox insPendencia;
        private Label label3;
        private TextBox insTerminal;
        private Label label4;
        private Label label2;
        private TextBox insLPCO;
        private Label Exportador;
        private TextBox insImportador;
        private Label lblPEmbarque;
        private Label lblDataEmbarque;
        private Button btnCancelar;
        private Button btnEditar;
    }
}