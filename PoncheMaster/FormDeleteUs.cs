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
        public FormDeleteUs()
        {
            InitializeComponent();
        }

        private void FormDeleteUs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'poncheMasterDataSet.UserTable' Puede moverla o quitarla según sea necesario.
            this.userTableTableAdapter.Fill(this.poncheMasterDataSet.UserTable);

        }
    }
}
