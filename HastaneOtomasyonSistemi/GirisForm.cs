using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonSistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");


        private void button1_Click(object sender, EventArgs e)
        {

            girisFonk(kontrolLabel1.Text,txtGirisTcKimlikNo.Text,txtGirisSifre.Text);
            
        }

        private void girisFonk(string kontrolText,string tc,string sifre)
        {
           
            connection.Open();

            SqlCommand command = new SqlCommand("select*from tbl_kullanici where yetki = @a", connection);
            command.Parameters.AddWithValue("@a", kontrolText);

            string tcKimlikNo = null;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[2].ToString().Equals(tc))
                {
                    tcKimlikNo = reader[2].ToString();
                }

            }
            connection.Close();

            connection.Open();

            if (tcKimlikNo != null)
            {

                SqlCommand command2 = new SqlCommand("select*from tbl_kullanici where tcKimlikNo = @a1", connection);
                command2.Parameters.AddWithValue("@a1", tcKimlikNo);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    if (reader2[5].ToString().Equals(sifre))
                    {
                        AnaSayfa anaSayfa = new AnaSayfa(reader2[1].ToString(), reader2[2].ToString(), kontrolText);
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifre yanlış");
                    }
                }
            }
            else
            {
                MessageBox.Show("TC yanlış");
            }

            connection.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtOl = new KayıtOl(kontrolLabel1.Text);
            kayıtOl.ShowDialog();
        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            girisFonk(kontrolLabel2.Text,txtTc.Text,txtSifre.Text);
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KayıtOl kayıt = new KayıtOl(kontrolLabel1.Text);
            kayıt.Show();
        }
    }
}
