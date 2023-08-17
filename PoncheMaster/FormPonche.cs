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
        public FormPonche()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            //codigo para ponchar
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
