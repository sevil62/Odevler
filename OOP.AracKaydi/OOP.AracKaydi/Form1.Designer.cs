namespace OOP.AracKaydi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmMarka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmYakit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmVites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRenk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelYili = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenk = new System.Windows.Forms.Button();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMarka,
            this.clmModel,
            this.clmYakit,
            this.clmVites,
            this.clmRenk,
            this.clmModelYili});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(425, 37);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 515);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmMarka
            // 
            this.clmMarka.Text = "Marka";
            this.clmMarka.Width = 78;
            // 
            // clmModel
            // 
            this.clmModel.Text = "Model";
            this.clmModel.Width = 75;
            // 
            // clmYakit
            // 
            this.clmYakit.Text = "Yakit Tipi";
            this.clmYakit.Width = 79;
            // 
            // clmVites
            // 
            this.clmVites.Text = "Vites Tipi";
            this.clmVites.Width = 78;
            // 
            // clmRenk
            // 
            this.clmRenk.Text = "Renk";
            this.clmRenk.Width = 70;
            // 
            // clmModelYili
            // 
            this.clmModelYili.Text = "Model Yili";
            this.clmModelYili.Width = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenk);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbVites);
            this.groupBox1.Controls.Add(this.cmbYakit);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(339, 515);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arac Bilgisi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(73, 462);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 32);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Listeye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 411);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cmbVites
            // 
            this.cmbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Items.AddRange(new object[] {
            "Otomatik",
            "Manuel"});
            this.cmbVites.Location = new System.Drawing.Point(7, 257);
            this.cmbVites.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(239, 26);
            this.cmbVites.TabIndex = 1;
            // 
            // cmbYakit
            // 
            this.cmbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik"});
            this.cmbYakit.Location = new System.Drawing.Point(8, 190);
            this.cmbYakit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(239, 26);
            this.cmbYakit.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(7, 119);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(239, 26);
            this.cmbModel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yakit Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model Secin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Renk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model Yili:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Secin:";
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(7, 343);
            this.btnRenk.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(240, 32);
            this.btnRenk.TabIndex = 4;
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // cmbMarka
            // 
            this.cmbMarka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Renault",
            "Alfa Romeo",
            "Ferrari",
            "Porsche",
            "Tesla "});
            this.cmbMarka.Location = new System.Drawing.Point(8, 53);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(239, 26);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 664);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmMarka;
        private System.Windows.Forms.ColumnHeader clmModel;
        private System.Windows.Forms.ColumnHeader clmYakit;
        private System.Windows.Forms.ColumnHeader clmVites;
        private System.Windows.Forms.ColumnHeader clmRenk;
        private System.Windows.Forms.ColumnHeader clmModelYili;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.ComboBox cmbMarka;
    }
}

