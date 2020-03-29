using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Digitação
{
    class Query
    {

        //string caminho = "datasource=127.0.0.1;port=3306;username=root;password=;SslMode = none;database=digitacao";
        //string caminho = "datasource=localhost;port=3306;username=root;password=;SslMode = none;database=digitacao";
        string caminho ="Data Source=192.168.0.113,49170; Initial Catalog=digitacao; Persist Security Info=true; User ID=sa; Password=Sql2017";
        
        public string[] nome = new string[0];
        public int[] id_aluno = new int[0];
        public int[] licao = new int[0];
        public int[] nvl = new int[0];
        public string letras = "";
        MySqlConnection conexaoSql;

        MySqlCommand comandoSql;

        public void Select(string select, string table, int opcao)//, int indice)
        {

            {
                conexaoSql = new MySqlConnection(caminho);
                comandoSql = new MySqlCommand(select + table, conexaoSql);
                comandoSql.CommandTimeout = 60;
                try
                {
                    conexaoSql.Open();
                    MySqlDataReader myReaderSql = comandoSql.ExecuteReader();
                    if (myReaderSql.HasRows)
                    {
                        //Array.Clear(nome, 0, 200);

                        int i = 0;

                        while (myReaderSql.Read())
                        {
                            //Acrescenta 1 ao valor do Array nome
                            Array.Resize(ref id_aluno, id_aluno.Length + 1);
                            Array.Resize(ref nome, nome.Length + 1);
                            Array.Resize(ref nvl, nvl.Length + 1);
                            Array.Resize(ref licao, licao.Length + 1);
                            //Controla modificações, consultas e variáveis referentes a tabela alunos
                            if (opcao == 1)
                            {
                                //Mostra somente o nome do aluno, utilizar para a tela de login
                                //O numero 1 utilizado mostra o indice no banco de dados, no caso, o segundo
                                //nome[i] = myReaderSql.GetString(0) + " -- " + myReaderSql.GetString(1) + " -- " + myReaderSql.GetString(2) + " -- " + myReaderSql.GetString(3);
                                id_aluno[i] = Convert.ToInt32(myReaderSql.GetString(0));
                                nome[i] = myReaderSql.GetString(1);
                                nvl[i] = Convert.ToInt32(myReaderSql.GetString(2));
                                licao[i] = Convert.ToInt32(myReaderSql.GetString(3));
                                Trace.Flush();
                                i++;

                            }

                            //Controla modificações, consultas e variáveis referentes a tabela licoes
                            if (opcao == 2)
                            {
                                //Retorna o id do aluno, utilizar para a tela de login
                                //O numero 0 utilizado mostra o indice no banco de dados, no caso, o id do aluno
                                letras = myReaderSql.GetString(2);
                                Trace.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Query encontrou um erro: " + ex.Message + " em sua execução");
                }
            }
        }
        public void Insert(string insert, string table, string valores)
        {

            {
                conexaoSql = new MySqlConnection(caminho);
                comandoSql = new MySqlCommand(insert + table + valores, conexaoSql);
                comandoSql.CommandTimeout = 60;
                try
                {
                    //MessageBox.Show(Convert.ToString(insert + table + valores));
                    conexaoSql.Open();
                    MySqlDataReader myReaderSql = comandoSql.ExecuteReader();
                    //Trace.Flush();
                    MessageBox.Show("Aluno cadastrado com sucesso", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
                }
            }
        }

        public void Update(string update)
        {
            MessageBox.Show(update);
            conexaoSql = new MySqlConnection(caminho);
            comandoSql = new MySqlCommand(update, conexaoSql);
            comandoSql.CommandTimeout = 60;
            try
            {
                //MessageBox.Show(Convert.ToString(insert + table + valores));
                conexaoSql.Open();
                MySqlDataReader myReaderSql = comandoSql.ExecuteReader();
                //Trace.Flush();
                MessageBox.Show("asdfsadfasfasfsafsfsaasf", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
            }

        }
    }
}
