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
    public partial class FormUpdateEm : Form
    {
        Datos D = new Datos();
        public FormUpdateEm()
        {
            InitializeComponent();
        }

        private void FormUpdateEm_Load(object sender, EventArgs e)
        {
             this.employeePositionTableAdapter.Fill(this.poncheMasterDataSet.EmployeePosition);
             this.departamentoTableAdapter.Fill(this.poncheMasterDataSet.Departamento);
             this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);
             this.employeeTableAdapter.Fill(this.poncheMasterDataSet.Employee);

        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(textBoxApellido.Text))
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(textBoxCedula.Text))
            {
                isValid = false;
            }
            if (dateTimePickerFechaNac.Value == DateTime.Now)
            {
                isValid = false;
            }
            if (comboBoxUsusario.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (comboBoxDepartamento.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (comboBoxPosicion.SelectedIndex == -1)
            {
                isValid = false;
            }
            if (!D.AuthCedula(textBoxCedula.Text))
            {
                isValid = false;
            }
            if(comboBoxEmployeeID == null)
            {
                isValid = false;
            }
            if (isValid)
            {
                if (D.UpdateEmployee((int)comboBoxEmployeeID.SelectedValue, textBoxName.Text, textBoxApellido.Text, textBoxCedula.Text, dateTimePickerFechaNac.Value, (int)comboBoxUsusario.SelectedValue, (int)comboBoxDepartamento.SelectedValue, (int)comboBoxPosicion.SelectedValue))
                {
                    MessageBox.Show("EmpleadoO Actualizado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
