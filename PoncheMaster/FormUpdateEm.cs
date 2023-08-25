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
        public FormUpdateEm()
        {
            InitializeComponent();
        }

        private void FormUpdateEm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.EmployeePosition' Puede moverla o quitarla según sea necesario.
            this.employeePositionTableAdapter.Fill(this.poncheMasterDataSet.EmployeePosition);
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.poncheMasterDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.UserTable' Puede moverla o quitarla según sea necesario.
            this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.Employee' Puede moverla o quitarla según sea necesario.
            this.employeeTableAdapter.Fill(this.poncheMasterDataSet.Employee);

        }
    }
}
