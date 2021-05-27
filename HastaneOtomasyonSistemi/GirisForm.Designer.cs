
namespace HastaneOtomasyonSistemi
{
    partial class GirisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGirisTcKimlikNo = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.kontrolLabel1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kontrolLabel2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-101, -63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-92, -23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vladimir Script", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(86, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane Otomasyon Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre";
            // 
            // txtGirisTcKimlikNo
            // 
            this.txtGirisTcKimlikNo.Location = new System.Drawing.Point(134, 37);
            this.txtGirisTcKimlikNo.MaxLength = 11;
            this.txtGirisTcKimlikNo.Name = "txtGirisTcKimlikNo";
            this.txtGirisTcKimlikNo.Size = new System.Drawing.Size(267, 27);
            this.txtGirisTcKimlikNo.TabIndex = 6;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtGirisSifre.Location = new System.Drawing.Point(134, 90);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '*';
            this.txtGirisSifre.Size = new System.Drawing.Size(267, 27);
            this.txtGirisSifre.TabIndex = 7;
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(134, 144);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(110, 39);
            this.btnHastaGiris.TabIndex = 8;
            this.btnHastaGiris.Text = "Giriş Yap";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(65, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 265);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnKaydol);
            this.tabPage1.Controls.Add(this.kontrolLabel1);
            this.tabPage1.Controls.Add(this.txtGirisSifre);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnHastaGiris);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtGirisTcKimlikNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Girişi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(298, 144);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(103, 39);
            this.btnKaydol.TabIndex = 16;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // kontrolLabel1
            // 
            this.kontrolLabel1.AutoSize = true;
            this.kontrolLabel1.Location = new System.Drawing.Point(36, 153);
            this.kontrolLabel1.Name = "kontrolLabel1";
            this.kontrolLabel1.Size = new System.Drawing.Size(44, 20);
            this.kontrolLabel1.TabIndex = 10;
            this.kontrolLabel1.Text = "hasta";
            this.kontrolLabel1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kontrolLabel2);
            this.tabPage2.Controls.Add(this.txtSifre);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnAdminGiris);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtTc);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Girişi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kontrolLabel2
            // 
            this.kontrolLabel2.AutoSize = true;
            this.kontrolLabel2.Location = new System.Drawing.Point(52, 156);
            this.kontrolLabel2.Name = "kontrolLabel2";
            this.kontrolLabel2.Size = new System.Drawing.Size(51, 20);
            this.kontrolLabel2.TabIndex = 16;
            this.kontrolLabel2.Text = "admin";
            this.kontrolLabel2.Visible = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSifre.Location = new System.Drawing.Point(149, 93);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(267, 27);
            this.txtSifre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "TC Kimlik No";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(149, 147);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(110, 39);
            this.btnAdminGiris.TabIndex = 14;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Şifre";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(149, 40);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(267, 27);
            this.txtTc.TabIndex = 12;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 478);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGirisTcKimlikNo;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label kontrolLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label kontrolLabel2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnKaydol;
    }
}

