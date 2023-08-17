using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoncheMaster
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }



        private void labelNotPassWord_Click(object sender, EventArgs e)
        {
            //mostrar ayuda
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();

        }

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string pass = textBoxUserPassword.Text;
            bool IsValid = true;
            Datos D = new Datos();
            if (!D.Autentification(username,pass))
            {
                IsValid = false;
            }
            if (IsValid)
            {

                if (D.IsAdmin(username))
                {
                    FormPonche formPonche = new FormPonche();
                    formPonche.ShowDialog();
                    this.Hide();
                }
                if (!D.IsAdmin(username))
                {
                    FormAdmins formAdmins = new FormAdmins();
                    formAdmins.ShowDialog();
                    this.Hide();
                }
               
               


            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }

        }
    }
}
