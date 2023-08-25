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
            createEm.Show();

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReadEm readEm = new FormReadEm();
            readEm.MdiParent =this;
            readEm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormUpdateEm UpdateEm = new FormUpdateEm();
            UpdateEm.MdiParent =this;
            UpdateEm.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDeleteEm deleteEm = new FormDeleteEm();
            deleteEm.MdiParent = this;
            deleteEm.Show();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReadPonche readPo = new FormReadPonche();
            readPo.MdiParent = this;
            readPo.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateUs createUs = new FormCreateUs();
            createUs.MdiParent =this;
            createUs.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUpdateUs updateUs = new FormUpdateUs();
            updateUs.MdiParent =this;
            updateUs.Show();
        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormDeleteUs deleteUs = new FormDeleteUs();
            deleteUs.MdiParent = this;
            deleteUs.Show();
        }
    }
}
