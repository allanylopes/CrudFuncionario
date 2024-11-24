using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Funcionario func = new Funcionario();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)

        {
            FrmFuncionario func = new FrmFuncionario();
            func.MdiParent = this;
            func.Show();
        }
    }
}
