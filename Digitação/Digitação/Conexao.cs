using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Digitação
{
    public class Conexao
    {
        SqlConnection conexao;
        SqlConnectionStringBuilder sqlBuilder;
        DataTable dadosTabela = new DataTable();
        public string[] nome = new string[0];
        public int[] id_aluno = new int[0];
        public int[] licao = new int[0];
        public int[] nvl = new int[0];
        public string letras = "";
        void Conectar()
        {
            //Data Source = 192.168.0.113,49170; Initial Catalog = digitacao; User ID = sa; Password=***********
            sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = "192.168.0.113,49170";
            sqlBuilder.InitialCatalog = "digitacao";
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "Sql2017";
            sqlBuilder.IntegratedSecurity = true;
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
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro no método Listar. Caso o problema persista, entre em contato com o Administrador do sistema.");
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
                int i = 0;

                SqlCommand cmd = new SqlCommand(select, conexao);
                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                var q = cmd.ToString();
                while (reader.Read())
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
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        public List<Conexao> cboNomes()
        {
            List<Conexao> listarPessoas = new List<Conexao>();
            try
            {
                string cmd = "SELECT * FROM dbo.aluno ORDER BY dbo.aluno.nome ASC";
                SqlCommand execucao = new SqlCommand(cmd, conexao);
                conexao.Open();

                SqlDataReader reader = execucao.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;

                    //Acrescenta 1 ao valor do Array nome
                    Array.Resize(ref id_aluno, id_aluno.Length + 1);
                    Array.Resize(ref nome, nome.Length + 1);
                    Array.Resize(ref nvl, nvl.Length + 1);
                    Array.Resize(ref licao, licao.Length + 1);
                    //Mostra somente o nome do aluno, utilizar para a tela de login
                    //O numero 1 utilizado mostra o indice no banco de dados, no caso, o segundo
                    //nome[i] = myReaderSql.GetString(0) + " -- " + myReaderSql.GetString(1) + " -- " + myReaderSql.GetString(2) + " -- " + myReaderSql.GetString(3);
                    Conexao c = new Conexao();
                    id_aluno[i] = Convert.ToInt32(reader["id_aluno"].ToString());
                    nome[i] = reader["nome"].ToString();
                    /*nvl[i] = Convert.ToInt32(reader.GetString(2));
                    licao[i] = Convert.ToInt32(reader.GetString(3));*/
                    i++;
                    listarPessoas.Add(c);
                }
                return listarPessoas;

            }
            catch (Exception)
            {

                throw;
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
