using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastroEmpresas
{
    internal class cadastrarEmpresas
    {
        private string nome;
        private string cnpj;
        private DateTime data; // Alterado para DateTime para tratar corretamente datas

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // Método para cadastrar empresas no banco
        public bool Empresas()
        {
            try
            {
                using (MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    MysqlConexaoBanco.Open();

                    // SQL parametrizado
                    string insert = "INSERT INTO empresas (nome, cnpj, data) VALUES (@nome, @cnpj, @data)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco))
                    {
                        // Adiciona os parâmetros
                        comandoSql.Parameters.AddWithValue("@nome", nome);
                        comandoSql.Parameters.AddWithValue("@cnpj", cnpj);
                        comandoSql.Parameters.AddWithValue("@data", data);

                        // Executa o comando
                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método Empresas: " + ex.Message);
                return false;
            }
        }
    }
}
