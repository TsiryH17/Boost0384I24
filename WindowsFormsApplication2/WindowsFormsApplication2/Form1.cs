using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            

            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TsiryH17\onedrive\documents\visual studio 2012\Projects\WindowsFormsApplication2\WindowsFormsApplication2\BaseBoost.mdf;Integrated Security=True");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChargerDonnees()
        {
            try
            {
                con.Open();
                string req = "SELECT * FROM Prs";
                SqlDataAdapter da = new SqlDataAdapter(req, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnAjt_Click(object sender, EventArgs e)
        {
            con.Open();
            String Nom = txtNom.Text;
            String Prenom = txtPren.Text;
            int Age = int.Parse(txtage.Text);

            String Adresse = txtadr.Text;
            String Prof = txtPrf.Text;
            String req = "insert into Prs (Nom, Prenom, Age,Adresse, Profession) values('" + Nom + "','" + Prenom + "','" + Age + "','" + Adresse + "','" + Prof + "')";
            SqlCommand cmd = new SqlCommand(req, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            ChargerDonnees();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNom.Text = row.Cells["Nom"].Value.ToString();
                txtPren.Text = row.Cells["Prenom"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                txtadr.Text = row.Cells["Adresse"].Value.ToString();
                txtPrf.Text = row.Cells["Profession"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}