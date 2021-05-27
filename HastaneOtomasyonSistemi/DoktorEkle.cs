using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HastaneOtomasyonSistemi
{
    public partial class DoktorEkle : Form
    {
        string kontrolText;
        public DoktorEkle(string kontrolText)
        {
            this.kontrolText = kontrolText;
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtIsim.Text != "" || txtYas.Text != "" || cmbPoliklinik.Text != ""){
                connection.Open();

                SqlCommand command = new SqlCommand("insert into tbl_doktorlar(adSoyad,poliklinik,yas) values (@a1,@a2,@a3)", connection);
                command.Parameters.AddWithValue("@a1", txtIsim.Text);
                command.Parameters.AddWithValue("@a3", txtYas.Text);
                command.Parameters.AddWithValue("@a2", cmbPoliklinik.Text);


                command.ExecuteNonQuery();

                MessageBox.Show("Doktor Başarıyla Eklendi");
                
                connection.Close();

                this.Close();
            }
            
        }
    }
}
