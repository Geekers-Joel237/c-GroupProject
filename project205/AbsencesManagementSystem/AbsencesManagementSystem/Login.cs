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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtnLogin_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Entrer un nom d'utilisateur et un mot de passe");
            }
            else if (userName.Text == "Admin" && password.Text == "password")
            {
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mauvais nom d'utilisateur ou de mot de passe");
            }
        }

        private void resetField_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            password.Text = "";
        }
    }
}
