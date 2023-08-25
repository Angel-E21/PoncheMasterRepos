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
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.UserTable' Puede moverla o quitarla según sea necesario.
            this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);

        }
    }
}
