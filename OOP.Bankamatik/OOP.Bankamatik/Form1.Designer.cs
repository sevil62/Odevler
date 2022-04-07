namespace OOP.Bankamatik
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
            this.lstSonuc2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlisveris = new System.Windows.Forms.Button();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.chkCikoloata = new System.Windows.Forms.CheckBox();
            this.chkCay = new System.Windows.Forms.CheckBox();
            this.chkYumurta = new System.Windows.Forms.CheckBox();
            this.chkEkmek = new System.Windows.Forms.CheckBox();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.nudParaYatir = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.nudParaCek = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSonuc2
            // 
            this.lstSonuc2.FormattingEnabled = true;
            this.lstSonuc2.ItemHeight = 16;
            this.lstSonuc2.Items.AddRange(new object[] {
            "Yumurta(10\'lu) Ekmek (4TL) => 14 TL"});
            this.lstSonuc2.Location = new System.Drawing.Point(863, 491);
            this.lstSonuc2.Margin = new System.Windows.Forms.Padding(4);
            this.lstSonuc2.Name = "lstSonuc2";
            this.lstSonuc2.Size = new System.Drawing.Size(445, 212);
            this.lstSonuc2.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblToplam);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnAlisveris);
            this.groupBox3.Controls.Add(this.chkPeynir);
            this.groupBox3.Controls.Add(this.chkCikoloata);
            this.groupBox3.Controls.Add(this.chkCay);
            this.groupBox3.Controls.Add(this.chkYumurta);
            this.groupBox3.Controls.Add(this.chkEkmek);
            this.groupBox3.Location = new System.Drawing.Point(863, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(447, 399);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alışveriş Listesi";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(147, 252);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(87, 29);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "0.00TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toplam: ";
            // 
            // btnAlisveris
            // 
            this.btnAlisveris.Location = new System.Drawing.Point(27, 320);
            this.btnAlisveris.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlisveris.Name = "btnAlisveris";
            this.btnAlisveris.Size = new System.Drawing.Size(328, 52);
            this.btnAlisveris.TabIndex = 1;
            this.btnAlisveris.Text = "Alışverişi Tamamla";
            this.btnAlisveris.UseVisualStyleBackColor = true;
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(27, 203);
            this.chkPeynir.Margin = new System.Windows.Forms.Padding(4);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(111, 20);
            this.chkPeynir.TabIndex = 0;
            this.chkPeynir.Text = "Peynir (45 TL)";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // chkCikoloata
            // 
            this.chkCikoloata.AutoSize = true;
            this.chkCikoloata.Location = new System.Drawing.Point(27, 164);
            this.chkCikoloata.Margin = new System.Windows.Forms.Padding(4);
            this.chkCikoloata.Name = "chkCikoloata";
            this.chkCikoloata.Size = new System.Drawing.Size(119, 20);
            this.chkCikoloata.TabIndex = 0;
            this.chkCikoloata.Text = "Çikolata (30TL)";
            this.chkCikoloata.UseVisualStyleBackColor = true;
            // 
            // chkCay
            // 
            this.chkCay.AutoSize = true;
            this.chkCay.Location = new System.Drawing.Point(27, 121);
            this.chkCay.Margin = new System.Windows.Forms.Padding(4);
            this.chkCay.Name = "chkCay";
            this.chkCay.Size = new System.Drawing.Size(122, 20);
            this.chkCay.TabIndex = 0;
            this.chkCay.Text = "Çay (1 kg 35TL)";
            this.chkCay.UseVisualStyleBackColor = true;
            // 
            // chkYumurta
            // 
            this.chkYumurta.AutoSize = true;
            this.chkYumurta.Location = new System.Drawing.Point(27, 78);
            this.chkYumurta.Margin = new System.Windows.Forms.Padding(4);
            this.chkYumurta.Name = "chkYumurta";
            this.chkYumurta.Size = new System.Drawing.Size(149, 20);
            this.chkYumurta.TabIndex = 0;
            this.chkYumurta.Text = "Yumurta (10\'lu 20TL)";
            this.chkYumurta.UseVisualStyleBackColor = true;
            // 
            // chkEkmek
            // 
            this.chkEkmek.AutoSize = true;
            this.chkEkmek.Location = new System.Drawing.Point(27, 38);
            this.chkEkmek.Margin = new System.Windows.Forms.Padding(4);
            this.chkEkmek.Name = "chkEkmek";
            this.chkEkmek.Size = new System.Drawing.Size(108, 20);
            this.chkEkmek.TabIndex = 0;
            this.chkEkmek.Text = "Ekmek (4 TL)";
            this.chkEkmek.UseVisualStyleBackColor = true;
            // 
            // lstSonuc
            // 
            this.lstSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 29;
            this.lstSonuc.Items.AddRange(new object[] {
            "Para çek: 5 TL ==> bakiye: 495",
            "Para yatır: 5 TL ==> bakiye: 500"});
            this.lstSonuc.Location = new System.Drawing.Point(68, 391);
            this.lstSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(621, 207);
            this.lstSonuc.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnParaYatir);
            this.groupBox2.Controls.Add(this.nudParaYatir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(387, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(304, 155);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Yatır";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(115, 87);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(160, 38);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // nudParaYatir
            // 
            this.nudParaYatir.Location = new System.Drawing.Point(115, 48);
            this.nudParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.nudParaYatir.Name = "nudParaYatir";
            this.nudParaYatir.Size = new System.Drawing.Size(160, 30);
            this.nudParaYatir.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Controls.Add(this.nudParaCek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(68, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 155);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çek";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(107, 89);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(160, 38);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // nudParaCek
            // 
            this.nudParaCek.Location = new System.Drawing.Point(107, 48);
            this.nudParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.nudParaCek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudParaCek.Name = "nudParaCek";
            this.nudParaCek.Size = new System.Drawing.Size(160, 30);
            this.nudParaCek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktar:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(68, 85);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(622, 124);
            this.lblBakiye.TabIndex = 14;
            this.lblBakiye.Text = "0.00 TL";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(297, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bakiye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 747);
            this.Controls.Add(this.lstSonuc2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaYatir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParaCek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlisveris;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox chkCikoloata;
        private System.Windows.Forms.CheckBox chkCay;
        private System.Windows.Forms.CheckBox chkYumurta;
        private System.Windows.Forms.CheckBox chkEkmek;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.NumericUpDown nudParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.NumericUpDown nudParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label1;
    }
}

