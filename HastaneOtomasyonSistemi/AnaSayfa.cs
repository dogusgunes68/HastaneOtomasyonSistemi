using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HastaneOtomasyonSistemi
{
    public partial class AnaSayfa : Form
    {

        string adSoyad = null;
        string tcKimlikNo = null;
        string kontrolText = null;

        public AnaSayfa(string adSoyad,string tcKimlikNo,string kontrolText)
        {
            this.adSoyad = adSoyad;
            this.tcKimlikNo = tcKimlikNo;
            this.kontrolText = kontrolText;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuAL randevuAl = new RandevuAL(adSoyad,tcKimlikNo);
            randevuAl.Show();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = adSoyad;
            label1.Text = kontrolText.ToUpper();

            if(kontrolText == "hasta")
            {
                btnRandevuAl.Visible = true;
                btnRandevularım.Visible = true;
            }else if (kontrolText == "admin")
            {
                btnRandevuAl.Visible = false;
                btnRandevularım.Visible = false;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevularım randevularım = new Randevularım(tcKimlikNo);
            randevularım.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPoliklinikler_Click(object sender, EventArgs e)
        {
            Poliklinikler poliklinikler = new Poliklinikler(kontrolText);
            poliklinikler.Show();
        }
    }
}
