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
    public partial class FormCreateUs : Form
    {
        Datos D = new Datos();
        public FormCreateUs()
        {
            InitializeComponent();
        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.poncheMasterDataSet);

        }

        private void FormCreateUs_Load(object sender, EventArgs e)
        {
           this.userTypeTableAdapter.Fill(this.poncheMasterDataSet.UserType);
           this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);

        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            bool isValid =true;
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(userPasswordTextBox.Text))
            {
                isValid = false;
            }
            if (UsertypecomboBox.SelectedIndex==-1)
            {
                isValid = false;
            }
            if (isValid)
            {
               if(D.insertUser(usernameTextBox.Text, userPasswordTextBox.Text, (int)UsertypecomboBox.SelectedValue))
                {
                    MessageBox.Show("Ususario Agregado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }

        }
    }
}
