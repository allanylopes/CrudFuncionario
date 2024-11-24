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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }
        Funcionario func = new Funcionario();

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_Funcionarios.DataSource = func.Consultar();
            dgv_Funcionarios.Columns["id"].HeaderText = "id";
            dgv_Funcionarios.Columns["nome"].HeaderText = "nome";
            dgv_Funcionarios.Columns["rg"].HeaderText = "rg";
            dgv_Funcionarios.Columns["Admissao"].HeaderText = "admissao";
            dgv_Funcionarios.Columns["salario"].HeaderText = "salario";
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "" || txt_Rg.Text == "" || btn_Admissao.Text == "" || txt_Salario.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");

            }
            else
            {
                func.Nome = txt_Nome.Text;
                func.Rg = txt_Rg.Text;
                func.Admissao1 = btn_Admissao.Text;
                func.Salario = txt_Salario.Text;
                func.inserir();
                dgv_Funcionarios.DataSource = func.Consultar();

                txt_Nome.Clear();
                txt_Rg.Clear();
                txt_Salario.Clear();
                btn_Admissao.Clear();

                MessageBox.Show("Dados Dravados com Sucesso ");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                func.Rg = txt_Rg.Text;
                func.excluir();
                dgv_Funcionarios.DataSource = func.Consultar();

                txt_Nome.Clear();
                txt_Rg.Clear();
                txt_Salario.Clear();
                btn_Admissao.Clear();
            }
            finally
            {
                MessageBox.Show("Exclusão realizada com Sucesso");
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                func.Rg = txt_Rg.Text;
                func.Nome = txt_Nome.Text;
                func.Salario = txt_Salario.Text;
                func.Admissao1 = btn_Admissao.Text;
                func.alterar();
                dgv_Funcionarios.DataSource = func.Consultar();

                txt_Nome.Clear();
                txt_Rg.Clear();
                txt_Salario.Clear();
                btn_Admissao.Clear();
            }
            finally
            {
                MessageBox.Show("Dados Alterados com Sucesso");
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            dgv_Funcionarios.DataSource = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Funcionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
