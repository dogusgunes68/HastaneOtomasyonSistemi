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
    public partial class RandevuAL : Form

    {
        string adSoyad = null;
        string tcKimlikNo = null;
        Boolean randevuMevcutMu = false;
        public RandevuAL(string adSoyad,string tcKimlikNo)
        {
            this.adSoyad = adSoyad;
            this.tcKimlikNo = tcKimlikNo;
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void RandevuAL_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = adSoyad;
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("select*from tbl_doktorlar where poliklinik = @p1", connection);
            command.Parameters.AddWithValue("@p1",cmbPoliklinik.SelectedItem.ToString());

            SqlDataReader reader = command.ExecuteReader();

            cmbDoktor.Items.Clear();

            while (reader.Read())
            {
                cmbDoktor.Items.Add(reader[1].ToString());
               
            }

            connection.Close();
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (!randevuMevcutMu) { 
            connection.Open();

            SqlCommand command = new SqlCommand("insert into tbl_randevular(tcKimlikNo,adSoyad,poliklinik,doktor,gun,saat) values (@a1,@a2,@a3,@a4,@a5,@a6)", connection);
            command.Parameters.AddWithValue("@a1", tcKimlikNo);
            command.Parameters.AddWithValue("@a2", adSoyad);
            command.Parameters.AddWithValue("@a3", cmbPoliklinik.SelectedItem.ToString());
            command.Parameters.AddWithValue("@a4", cmbDoktor.SelectedItem.ToString());
            command.Parameters.AddWithValue("@a5", cmbGun.SelectedItem.ToString());
            command.Parameters.AddWithValue("@a6", cmbSaat.SelectedItem.ToString());

            command.ExecuteNonQuery();

            MessageBox.Show("Randevu Başarıyla oluşturuldu");
            connection.Close();

            this.Close();
            }
            else
            {
                MessageBox.Show("Randevu Zaten Mevcut");
            }
        }

        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] saatler = {"09:00", "10:00", "11:00", "12:00", "14:00", "15:00", "16:00"};
            cmbSaat.Items.Clear();
            cmbSaat.Items.AddRange(saatler);
       

            connection.Open();
            SqlCommand command = new SqlCommand("select doktor,gun,saat,tcKimlikNo from tbl_randevular where tcKimlikNo=@a1", connection);
            command.Parameters.AddWithValue("@a1", tcKimlikNo);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(cmbDoktor.Text.Equals(reader[0].ToString()) && tcKimlikNo.Equals(reader[3].ToString()))
                    {
                    randevuMevcutMu = true;
                }

                if (cmbDoktor.Text.Equals(reader[0].ToString()) && cmbGun.Text.Equals(reader[1].ToString()))
                {
                   
                    foreach(string item in saatler)
                    {
                        if (item.Equals(reader[2]))
                        {
                            cmbSaat.Items.Remove(reader[2].ToString());
                        }
                    }
                   
                   
                }

           
            }

            connection.Close();
        }

        private void RandevuAL_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
