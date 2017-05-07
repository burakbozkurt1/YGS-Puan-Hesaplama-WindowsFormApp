namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.sinavCombobox = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matematikDogruTextField = new System.Windows.Forms.TextBox();
            this.fenDogruTextField = new System.Windows.Forms.TextBox();
            this.turkceDogruTextField = new System.Windows.Forms.TextBox();
            this.sosyalDogruTextField = new System.Windows.Forms.TextBox();
            this.matematikYanlisTextField = new System.Windows.Forms.TextBox();
            this.fenYanlisTextField = new System.Windows.Forms.TextBox();
            this.turkceYanlisTextField = new System.Windows.Forms.TextBox();
            this.sosyalYanlisTextField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.YGS1SonucLabel = new System.Windows.Forms.Label();
            this.YGS2SonucLabel = new System.Windows.Forms.Label();
            this.YGS3SonucLabel = new System.Windows.Forms.Label();
            this.YGS4SonucLabel = new System.Windows.Forms.Label();
            this.YGS5SonucLabel = new System.Windows.Forms.Label();
            this.YGS6SonucLabel = new System.Windows.Forms.Label();
            this.txtMF4mat1 = new System.Windows.Forms.TextBox();
            this.txtMF4mat2 = new System.Windows.Forms.TextBox();
            this.txtMF4Fen1 = new System.Windows.Forms.TextBox();
            this.txtMF4fen2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sinavCombobox
            // 
            this.sinavCombobox.FormattingEnabled = true;
            this.sinavCombobox.Items.AddRange(new object[] {
            "YGS",
            "LYS-MF4",
            "LYS-MF3",
            "LYS-MF2",
            "LYS-MF1"});
            this.sinavCombobox.Location = new System.Drawing.Point(363, 49);
            this.sinavCombobox.Name = "sinavCombobox";
            this.sinavCombobox.Size = new System.Drawing.Size(256, 24);
            this.sinavCombobox.TabIndex = 0;
            this.sinavCombobox.Text = "Sınav türünü seçiniz..";
            this.sinavCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(345, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Sonucunu hesaplamak istediğiniz sınav türünü seçin :";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Location = new System.Drawing.Point(278, 366);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(170, 43);
            this.hesaplaButton.TabIndex = 2;
            this.hesaplaButton.Text = "HESAPLA";
            this.hesaplaButton.UseVisualStyleBackColor = true;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matematik";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fen";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Türkçe";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sosyal";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğru";
            this.label4.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yanlış";
            this.label7.Visible = false;
            // 
            // matematikDogruTextField
            // 
            this.matematikDogruTextField.Location = new System.Drawing.Point(186, 131);
            this.matematikDogruTextField.Name = "matematikDogruTextField";
            this.matematikDogruTextField.Size = new System.Drawing.Size(44, 22);
            this.matematikDogruTextField.TabIndex = 11;
            this.matematikDogruTextField.Visible = false;
            // 
            // fenDogruTextField
            // 
            this.fenDogruTextField.Location = new System.Drawing.Point(186, 169);
            this.fenDogruTextField.Name = "fenDogruTextField";
            this.fenDogruTextField.Size = new System.Drawing.Size(44, 22);
            this.fenDogruTextField.TabIndex = 12;
            this.fenDogruTextField.Visible = false;
            // 
            // turkceDogruTextField
            // 
            this.turkceDogruTextField.Location = new System.Drawing.Point(186, 213);
            this.turkceDogruTextField.Name = "turkceDogruTextField";
            this.turkceDogruTextField.Size = new System.Drawing.Size(44, 22);
            this.turkceDogruTextField.TabIndex = 13;
            this.turkceDogruTextField.Visible = false;
            // 
            // sosyalDogruTextField
            // 
            this.sosyalDogruTextField.Location = new System.Drawing.Point(186, 257);
            this.sosyalDogruTextField.Name = "sosyalDogruTextField";
            this.sosyalDogruTextField.Size = new System.Drawing.Size(44, 22);
            this.sosyalDogruTextField.TabIndex = 14;
            this.sosyalDogruTextField.Visible = false;
            // 
            // matematikYanlisTextField
            // 
            this.matematikYanlisTextField.Location = new System.Drawing.Point(278, 133);
            this.matematikYanlisTextField.Name = "matematikYanlisTextField";
            this.matematikYanlisTextField.Size = new System.Drawing.Size(44, 22);
            this.matematikYanlisTextField.TabIndex = 15;
            this.matematikYanlisTextField.Visible = false;
            // 
            // fenYanlisTextField
            // 
            this.fenYanlisTextField.Location = new System.Drawing.Point(278, 169);
            this.fenYanlisTextField.Name = "fenYanlisTextField";
            this.fenYanlisTextField.Size = new System.Drawing.Size(44, 22);
            this.fenYanlisTextField.TabIndex = 16;
            this.fenYanlisTextField.Visible = false;
            // 
            // turkceYanlisTextField
            // 
            this.turkceYanlisTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkceYanlisTextField.Location = new System.Drawing.Point(279, 213);
            this.turkceYanlisTextField.Name = "turkceYanlisTextField";
            this.turkceYanlisTextField.Size = new System.Drawing.Size(44, 22);
            this.turkceYanlisTextField.TabIndex = 17;
            this.turkceYanlisTextField.Visible = false;
            // 
            // sosyalYanlisTextField
            // 
            this.sosyalYanlisTextField.Location = new System.Drawing.Point(278, 257);
            this.sosyalYanlisTextField.Name = "sosyalYanlisTextField";
            this.sosyalYanlisTextField.Size = new System.Drawing.Size(44, 22);
            this.sosyalYanlisTextField.TabIndex = 18;
            this.sosyalYanlisTextField.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sonuç :";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(547, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "YGS-1";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(547, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "YGS-4";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(547, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "YGS-3";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(547, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "YGS-6";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(547, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "YGS-5";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(547, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "YGS-2";
            this.label13.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(482, 366);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(170, 43);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "SIFIRLA";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // YGS1SonucLabel
            // 
            this.YGS1SonucLabel.AutoSize = true;
            this.YGS1SonucLabel.Location = new System.Drawing.Point(609, 138);
            this.YGS1SonucLabel.Name = "YGS1SonucLabel";
            this.YGS1SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS1SonucLabel.TabIndex = 27;
            this.YGS1SonucLabel.Text = ".";
            // 
            // YGS2SonucLabel
            // 
            this.YGS2SonucLabel.AutoSize = true;
            this.YGS2SonucLabel.Location = new System.Drawing.Point(609, 174);
            this.YGS2SonucLabel.Name = "YGS2SonucLabel";
            this.YGS2SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS2SonucLabel.TabIndex = 29;
            this.YGS2SonucLabel.Text = ".";
            // 
            // YGS3SonucLabel
            // 
            this.YGS3SonucLabel.AutoSize = true;
            this.YGS3SonucLabel.Location = new System.Drawing.Point(609, 216);
            this.YGS3SonucLabel.Name = "YGS3SonucLabel";
            this.YGS3SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS3SonucLabel.TabIndex = 30;
            this.YGS3SonucLabel.Text = ".";
            // 
            // YGS4SonucLabel
            // 
            this.YGS4SonucLabel.AutoSize = true;
            this.YGS4SonucLabel.Location = new System.Drawing.Point(609, 248);
            this.YGS4SonucLabel.Name = "YGS4SonucLabel";
            this.YGS4SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS4SonucLabel.TabIndex = 31;
            this.YGS4SonucLabel.Text = ".";
            // 
            // YGS5SonucLabel
            // 
            this.YGS5SonucLabel.AutoSize = true;
            this.YGS5SonucLabel.Location = new System.Drawing.Point(609, 284);
            this.YGS5SonucLabel.Name = "YGS5SonucLabel";
            this.YGS5SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS5SonucLabel.TabIndex = 32;
            this.YGS5SonucLabel.Text = ".";
            // 
            // YGS6SonucLabel
            // 
            this.YGS6SonucLabel.AutoSize = true;
            this.YGS6SonucLabel.Location = new System.Drawing.Point(609, 318);
            this.YGS6SonucLabel.Name = "YGS6SonucLabel";
            this.YGS6SonucLabel.Size = new System.Drawing.Size(12, 17);
            this.YGS6SonucLabel.TabIndex = 33;
            this.YGS6SonucLabel.Text = ".";
            // 
            // txtMF4mat1
            // 
            this.txtMF4mat1.Location = new System.Drawing.Point(183, 131);
            this.txtMF4mat1.Name = "txtMF4mat1";
            this.txtMF4mat1.Size = new System.Drawing.Size(47, 22);
            this.txtMF4mat1.TabIndex = 34;
            this.txtMF4mat1.Visible = false;
            // 
            // txtMF4mat2
            // 
            this.txtMF4mat2.Location = new System.Drawing.Point(275, 133);
            this.txtMF4mat2.Name = "txtMF4mat2";
            this.txtMF4mat2.Size = new System.Drawing.Size(47, 22);
            this.txtMF4mat2.TabIndex = 35;
            this.txtMF4mat2.Visible = false;
            // 
            // txtMF4Fen1
            // 
            this.txtMF4Fen1.Location = new System.Drawing.Point(183, 169);
            this.txtMF4Fen1.Name = "txtMF4Fen1";
            this.txtMF4Fen1.Size = new System.Drawing.Size(47, 22);
            this.txtMF4Fen1.TabIndex = 36;
            this.txtMF4Fen1.Visible = false;
            // 
            // txtMF4fen2
            // 
            this.txtMF4fen2.Location = new System.Drawing.Point(275, 169);
            this.txtMF4fen2.Name = "txtMF4fen2";
            this.txtMF4fen2.Size = new System.Drawing.Size(47, 22);
            this.txtMF4fen2.TabIndex = 37;
            this.txtMF4fen2.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(609, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 38;
            this.label14.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 439);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMF4fen2);
            this.Controls.Add(this.txtMF4Fen1);
            this.Controls.Add(this.txtMF4mat2);
            this.Controls.Add(this.txtMF4mat1);
            this.Controls.Add(this.YGS6SonucLabel);
            this.Controls.Add(this.YGS5SonucLabel);
            this.Controls.Add(this.YGS4SonucLabel);
            this.Controls.Add(this.YGS3SonucLabel);
            this.Controls.Add(this.YGS2SonucLabel);
            this.Controls.Add(this.YGS1SonucLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sosyalYanlisTextField);
            this.Controls.Add(this.turkceYanlisTextField);
            this.Controls.Add(this.fenYanlisTextField);
            this.Controls.Add(this.matematikYanlisTextField);
            this.Controls.Add(this.sosyalDogruTextField);
            this.Controls.Add(this.turkceDogruTextField);
            this.Controls.Add(this.fenDogruTextField);
            this.Controls.Add(this.matematikDogruTextField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.sinavCombobox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "YGS LYS HESAPLAYICI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sinavCombobox;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox matematikDogruTextField;
        private System.Windows.Forms.TextBox fenDogruTextField;
        private System.Windows.Forms.TextBox turkceDogruTextField;
        private System.Windows.Forms.TextBox sosyalDogruTextField;
        private System.Windows.Forms.TextBox matematikYanlisTextField;
        private System.Windows.Forms.TextBox fenYanlisTextField;
        private System.Windows.Forms.TextBox turkceYanlisTextField;
        private System.Windows.Forms.TextBox sosyalYanlisTextField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label YGS1SonucLabel;
        private System.Windows.Forms.Label YGS2SonucLabel;
        private System.Windows.Forms.Label YGS3SonucLabel;
        private System.Windows.Forms.Label YGS4SonucLabel;
        private System.Windows.Forms.Label YGS5SonucLabel;
        private System.Windows.Forms.Label YGS6SonucLabel;
        private System.Windows.Forms.TextBox txtMF4mat1;
        private System.Windows.Forms.TextBox txtMF4mat2;
        private System.Windows.Forms.TextBox txtMF4Fen1;
        private System.Windows.Forms.TextBox txtMF4fen2;
        private System.Windows.Forms.Label label14;
    }
}

