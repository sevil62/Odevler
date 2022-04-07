namespace WFA.TahminOyunu
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 16;
            this.lstSonuc.Items.AddRange(new object[] {
            "Tahmin Edilen: 5 Seviye: 1",
            "Tahmin Edilen:6 Seviye1",
            "Tahmin Eden: 8  Tutulan: 8 Seviye: 2"});
            this.lstSonuc.Location = new System.Drawing.Point(549, 98);
            this.lstSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(545, 420);
            this.lstSonuc.TabIndex = 14;
            // 
            // lblSeviye
            // 
            this.lblSeviye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviye.Location = new System.Drawing.Point(257, 318);
            this.lblSeviye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(199, 184);
            this.lblSeviye.TabIndex = 12;
            this.lblSeviye.Text = "1";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahmin
            // 
            this.lblTahmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(23, 318);
            this.lblTahmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(199, 184);
            this.lblTahmin.TabIndex = 13;
            this.lblTahmin.Text = "5";
            this.lblTahmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUyarı
            // 
            this.lblUyarı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUyarı.Location = new System.Drawing.Point(85, 173);
            this.lblUyarı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(319, 89);
            this.lblUyarı.TabIndex = 11;
            this.lblUyarı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(178, 119);
            this.btnTahmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(133, 34);
            this.btnTahmin.TabIndex = 10;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(304, 64);
            this.txtTahmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(132, 34);
            this.txtTahmin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(319, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seviye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tahmin Hakkı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tahmin Edilen Sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 608);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

