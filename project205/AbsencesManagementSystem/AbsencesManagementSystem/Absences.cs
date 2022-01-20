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
    public partial class Absences : Form
    {
        public Absences()
        {
            InitializeComponent();
            showEtudiants();
            //getNiveau();
            getMatricule();
            getCodeUe();
            //getNiveau2();

            countIdDate();
            
        }
        
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=myabsencemanagementbd");
        private void showAbsences()
        {
            con.Open();
            string Query = "select * from absenter";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            absGridView.DataSource = ds.Tables[0];

            con.Close();
        }
        private void countIdDate()
        {
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from date", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            idDat.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void showEtudiants()
        {
            con.Open();
            string Query = "select * from etudiants";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            absGridView.DataSource = ds.Tables[0];

            con.Close();
        }
        private void reset()
        {
            anneeAbs.Text = "";
            niveauAbs.Text = "";
            matriculeAbs.SelectedValue = -1;
            codeUeAbs.Text = "";
            niveau2Abs.Text = "";
            dateAbsence.Text = "";
            duree.Text = "";
        }

        private void getNiveau()
        {
            /*con.Open();
            MySqlCommand cmd = new MySqlCommand("Select nomNiveau from niveau", con);
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nomNiveau", typeof(string));
            dt.Load(Rdr);
            niveauAbs.ValueMember = "nomNiveau";
            niveauAbs.DataSource = dt;
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
            niveau2Abs.ValueMember = "nomNiveau";
            niveau2Abs.DataSource = dt;
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
            matriculeAbs.ValueMember = "matriculeEt";
            matriculeAbs.DataSource = dt;
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
            codeUeAbs.ValueMember = "codeUe";
            codeUeAbs.DataSource = dt;
            con.Close();
        }

        private void searchBtnAbs_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "select * from absenter where Etudiants_matriculeEt   ='" + searchField.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            absGridView.DataSource = ds.Tables[0];

            con.Close();
        }

        private void deleteBtnAbs_Click(object sender, EventArgs e)
        {
            if (matriculeAbs.Text == "")
            {
                MessageBox.Show("Veuillez selectionner l'Etudiant.");

            }
            else
            {
                
                /*DELETE FROM `absenter` WHERE `absenter`.`Etudiants_matriculeEt` = \'18Q2057\' AND `absenter`.`Etudiants_Annee_idAnnee` = 2021 AND `absenter`.`Etudiants_Niveau_nomNiveau` = \'ICT4DL2\' AND `absenter`.`Ues_codeUe` = \'ict205\' AND `absenter`.`Ues_Niveau_nomNiveau` = \'ICT4DL2\' AND `absenter`.`Date_idDate` = 1 
                */

                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from absenter where Etudiants_matriculeEt =@EM and Etudiants_Annee_idAnnee=@EAI and Etudiants_Niveau_nomNiveau=@ENN and Ues_codeUe=@UC and Ues_Niveau_nomNiveau=@UNN and Date_idDate=@DD", con);
                    cmd.Parameters.AddWithValue("@EM", matriculeAbs.Text);
                    cmd.Parameters.AddWithValue("@EAI", anneeAbs.Text);
                    cmd.Parameters.AddWithValue("@ENN", niveauAbs.Text);
                    cmd.Parameters.AddWithValue("@UC", codeUeAbs.Text);
                    cmd.Parameters.AddWithValue("@UNN", niveau2Abs.Text);
                    cmd.Parameters.AddWithValue("@DD", idDat.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence Supprimee Avec Succes");
                    con.Close();
                    showAbsences();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void editBtnAbs_Click(object sender, EventArgs e)
        {
            if (anneeAbs.Text == "" || niveauAbs.Text == "" ||
                matriculeAbs.Text == "" || codeUeAbs.Text == "" ||
                niveau2Abs.Text == "" || dateAbsence.Text == "" || duree.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {
                /*
                 UPDATE `absenter` SET `duree` = '6' WHERE `absenter`.`Etudiants_matriculeEt` = '18Q2057' AND `absenter`.`Etudiants_Annee_idAnnee` = 2021 AND `absenter`.`Etudiants_Niveau_nomNiveau` = 'ICT4DL2' AND `absenter`.`Ues_codeUe` = 'ict205' AND `absenter`.`Ues_Niveau_nomNiveau` = 'ICT4DL2' AND `absenter`.`Date_idDate` = 1;
                 */

                try
                {
                    con.Open();
                    MySqlCommand cmd;

                    cmd = new MySqlCommand("update absenter set duree=@duree where Etudiants_matriculeEt=@EM and Etudiants_Annee_idAnnee=@EAI and  Etudiants_Niveau_nomNiveau=@ENN and Ues_codeUe=@UC and  Ues_Niveau_nomNiveau=@UNN and Date_idDate=@DD", con);
                    /*cmd.Parameters.AddWithValue("@EM", matriculeAbs.Text);
                    cmd.Parameters.AddWithValue("@EAI", anneeAbs.Text);
                    cmd.Parameters.AddWithValue("@ENN", niveauAbs.Text);
                    cmd.Parameters.AddWithValue("@UC", codeUeAbs.Text);
                    cmd.Parameters.AddWithValue("@UNN", niveau2Abs.Text);
                    cmd.Parameters.AddWithValue("@DD", dateAbsence.Text);
                    cmd.Parameters.AddWithValue("@duree", duree.Text);*/

                    cmd.Parameters.AddWithValue("@EM", matriculeAbs.Text);
                    cmd.Parameters.AddWithValue("@EAI", anneeAbs.Text);
                    cmd.Parameters.AddWithValue("@ENN", niveauAbs.Text);
                    cmd.Parameters.AddWithValue("@UC", codeUeAbs.Text);
                    cmd.Parameters.AddWithValue("@UNN", niveau2Abs.Text);
                    cmd.Parameters.AddWithValue("@DD", idDat.Text);
                    cmd.Parameters.AddWithValue("@duree", duree.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence Modifiee Avec Succes");
                    con.Close();
                    showAbsences();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void saveBtnAbs_Click(object sender, EventArgs e)
        {
            if (anneeAbs.Text == "" || niveauAbs.Text == "" ||
                matriculeAbs.Text == "" || codeUeAbs.Text == "" ||
                niveau2Abs.Text == "" || dateAbsence.Text == "" || duree.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");

            }
            else
            {
                /*
                 INSERT INTO `absenter` (`Etudiants_matriculeEt`, `Etudiants_Annee_idAnnee`, `Etudiants_Niveau_nomNiveau`, `Ues_codeUe`, `Ues_Niveau_nomNiveau`, `Date_idDate`, `duree`) VALUES ('18Q2057', '2021', 'ICT4DL2', 'ict205', 'ICT4DL2', '1', '4');
                 */
                try
                {
                    con.Open();
                    MySqlCommand cmd;

                    cmd = new MySqlCommand("insert into date (idDate ,dateAbsence) values (@idDate,@dateAbsence)", con);
                    cmd.Parameters.AddWithValue("@idDate", idDat.Text);
                    cmd.Parameters.AddWithValue("@dateAbsence", dateAbsence.Text);
                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Date Ajoutee Avec Succes");
                    
                    con.Close();
                    //showAbsences();
                    //reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

                try
                {
                    /*
                     INSERT INTO `absenter` (`Etudiants_matriculeEt`, `Etudiants_Annee_idAnnee`, `Etudiants_Niveau_nomNiveau`, `Ues_codeUe`, `Ues_Niveau_nomNiveau`, `Date_idDate`, `duree`) VALUES ('18Q2057', '2021', 'ICT4DL2', 'ict205', 'ICT4DL2', '1', '4');
                     */
                    con.Open();
                    MySqlCommand cmd;

                    cmd = new MySqlCommand("insert into absenter (Etudiants_matriculeEt,Etudiants_Annee_idAnnee,Etudiants_Niveau_nomNiveau,Ues_codeUe,Ues_Niveau_nomNiveau,Date_idDate,duree) values (@EM,@EAI,@ENN,@UC,@UNN,@DD,@duree)", con);
                    cmd.Parameters.AddWithValue("@EM", matriculeAbs.Text);
                    cmd.Parameters.AddWithValue("@EAI", anneeAbs .Text);
                    cmd.Parameters.AddWithValue("@ENN", niveauAbs.Text);
                    cmd.Parameters.AddWithValue("@UC", codeUeAbs.Text);
                    cmd.Parameters.AddWithValue("@UNN", niveau2Abs.Text);
                    cmd.Parameters.AddWithValue("@DD", idDat.Text);
                    cmd.Parameters.AddWithValue("@duree", duree.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence Ajoutee Avec Succes");
                    con.Close();
                    showAbsences();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
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

        private void label2_Click(object sender, EventArgs e)
        {
            Notes Obj = new Notes();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Resultat Obj = new Resultat();
            Obj.Show();
            this.Hide();
        }

        private void Absences_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAbsences();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showEtudiants();
        }

        private void absGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.absGridView.Rows[e.RowIndex];
                niveauAbs.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();
                anneeAbs.Text = row.Cells["Annee_idAnnee"].Value.ToString();
                niveau2Abs.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();
                //codeUeNote.Text = row.Cells["Niveau_nomNiveau"].Value.ToString();


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
