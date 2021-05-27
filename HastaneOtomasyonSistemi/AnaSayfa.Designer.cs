
namespace HastaneOtomasyonSistemi
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnRandevularım = new System.Windows.Forms.Button();
            this.btnPoliklinikler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(389, 121);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(306, 79);
            this.btnRandevuAl.TabIndex = 0;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandevularım
            // 
            this.btnRandevularım.Location = new System.Drawing.Point(389, 327);
            this.btnRandevularım.Name = "btnRandevularım";
            this.btnRandevularım.Size = new System.Drawing.Size(306, 79);
            this.btnRandevularım.TabIndex = 1;
            this.btnRandevularım.Text = "Randevularım";
            this.btnRandevularım.UseVisualStyleBackColor = true;
            this.btnRandevularım.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPoliklinikler
            // 
            this.btnPoliklinikler.Location = new System.Drawing.Point(389, 224);
            this.btnPoliklinikler.Name = "btnPoliklinikler";
            this.btnPoliklinikler.Size = new System.Drawing.Size(306, 79);
            this.btnPoliklinikler.TabIndex = 2;
            this.btnPoliklinikler.Text = "Poliklinikler";
            this.btnPoliklinikler.UseVisualStyleBackColor = true;
            this.btnPoliklinikler.Click += new System.EventHandler(this.btnPoliklinikler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdSoyad.Location = new System.Drawing.Point(501, 24);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(134, 30);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(699, 24);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 29);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(406, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPoliklinikler);
            this.Controls.Add(this.btnRandevularım);
            this.Controls.Add(this.btnRandevuAl);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnRandevularım;
        private System.Windows.Forms.Button btnPoliklinikler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
    }
}