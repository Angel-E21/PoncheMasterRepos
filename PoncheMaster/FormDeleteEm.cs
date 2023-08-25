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
   
    public partial class FormDeleteEm : Form
    {
        Datos D = new Datos();
        public FormDeleteEm()
        {
            InitializeComponent();
        }

        private void FormDeleteEm_Load(object sender, EventArgs e)
        {
             this.employeeTableAdapter.Fill(this.poncheMasterDataSet.Employee);

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (comboBoxEmployeeID.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (isValid)
            {
                MessageBox.Show("estas seguro?");
                if (D.DeleteEmployee((int)comboBoxEmployeeID.SelectedValue))
                {
                    MessageBox.Show("Empleado Eliminado Con exito");
                }
                else
                {
                    MessageBox.Show("Hubo un Error");
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
