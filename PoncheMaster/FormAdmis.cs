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
    public partial class FormAdmins : Form
    {
        public FormAdmins()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateEm createEm = new FormCreateEm();
            createEm.MdiParent =this;
            createEm.ShowDialog();

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReadEm readEm = new FormReadEm();
            readEm.MdiParent =this;
            readEm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormUpdateEm UpdateEm = new FormUpdateEm();
            UpdateEm.MdiParent =this;
            UpdateEm.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeleteEm deleteEm = new FormDeleteEm();
            deleteEm.MdiParent = this;
            deleteEm.ShowDialog();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReadPonche readPo = new FormReadPonche();
            readPo.MdiParent = this;
            readPo.ShowDialog();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
