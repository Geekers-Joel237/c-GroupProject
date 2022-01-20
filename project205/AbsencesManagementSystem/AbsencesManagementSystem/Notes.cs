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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            showEtudiants();
            getMatricule();
            getCodeUe();
            
            //getNiveau2();
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
            notesGridView.DataSource = ds.Tables[0];

            con.Close();
        }

        private void showNotes()
        {
            con.Open();
            string Query = "select * from noter";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            notesGridView.DataSource = ds.Tables[0];

            con.Close();
        }
        private void reset()
        {
            anneeNote.Text = "";
            niveauNote.Text = "";
            matriculeNote.SelectedValue=-1;
            niveauUeNote.Text = "";
            codeUeNote.SelectedValue = -1;
            noteCC.Text = "";
            noteSn.Text = "";
            noteTP.Text = "";
        }

        private void getNiveau() {
            

            /*con.Open();
            string Query = "select * from etudiants where matriculeEt ="+matriculeNote.SelectedValue.ToString()+"";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                niveauNote.Text = dr["Niveau_nomNiveau"].ToString();
            }
            con.Close();*/

        }

        private void getNiveau2()
        {
            /*con.Open();
            MySqlCommand cmd = new MySqlCommand("Select nomNiveau from niveau", con);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nomNiveau", typeof(string));
            dt.Load(Rdr);
            niveauUeNote.ValueMember = "nomNiveau";
            niveauUeNote.DataSource = dt;
            con.Close();*/
        }

        private void getMatricule()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select matriculeEt from etudiants", con);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("matriculeEt", typeof(string));
            dt.Load(Rdr);
            matriculeNote.ValueMember = "matriculeEt";
            matriculeNote.DataSource = dt;
            con.Close();
        }

        private void getCodeUe()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select codeUe from ues", con);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("codeUe", typeof(string));
            dt.Load(Rdr);
            codeUeNote.ValueMember = "codeUe";
            codeUeNote.DataSource = dt;
            con.Close();
        }


        private void saveBtnEt_Click(object sender, EventArgs e)
        {
            if (anneeNote.Text == "" || niveauNote.Text == "" ||
                matriculeNote.Text == "" || codeUeNote.Text == "" ||
                noteCC.Text == "" || noteSn.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {
                /*
                 INSERT INTO `noter` (`Etudiants_matriculeEt`, `Etudiants_Annee_idAnnee`, `Etudiants_Niveau_nomNiveau`, `Ues_codeUe`, `Ues_Niveau_nomNiveau`, `noteCC`, `noteSN`, `noteTP`) VALUES ('18Q2057', '2021', 'ICT4DL2', 'ict205', 'ICT4DL2', '18', '15', '17');
                 */

                try
                {
                    con.Open();
                    MySqlCommand cmd;
                   
                    cmd = new MySqlCommand("insert into noter (Etudiants_matriculeEt ,Etudiants_Annee_idAnnee,Etudiants_Niveau_nomNiveau,Ues_codeUe,Ues_Niveau_nomNiveau,noteCC,noteSN,noteTP) values (@Etudiants_matriculeEt,@Etudiants_Annee_idAnnee,@Etudiants_Niveau_nomNiveau,@Ues_codeUe,@Ues_Niveau_nomNiveau,@noteCC,@noteSN,@noteTP)", con);
                    cmd.Parameters.AddWithValue("@Etudiants_matriculeEt", matriculeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Annee_idAnnee", anneeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Niveau_nomNiveau", niveauNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_codeUe", codeUeNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_Niveau_nomNiveau", niveauUeNote.Text);
                    cmd.Parameters.AddWithValue("@noteCC", noteCC.Text);
                    cmd.Parameters.AddWithValue("@noteSN", noteSn.Text);
                    
                    cmd.Parameters.AddWithValue("@noteTP", noteTP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note Ajoutee Avec Succes");
                    con.Close();
                    showNotes();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void editBtnNote_Click(object sender, EventArgs e)
        {
            if (anneeNote.Text == "" || niveauNote.Text == "" ||
                matriculeNote.Text == "" || codeUeNote.Text == "" ||
                noteCC.Text == "" || noteSn.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {
                /*
                 UPDATE `noter` SET `noteCC` = '13', `noteSN` = '12', `noteTP` = '7' WHERE `noter`.`Etudiants_matriculeEt` = '18Q2057' AND `noter`.`Etudiants_Annee_idAnnee` = 2021 AND `noter`.`Etudiants_Niveau_nomNiveau` = 'ICT4DL2' AND `noter`.`Ues_codeUe` = 'ict205' AND `noter`.`Ues_Niveau_nomNiveau` = 'ICT4DL2';
                 */
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update noter Set Etudiants_matriculeEt=@Etudiants_matriculeEt,Etudiants_Annee_idAnnee=@Etudiants_Annee_idAnnee,Etudiants_Niveau_nomNiveau=@Etudiants_Niveau_nomNiveau,Ues_codeUe=@Ues_codeUe,Ues_Niveau_nomNiveau=@Ues_Niveau_nomNiveau,noteCC=@noteCC,noteSN=@noteSN,noteTP=@noteTP where Etudiants_matriculeEt=@Etudiants_matriculeEt AND Etudiants_Annee_idAnnee=@Etudiants_Annee_idAnnee AND Etudiants_Niveau_nomNiveau=@Etudiants_Niveau_nomNiveau AND Ues_codeUe=@Ues_codeUe AND Ues_Niveau_nomNiveau=@Ues_Niveau_nomNiveau", con);
                    cmd.Parameters.AddWithValue("@Etudiants_matriculeEt", matriculeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Annee_idAnnee", anneeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Niveau_nomNiveau", niveauNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_codeUe", codeUeNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_Niveau_nomNiveau", niveauUeNote.Text);
                    cmd.Parameters.AddWithValue("@noteCC", noteCC.Text);
                    cmd.Parameters.AddWithValue("@noteSN", noteSn.Text);
              
                    cmd.Parameters.AddWithValue("@noteTP", noteTP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note Modifiee Avec Succes");
                    con.Close();
                    showNotes();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void deleteBtnNote_Click(object sender, EventArgs e)
        {
            if (matriculeNote.Text == "")
            {
                MessageBox.Show("Veuillez selectionner l'Etudiant.");

            }
            else
            {
                /*
                 DELETE FROM `noter` WHERE `noter`.`Etudiants_matriculeEt` = \'21Q1254\' 
                 * AND `noter`.`Etudiants_Annee_idAnnee` = 2021 
                 * AND `noter`.`Etudiants_Niveau_nomNiveau` = \'ICT4DL3\' 
                 * AND `noter`.`Ues_codeUe` = \'ict104\' 
                 * AND `noter`.`Ues_Niveau_nomNiveau` = \'ICT4DL3\'
                 */
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from noter where Etudiants_matriculeEt=@Etudiants_matriculeEt AND Etudiants_Annee_idAnnee=@Etudiants_Annee_idAnnee AND Etudiants_Niveau_nomNiveau=@Etudiants_Niveau_nomNiveau AND Ues_codeUe=@Ues_codeUe AND Ues_Niveau_nomNiveau=@Ues_Niveau_nomNiveau", con);
                    cmd.Parameters.AddWithValue("@Etudiants_matriculeEt", matriculeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Annee_idAnnee", anneeNote.Text);
                    cmd.Parameters.AddWithValue("@Etudiants_Niveau_nomNiveau", niveauNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_codeUe", codeUeNote.Text);
                    cmd.Parameters.AddWithValue("@Ues_Niveau_nomNiveau", niveauUeNote.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Note Supprimee Avec Succes");
                    con.Close();
                    showNotes();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void searchBtnNote_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "select * from noter where Etudiants_matriculeEt  ='" + searchField.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            notesGridView.DataSource = ds.Tables[0];

            con.Close();
        }

       

       

        private void matriculeNote_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getNiveau();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Etudiants Obj = new Etudiants();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Ues Obj = new Ues();
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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            showEtudiants();
            searchField.Text = "";
        }

        private void niveauNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.notesGridView.Rows[e.RowIndex];
                niveauNote.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();
                anneeNote.Text = row.Cells["Annee_idAnnee"].Value.ToString();
                niveauUeNote.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();
                //codeUeNote.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showNotes();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        

        

       
    }
}
