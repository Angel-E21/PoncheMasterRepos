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
    public partial class FormDeleteUs : Form
    {
        Datos D = new Datos();
        public FormDeleteUs()
        {
            InitializeComponent();
        }

        private void FormDeleteUs_Load(object sender, EventArgs e)
        {
           this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);

        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (iDUserComboBox.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (isValid)
            {
                MessageBox.Show("estas seguro?");
                if (D.DeleteUser((int)iDUserComboBox.SelectedValue))
                {
                    MessageBox.Show("Usuario Eliminado Con exito");
                }
                else
                {
                    MessageBox.Show("Hubo un Error");
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
