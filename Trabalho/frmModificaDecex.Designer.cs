﻿namespace Trabalho
{
    partial class frmModificaDecex
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
            button2 = new Button();
            bsModificaDecex = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsModificaDecex).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // bsModificaDecex
            // 
            bsModificaDecex.DataSource = typeof(CLUSA.Decex);
            // 
            // frmModificaDecex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Name = "frmModificaDecex";
            Text = "frmModificaDecex";
            Load += frmModificaDecex_Load;
            ((System.ComponentModel.ISupportInitialize)bsModificaDecex).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private BindingSource bsModificaDecex;
    }
}