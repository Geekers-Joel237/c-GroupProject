using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AbsencesManagementSystem
{
    public partial class Etudiants : Form
    {
        public Etudiants()
        {
            InitializeComponent();
            showEtudiants();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=myabsencemanagementbd");
        private void showEtudiants()
        {
            con.Open();
            string Query = "select * from etudiants";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            con.Close();
        }
        private void reset()
        {
            niveauEt.Text = "";
            anneeEt.Text = "";
            matriculeEt.Text = "";
            nomsEt.Text = "";
            prenomsEt.Text = "";
            dateNaissanceEt.Text = "";
        }

        private void saveBtnEt_Click(object sender, EventArgs e)
        {
            if (niveauEt.Text == "" || anneeEt.Text == "" ||
                matriculeEt.Text == "" || nomsEt.Text == "" ||
                prenomsEt.Text == "" || dateNaissanceEt.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {

                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into etudiants (matriculeEt ,nomEtudiant,prenomEtudiant,dateDeNaissance,Annee_idAnnee,Niveau_nomNiveau) values (@matriculeEt,@nomEtudiant,@prenomEtudiant,@dateDeNaissance,@Annee_idAnnee,@Niveau_nomNiveau)", con);
                    cmd.Parameters.AddWithValue("@matriculeEt", matriculeEt.Text);
                    cmd.Parameters.AddWithValue("@nomEtudiant", nomsEt.Text);
                    cmd.Parameters.AddWithValue("@prenomEtudiant", prenomsEt.Text);
                    cmd.Parameters.AddWithValue("@dateDeNaissance", dateNaissanceEt.Text);
                    cmd.Parameters.AddWithValue("@Annee_idAnnee", anneeEt.Text);
                    cmd.Parameters.AddWithValue("@Niveau_nomNiveau", niveauEt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etudiant Ajoutee Avec Succes");
                    con.Close();
                    showEtudiants();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void editBtnEt_Click(object sender, EventArgs e)
        {
            if (niveauEt.Text == "" || anneeEt.Text == "" ||
                matriculeEt.Text == "" || nomsEt.Text == "" ||
                prenomsEt.Text == "" || dateNaissanceEt.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {

                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update etudiants Set matriculeEt=@matriculeEt,nomEtudiant=@nomEtudiant,prenomEtudiant=@prenomEtudiant,dateDeNaissance=@dateDeNaissance,Annee_idAnnee =@Annee_idAnnee,Niveau_nomNiveau=@Niveau_nomNiveau  where matriculeEt=@matriculeEt ", con);
                    cmd.Parameters.AddWithValue("@matriculeEt", matriculeEt.Text);
                    cmd.Parameters.AddWithValue("@nomEtudiant", nomsEt.Text);
                    cmd.Parameters.AddWithValue("@prenomEtudiant", prenomsEt.Text);
                    cmd.Parameters.AddWithValue("@dateDeNaissance", dateNaissanceEt.Text);
                    cmd.Parameters.AddWithValue("@Annee_idAnnee", anneeEt.Text);
                    cmd.Parameters.AddWithValue("@Niveau_nomNiveau", niveauEt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etudiant Modifiee Avec Succes");
                    con.Close();
                    showEtudiants();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void deleteBtnEt_Click(object sender, EventArgs e)
        {
            if (matriculeEt.Text == "" )
            {
                MessageBox.Show("Veuillez selectionner un etudiant.");

            }
            else
            {

                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from etudiants where matriculeEt=@matriculeEt ", con);
                    cmd.Parameters.AddWithValue("@matriculeEt", matriculeEt.Text);
                    /*cmd.Parameters.AddWithValue("@nomEtudiant", nomsEt.Text);
                    cmd.Parameters.AddWithValue("@prenomEtudiant", prenomsEt.Text);
                    cmd.Parameters.AddWithValue("@dateDeNaissance", dateNaissanceEt.Text);
                    cmd.Parameters.AddWithValue("@Annee_idAnnee", anneeEt.Text);
                    cmd.Parameters.AddWithValue("@Niveau_nomNiveau", niveauEt.Text);*/
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etudiant Supprime Avec Succes");
                    con.Close();
                    showEtudiants();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void searchBtnEt_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "select * from etudiants where matriculeEt ='" +searchField.Text +"'" ;
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            con.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Ues Obj = new Ues();
            Obj.Show();
            this.Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Resultat Obj = new Resultat();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}