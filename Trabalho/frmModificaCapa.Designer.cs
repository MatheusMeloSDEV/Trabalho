namespace Trabalho
{
    partial class FrmModificaCapa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        // Generated code
        #endregion

        private void InitializeComponent()
        {
            label1 = new Label();
            txtMaster = new TextBox();
            label2 = new Label();
            TxtIncoterm = new TextBox();
            label3 = new Label();
            txtContainer = new TextBox();
            label4 = new Label();
            txtMarinha = new TextBox();
            label5 = new Label();
            txtCE = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDTA = new TextBox();
            label8 = new Label();
            cbSigvig = new ComboBox();
            DTPSigvig = new DateTimePicker();
            cbIncotern = new CheckBox();
            ItensAdicionais = new CheckedListBox();
            DTPAverbar = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            DTPLiberarBL = new DateTimePicker();
            label11 = new Label();
            DTPIsencaoMarinha = new DateTimePicker();
            label12 = new Label();
            DTPSisCarga = new DateTimePicker();
            label15 = new Label();
            DTPEntTransporte = new DateTimePicker();
            label16 = new Label();
            DTPICMS = new DateTimePicker();
            label17 = new Label();
            txtTransporte = new TextBox();
            txtDOSSIE = new TextBox();
            label13 = new Label();
            label14 = new Label();
            DTPEntAlfandega = new DateTimePicker();
            Impostos = new CheckedListBox();
            label19 = new Label();
            DTPConferenciaFisica = new DateTimePicker();
            label18 = new Label();
            txtObservacao = new TextBox();
            cbNumerario = new ComboBox();
            btnExportar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtPagoPor = new TextBox();
            label20 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Master:";
            // 
            // txtMaster
            // 
            txtMaster.Location = new Point(64, 6);
            txtMaster.Name = "txtMaster";
            txtMaster.Size = new Size(392, 23);
            txtMaster.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Numerário";
            // 
            // TxtIncoterm
            // 
            TxtIncoterm.Location = new Point(72, 64);
            TxtIncoterm.Name = "TxtIncoterm";
            TxtIncoterm.Size = new Size(221, 23);
            TxtIncoterm.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Incotern:";
            // 
            // txtContainer
            // 
            txtContainer.Location = new Point(80, 35);
            txtContainer.Name = "txtContainer";
            txtContainer.Size = new Size(376, 23);
            txtContainer.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 38);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Container:";
            // 
            // txtMarinha
            // 
            txtMarinha.Location = new Point(72, 151);
            txtMarinha.Name = "txtMarinha";
            txtMarinha.Size = new Size(165, 23);
            txtMarinha.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 14;
            label5.Text = "Marinha:";
            // 
            // txtCE
            // 
            txtCE.Location = new Point(272, 151);
            txtCE.Name = "txtCE";
            txtCE.Size = new Size(184, 23);
            txtCE.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 154);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 12;
            label6.Text = "CE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 183);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Sigvig:";
            // 
            // txtDTA
            // 
            txtDTA.Location = new Point(49, 122);
            txtDTA.Name = "txtDTA";
            txtDTA.Size = new Size(188, 23);
            txtDTA.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 125);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 8;
            label8.Text = "DTA:";
            // 
            // cbSigvig
            // 
            cbSigvig.FormattingEnabled = true;
            cbSigvig.Items.AddRange(new object[] { "Selecionado", "Liberado" });
            cbSigvig.Location = new Point(60, 180);
            cbSigvig.Name = "cbSigvig";
            cbSigvig.Size = new Size(217, 23);
            cbSigvig.TabIndex = 16;
            // 
            // DTPSigvig
            // 
            DTPSigvig.Format = DateTimePickerFormat.Short;
            DTPSigvig.Location = new Point(283, 180);
            DTPSigvig.Name = "DTPSigvig";
            DTPSigvig.Size = new Size(173, 23);
            DTPSigvig.TabIndex = 17;
            // 
            // cbIncotern
            // 
            cbIncotern.AutoSize = true;
            cbIncotern.Location = new Point(306, 66);
            cbIncotern.Name = "cbIncotern";
            cbIncotern.Size = new Size(150, 19);
            cbIncotern.TabIndex = 18;
            cbIncotern.Text = "Documentos de acordo";
            cbIncotern.UseVisualStyleBackColor = true;
            // 
            // ItensAdicionais
            // 
            ItensAdicionais.FormattingEnabled = true;
            ItensAdicionais.Items.AddRange(new object[] { "Tela do Canal", "Lançado", "Consulta SEFAZ", "DAT & LI Deferida", "DANFE", "Armazenagem", "Faturado" });
            ItensAdicionais.Location = new Point(12, 406);
            ItensAdicionais.MultiColumn = true;
            ItensAdicionais.Name = "ItensAdicionais";
            ItensAdicionais.Size = new Size(444, 58);
            ItensAdicionais.TabIndex = 19;
            // 
            // DTPAverbar
            // 
            DTPAverbar.Format = DateTimePickerFormat.Short;
            DTPAverbar.Location = new Point(69, 259);
            DTPAverbar.Name = "DTPAverbar";
            DTPAverbar.Size = new Size(151, 23);
            DTPAverbar.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 263);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 21;
            label9.Text = "Averbar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(226, 263);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 23;
            label10.Text = "Liberar B/L:";
            // 
            // DTPLiberarBL
            // 
            DTPLiberarBL.Format = DateTimePickerFormat.Short;
            DTPLiberarBL.Location = new Point(299, 259);
            DTPLiberarBL.Name = "DTPLiberarBL";
            DTPLiberarBL.Size = new Size(157, 23);
            DTPLiberarBL.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 292);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 25;
            label11.Text = "M.M ou Isenção:";
            // 
            // DTPIsencaoMarinha
            // 
            DTPIsencaoMarinha.Format = DateTimePickerFormat.Short;
            DTPIsencaoMarinha.Location = new Point(113, 288);
            DTPIsencaoMarinha.Name = "DTPIsencaoMarinha";
            DTPIsencaoMarinha.Size = new Size(107, 23);
            DTPIsencaoMarinha.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(226, 292);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 27;
            label12.Text = "SISCarga:";
            // 
            // DTPSisCarga
            // 
            DTPSisCarga.Format = DateTimePickerFormat.Short;
            DTPSisCarga.Location = new Point(288, 288);
            DTPSisCarga.Name = "DTPSisCarga";
            DTPSisCarga.Size = new Size(168, 23);
            DTPSisCarga.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 381);
            label15.Name = "label15";
            label15.Size = new Size(112, 15);
            label15.TabIndex = 31;
            label15.Text = "Ent Para Transporte:";
            // 
            // DTPEntTransporte
            // 
            DTPEntTransporte.Format = DateTimePickerFormat.Short;
            DTPEntTransporte.Location = new Point(130, 377);
            DTPEntTransporte.Name = "DTPEntTransporte";
            DTPEntTransporte.Size = new Size(107, 23);
            DTPEntTransporte.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 321);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 29;
            label16.Text = "ICMS:";
            // 
            // DTPICMS
            // 
            DTPICMS.Format = DateTimePickerFormat.Short;
            DTPICMS.Location = new Point(56, 317);
            DTPICMS.Name = "DTPICMS";
            DTPICMS.Size = new Size(164, 23);
            DTPICMS.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(247, 380);
            label17.Name = "label17";
            label17.Size = new Size(66, 15);
            label17.TabIndex = 36;
            label17.Text = "Transporte:";
            // 
            // txtTransporte
            // 
            txtTransporte.Location = new Point(319, 377);
            txtTransporte.Name = "txtTransporte";
            txtTransporte.Size = new Size(137, 23);
            txtTransporte.TabIndex = 37;
            // 
            // txtDOSSIE
            // 
            txtDOSSIE.Location = new Point(280, 346);
            txtDOSSIE.Name = "txtDOSSIE";
            txtDOSSIE.Size = new Size(176, 23);
            txtDOSSIE.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(226, 350);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 40;
            label13.Text = "DOSSIÊ:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 350);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 39;
            label14.Text = "Ent Alfândega:";
            // 
            // DTPEntAlfandega
            // 
            DTPEntAlfandega.Format = DateTimePickerFormat.Short;
            DTPEntAlfandega.Location = new Point(102, 346);
            DTPEntAlfandega.Name = "DTPEntAlfandega";
            DTPEntAlfandega.Size = new Size(118, 23);
            DTPEntAlfandega.TabIndex = 38;
            // 
            // Impostos
            // 
            Impostos.FormattingEnabled = true;
            Impostos.Items.AddRange(new object[] { "I.I,", "I.P.I.", "PIS/PASEP", "COFINS", "ICMS" });
            Impostos.Location = new Point(12, 211);
            Impostos.MultiColumn = true;
            Impostos.Name = "Impostos";
            Impostos.Size = new Size(444, 40);
            Impostos.TabIndex = 42;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(226, 321);
            label19.Name = "label19";
            label19.Size = new Size(106, 15);
            label19.TabIndex = 44;
            label19.Text = "Conferência Física:";
            // 
            // DTPConferenciaFisica
            // 
            DTPConferenciaFisica.Format = DateTimePickerFormat.Short;
            DTPConferenciaFisica.Location = new Point(338, 317);
            DTPConferenciaFisica.Name = "DTPConferenciaFisica";
            DTPConferenciaFisica.Size = new Size(118, 23);
            DTPConferenciaFisica.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label18.Location = new Point(462, 9);
            label18.Name = "label18";
            label18.Size = new Size(72, 15);
            label18.TabIndex = 45;
            label18.Text = "Observação:";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(462, 27);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(254, 345);
            txtObservacao.TabIndex = 46;
            // 
            // cbNumerario
            // 
            cbNumerario.FormattingEnabled = true;
            cbNumerario.Items.AddRange(new object[] { "Prestação Serviço", "Agência", "Tributos", "Completo", "Complementar" });
            cbNumerario.Location = new Point(82, 93);
            cbNumerario.Name = "cbNumerario";
            cbNumerario.Size = new Size(374, 23);
            cbNumerario.TabIndex = 47;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(462, 378);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(254, 23);
            btnExportar.TabIndex = 48;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(462, 407);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(254, 23);
            btnSalvar.TabIndex = 49;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(462, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(254, 23);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtPagoPor
            // 
            txtPagoPor.Location = new Point(306, 122);
            txtPagoPor.Name = "txtPagoPor";
            txtPagoPor.Size = new Size(150, 23);
            txtPagoPor.TabIndex = 52;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(246, 125);
            label20.Name = "label20";
            label20.Size = new Size(58, 15);
            label20.TabIndex = 51;
            label20.Text = "Pago Por:";
            // 
            // FrmModificaCapa
            // 
            ClientSize = new Size(728, 471);
            Controls.Add(txtPagoPor);
            Controls.Add(label20);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExportar);
            Controls.Add(cbNumerario);
            Controls.Add(txtObservacao);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(DTPConferenciaFisica);
            Controls.Add(Impostos);
            Controls.Add(txtDOSSIE);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(DTPEntAlfandega);
            Controls.Add(txtTransporte);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(DTPEntTransporte);
            Controls.Add(label16);
            Controls.Add(DTPICMS);
            Controls.Add(label12);
            Controls.Add(DTPSisCarga);
            Controls.Add(label11);
            Controls.Add(DTPIsencaoMarinha);
            Controls.Add(label10);
            Controls.Add(DTPLiberarBL);
            Controls.Add(label9);
            Controls.Add(DTPAverbar);
            Controls.Add(ItensAdicionais);
            Controls.Add(cbIncotern);
            Controls.Add(DTPSigvig);
            Controls.Add(cbSigvig);
            Controls.Add(txtMarinha);
            Controls.Add(label5);
            Controls.Add(txtCE);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtDTA);
            Controls.Add(label8);
            Controls.Add(txtContainer);
            Controls.Add(label4);
            Controls.Add(TxtIncoterm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMaster);
            Controls.Add(label1);
            Name = "FrmModificaCapa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar Capa";
            Load += FrmModificaCapa_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private TextBox txtMaster;
        private Label label2;
        private TextBox TxtIncoterm;
        private Label label3;
        private TextBox txtContainer;
        private Label label4;
        private TextBox txtMarinha;
        private Label label5;
        private TextBox txtCE;
        private Label label6;
        private Label label7;
        private TextBox txtDTA;
        private Label label8;
        private ComboBox cbSigvig;
        private DateTimePicker DTPSigvig;
        private CheckBox cbIncotern;
        private CheckedListBox ItensAdicionais;
        private DateTimePicker DTPAverbar;
        private Label label9;
        private Label label10;
        private DateTimePicker DTPLiberarBL;
        private Label label11;
        private DateTimePicker DTPIsencaoMarinha;
        private Label label12;
        private DateTimePicker DTPSisCarga;
        private Label label15;
        private DateTimePicker DTPEntTransporte;
        private Label label16;
        private DateTimePicker DTPICMS;
        private Label label17;
        private TextBox txtTransporte;
        private TextBox txtDOSSIE;
        private Label label13;
        private Label label14;
        private DateTimePicker DTPEntAlfandega;
        private CheckedListBox Impostos;
        private Label label19;
        private DateTimePicker DTPConferenciaFisica;
        private Label label18;
        private TextBox txtObservacao;
        private ComboBox cbNumerario;
        private Button btnExportar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtPagoPor;
        private Label label20;
    }
}