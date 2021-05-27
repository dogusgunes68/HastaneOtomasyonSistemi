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
    public partial class Randevularım : Form
    {
        string tcKimlikNo = null;
      
        public Randevularım(string tcKimlikNo)
        {
            this.tcKimlikNo = tcKimlikNo;
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        private void Randevularım_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where tcKimlikNo=@a1",connection);
            da.SelectCommand.Parameters.AddWithValue("@a1", tcKimlikNo);

            da.Fill(dt);
            if (dt.Rows.Count != 0) {
                
                dataGridView1.Visible = true;
                lblMessage.Visible = false;
            }else
            {
                dataGridView1.Visible = false;
                lblMessage.Visible = true;
            }

            dataGridView1.DataSource = dt;

            dataGridView1.Columns.Remove(dataGridView1.Columns[0]);
            connection.Close();

            dataGridView1.Rows[0].Selected = true;
            dataGridView1_CellContentClick(null,null);


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                string adSoyad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string tcKimlikNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string poliklinik = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string doktor = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string gun = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string saat = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                lblAdSoyad.Text = adSoyad;
                lblTc.Text = tcKimlikNo;
                lblPoliklinik.Text = poliklinik;
                lblDoktor.Text = doktor;
                lblGun.Text = gun;
                lblSaat.Text = saat;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("İptal etmek istiyor musunuz?", "Onaylıyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(result == DialogResult.Yes)
            { 
            connection.Open();

            SqlCommand command = new SqlCommand("delete from tbl_randevular where tcKimlikNo=@a1 and doktor=@a2 and gun=@a3 and saat=@a4",connection);
            command.Parameters.AddWithValue("@a1", lblTc.Text);
            command.Parameters.AddWithValue("@a2", lblDoktor.Text);
            command.Parameters.AddWithValue("@a3", lblGun.Text);
            command.Parameters.AddWithValue("@a4", lblSaat.Text);

            command.ExecuteNonQuery();

            MessageBox.Show("Randevunuz Silindi");

                lblAdSoyad.Text = "";
                lblTc.Text = "";
                lblPoliklinik.Text = "";
                lblDoktor.Text = "";
                lblGun.Text = "";
                lblSaat.Text = "";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where tcKimlikNo=@a1", connection);
                da.SelectCommand.Parameters.AddWithValue("@a1", tcKimlikNo);

                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {

                    dataGridView1.Visible = true;
                    lblMessage.Visible = false;
                }
                else
                {
                    dataGridView1.Visible = false;
                    lblMessage.Visible = true;
                }

                dataGridView1.DataSource = dt;

                dataGridView1.Columns.Remove(dataGridView1.Columns[0]);

                connection.Close();
            }
        }
    }
}
