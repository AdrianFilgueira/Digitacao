using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Digitação
{
    public class Conexao
    {
        SqlConnection conexao;
        SqlConnectionStringBuilder sqlBuilder;
        DataTable dadosTabela = new DataTable();
        DataTable dadosTabelaAulas = new DataTable();
        public string[] nome = new string[0];
        public int[] id_aluno = new int[0];
        public int[] licao = new int[0];
        public int[] nvl = new int[0];
        public string letras = "";
        string MelhorAproveitamento;
        public string Numero;
        int licaoAluno;
        void Conectar()
        {
            //Data Source = 192.168.0.113,49170; Initial Catalog = digitacao; User ID = sa; Password=***********
            sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = "192.168.0.123,49170";
            sqlBuilder.InitialCatalog = "digitacao";
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "Sql2017";
            //sqlBuilder.Password = "1032601632";
            sqlBuilder.IntegratedSecurity = false;
            sqlBuilder.ConnectTimeout = 5;
            conexao = new SqlConnection(sqlBuilder.ToString());
        }
        public Conexao()
        {
            Conectar();
        }
        public DataTable Listar(string comando)
        {
            dadosTabela.Clear();
            //Armazena as informações que o banco retorna com o select, dentro de uma tabela em memória.
            StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
            SqlCommand cmd = new SqlCommand();

            try
            {

                conexao.Open();

                sql.Append(comando);

                cmd.CommandText = sql.ToString();
                cmd.Connection = conexao;
                dadosTabela.Load(cmd.ExecuteReader()); //Executa a leitura dos dados da tabela e armazena dentro do objeto dadosTabela.
                return dadosTabela; //Retorna o objeto dadosTabela com as informações capturadas na leitura.
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema." + ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        public DataTable ListarAulas(string comando)
        {
            dadosTabelaAulas.Clear();
            //Armazena as informações que o banco retorna com o select, dentro de uma tabela em memória.
            StringBuilder sql = new StringBuilder(); //Auxilia na concatenação das strings presentes na query SQL.
            SqlCommand cmd = new SqlCommand();

            try
            {

                conexao.Open();

                sql.Append(comando);

                cmd.CommandText = sql.ToString();
                cmd.Connection = conexao;
                dadosTabelaAulas.Load(cmd.ExecuteReader()); //Executa a leitura dos dados da tabela e armazena dentro do objeto dadosTabela.
                return dadosTabelaAulas; //Retorna o objeto dadosTabela com as informações capturadas na leitura.
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro no método Listar Aulas. Caso o problema persista, entre em contato com o Administrador do sistema." + ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public void Select(string select, int opcao)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(select, conexao);

                int i = 0;

                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                var q = cmd.ToString();
                while (reader.Read())
                {

                    if (opcao == 1)
                    {
                        //Acrescenta 1 ao valor do Array nome
                        Array.Resize(ref id_aluno, id_aluno.Length + 1);
                        Array.Resize(ref nome, nome.Length + 1);
                        Array.Resize(ref nvl, nvl.Length + 1);
                        Array.Resize(ref licao, licao.Length + 1);

                        //Mostra somente o nome do aluno, utilizar para a tela de login
                        //O numero 1 utilizado mostra o indice no banco de dados, no caso, o segundo
                        //nome[i] = myReaderSql.GetString(0) + " -- " + myReaderSql.GetString(1) + " -- " + myReaderSql.GetString(2) + " -- " + myReaderSql.GetString(3);
                        id_aluno[i] = Convert.ToInt32(reader["id_aluno"].ToString());
                        nome[i] = reader["nome"].ToString();
                        nvl[i] = Convert.ToInt32(reader["linhas"].ToString());
                        licao[i] = Convert.ToInt32(reader["licao"].ToString());
                        i++;
                    }
                    if (opcao == 2)
                    {
                        //Retorna o id do aluno, utilizar para a tela de login
                        //O numero 0 utilizado mostra o indice no banco de dados, no caso, o id do aluno
                        letras = reader["licao"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
                return;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public string Select(string select)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(select, conexao);

                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                var q = cmd.ToString();
                while (reader.Read())
                {
                    MelhorAproveitamento = reader[0].ToString();
                    Numero = reader[1].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MelhorAproveitamento = "Erro";
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return MelhorAproveitamento;

        }

        public int SelectLicao(string select)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(select, conexao);

                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                var q = cmd.ToString();
                while (reader.Read())
                {
                    licaoAluno = Convert.ToInt32(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                licaoAluno = 0;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return licaoAluno;

        }

        public void Insert(string insert)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(insert, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
                return;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        public void Update(string update)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(update, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("asdfsadfasfasfsafsfsaasf", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
                return;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public void Delete(string delete)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(delete, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                if (delete.Substring(0,48) == "DELETE  FROM digitacao.dbo.aula WHERE aula.aluno")
                {

                }
                else
                {
                    MessageBox.Show("O aluno foi excluido com sucesso", "Exclusão Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
                return;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
    }
}
