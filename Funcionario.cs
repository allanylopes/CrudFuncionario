using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFuncionario
{
    class Funcionario : Conexao
    {
        private string rg;
        private string nome;
        private string Admissao;
        private string salario;

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Admissao1
        {
            get
            {
                return Admissao;
            }

            set
            {
                Admissao = value;
            }
        }

        public string Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public void inserir()
        {
            string query = "INSERT INTO funcionario(rg,nome,Admissao,salario) VALUES ('" + Rg + "','"
                + Nome + "','" + Admissao1  + "','" + Salario + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public void excluir()
        {
            string query = "Delete from funcionario where rg= '" + Rg + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void alterar()
        {
            string query = "UPDATE colaborador SET rg = '" + Rg +
                            "', nome =  '" + Nome +
                            "', Admissao =  '" + Admissao1 +
                            "'where salario = '" + Salario + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from funcionarios ";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
