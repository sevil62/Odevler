namespace WFA.CarpimTablosu
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
            this.lstCarpimTablosu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCarpimTablosu
            // 
            this.lstCarpimTablosu.FormattingEnabled = true;
            this.lstCarpimTablosu.ItemHeight = 16;
            this.lstCarpimTablosu.Location = new System.Drawing.Point(101, 51);
            this.lstCarpimTablosu.Name = "lstCarpimTablosu";
            this.lstCarpimTablosu.Size = new System.Drawing.Size(596, 708);
            this.lstCarpimTablosu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 772);
            this.Controls.Add(this.lstCarpimTablosu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarpimTablosu;
    }
}

