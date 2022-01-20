using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsencesManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            countStudents();
            countNiveaux();
            countUes();
        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=myabsencemanagementbd");

        private void countStudents() {
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from etudiants",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numEtudiants.Text = dt.Rows[0][0].ToString();
            con.Close();


        }

        private void countNiveaux()
        {
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from niveau", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numNiveaux.Text = dt.Rows[0][0].ToString();
            con.Close();


        }

        private void countUes()
        {
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from ues", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numUes.Text = dt.Rows[0][0].ToString();
            con.Close();


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Ues Obj = new Ues();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Etudiants Obj = new Etudiants();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Resultat Obj = new Resultat();
            Obj.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Notes Obj = new Notes();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Absences Obj = new Absences();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vraiment Quitter");
            this.Hide();
        }
    }
}
