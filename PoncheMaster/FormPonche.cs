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
    public partial class FormPonche : Form
    {
        Datos D = new Datos();
        public FormPonche()
        {
           
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (D.AuthCedula(textBoxCedula.Text))
            {

                if (D.Ponche(textBoxCedula.Text))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

            }
            else
            {

                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("ponche existoso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Algo salio Mal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
