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
    class ipPass
    {

        SqlConnection conexao;
        SqlConnectionStringBuilder sqlBuilder;
        DataTable dadosTabela = new DataTable();
        DataTable dadosTabelaAulas = new DataTable();

        string status;
        void Conectar()
        {
            //Data Source = 192.168.0.113,49170; Initial Catalog = digitacao; User ID = sa; Password=***********
            sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = "192.168.0.123,49170";
            sqlBuilder.InitialCatalog = "digitacao";
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "Sql2017";
            sqlBuilder.IntegratedSecurity = false;
            sqlBuilder.ConnectTimeout = 5;
            conexao = new SqlConnection(sqlBuilder.ToString());
        }
        public ipPass()
        {
            Conectar();
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
                    status = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query encontrou o erro: " + ex.Message + " em sua execução");
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return status;
        }
    }
}
