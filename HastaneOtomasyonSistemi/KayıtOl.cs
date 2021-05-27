using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonSistemi
{
    public partial class KayıtOl : Form
    {
        string kontrolText = null;
        public KayıtOl(string kontrolText)
        {
            this.kontrolText = kontrolText;
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Equals(txtSifreYeniden.Text)) { 
            connection.Open();

            SqlCommand command = new SqlCommand("insert into tbl_kullanici (isimSoyisim,tcKimlikNo,dogumTarihi,telefonNo,sifre,yetki) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            command.Parameters.AddWithValue("@p2", txtTcKimlikNo.Text);
            command.Parameters.AddWithValue("@p3", txtDogumTarihi.Text);
            command.Parameters.AddWithValue("@p4", txtTelefonNo.Text);
            command.Parameters.AddWithValue("@p5", txtSifre.Text);
            command.Parameters.AddWithValue("@p6", kontrolText);

             command.ExecuteNonQuery();
             lblKontrol.Visible = true;

            connection.Close();

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }

        }

      
    }
}
