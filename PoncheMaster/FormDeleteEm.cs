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
        public FormDeleteEm()
        {
            InitializeComponent();
        }

        private void FormDeleteEm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.Employee' Puede moverla o quitarla según sea necesario.
            this.employeeTableAdapter.Fill(this.poncheMasterDataSet.Employee);

        }
    }
}
