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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool IsValid=true;
            //codigo de validacion de usuarios
            if (IsValid)
            {
                //codigo para filtrar por usuarios
                //falta conectar a la form de admins
                FormPonche formPonche = new FormPonche();
                formPonche.ShowDialog();
                this.Hide();
                //codigo provicional para conexiones


            }
        }


        private void labelNotPassWord_Click(object sender, EventArgs e)
        {
            //mostrar ayuda
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();

        }
    }
}
