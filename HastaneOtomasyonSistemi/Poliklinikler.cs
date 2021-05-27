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
    public partial class Poliklinikler : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3J8M0R\\SQLEXPRESS;Initial Catalog = HastaneOtomasyon; Integrated Security = True");

        string kontrolText;
        public Poliklinikler(string kontrolText)
        {
            this.kontrolText = kontrolText;
            InitializeComponent();

        }

        private void Poliklinikler_Load(object sender, EventArgs e)
        {
            if(kontrolText == "admin")
            {
                btnDoktorEkle.Visible = true;
                btnDoktoruSil.Visible = true;
            }
            
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }

        public void listele()
        {
            string poliklinik = cmbPoliklinik.Text;

            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktorlar where poliklinik = @a1", connection);
            da.SelectCommand.Parameters.AddWithValue("@a1", poliklinik);

            da.Fill(dt);


            dataGridView2.DataSource = dt;

            // dataGridView2.Columns.Remove(dataGridView2.Columns[0]);
            connection.Close();

            dataGridView2.Rows[0].Selected = true;

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle de = new DoktorEkle(kontrolText);
            de.ShowDialog();
            listele();
            de.Close();
        }

        private void btnDoktoruSil_Click(object sender, EventArgs e)
        {

           DialogResult result =  MessageBox.Show("Silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                int id = (int)dataGridView2.CurrentRow.Cells[0].Value;
                if (id != null)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("delete from tbl_doktorlar where id = @d", connection);
                    command.Parameters.AddWithValue("@d", id);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Doktor Silindi");
                    listele();
                }
            }

          
        }
    }
}
