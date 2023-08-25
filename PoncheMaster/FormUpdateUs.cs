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
    public partial class FormUpdateUs : Form
    {
        Datos D = new Datos();
        public FormUpdateUs()
        {
            InitializeComponent();
        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poncheMasterDataSet);

        }

        private void FormUpdateUs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.UserType' Puede moverla o quitarla según sea necesario.
            this.userTypeTableAdapter.Fill(this.poncheMasterDataSet.UserType);

            this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);

        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(userPasswordTextBox.Text))
            {
                isValid = false;
            }
            if (UsertypecomboBox.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (iDUserComboBox.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (isValid)
            {
                if (D.UpdateUser((int)iDUserComboBox.SelectedValue,usernameTextBox.Text, userPasswordTextBox.Text, (int)UsertypecomboBox.SelectedValue))
                {
                    MessageBox.Show("Ususario actualizado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }
        }
    }
}
