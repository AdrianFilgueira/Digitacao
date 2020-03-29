using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmLogin : Form
    {
        Conexao sql = new Conexao();


        public frmLogin()
        {
            InitializeComponent();
        }
        public void estruturaSelect()
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'digitacaoDataSet1.aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter1.Fill(this.digitacaoDataSet1.aluno);

            // TODO: This line of code loads data into the 'digitacaoDataSet.aluno' table. You can move, or remove it, as needed.
            var select = Task.Factory.StartNew(() => estruturaSelect());
            select.ContinueWith((x) =>
            {
                try
                {
                    sql = new Conexao();
                    //cboNomes.DataSource = sql.cboNomes();
                    sql.Select("SELECT * FROM aluno ORDER BY nome ASC", 1);

                    foreach (string item in sql.nome)
                    {
                        cboNomes.Items.Add(item);
                    }

                    //MessageBox.Show("oi");
                }
                catch (Exception)
                {
                    //throw;
                }

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        public void modificaCbo()
        {
            //string[] reultado = new string[0];
            //cboNomes.Items.Clear();
            Array.Resize(ref sql.id_aluno, sql.id_aluno.Length - sql.id_aluno.Length);
            Array.Resize(ref sql.nome, sql.nome.Length - sql.nome.Length);
            Array.Resize(ref sql.nvl, sql.nvl.Length - sql.nvl.Length); 
            Array.Resize(ref sql.licao, sql.licao.Length - sql.licao.Length);
            sql.Select("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC", 1);
        }
        public void index()
        {
            Array.Resize(ref sql.nome, sql.nome.Length - sql.nome.Length);
            sql.Select("SELECT * FROM aluno WHERE nome ='" + txtNomeAluno.Text + "'", 1);

        }
        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {
            var select = Task.Factory.StartNew(() => modificaCbo());
                select.ContinueWith((x) =>
                {
                    try
                    {
                        DataTable dados = sql.Listar("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC");

                        cboNomes.Items.Clear();
                        dtgNome.DataSource = dados;

                        /*for (int i = 0; i < sql.nome.Length; i++)
                        {
                            cboNomes.Items.Add(sql.nome[i]);
                        }*/
                        foreach (string item in sql.nome)
                        {
                            cboNomes.Items.Add(item);
                        }
                        cboNomes.Text = sql.nome[0];
                    }
                    catch (Exception)
                    {
                        //throw;
                    }

                }, TaskScheduler.FromCurrentSynchronizationContext());
            if (txtNomeAluno.Text == "")
            {
                txtNomeAluno.Focus();
            }
            if (cboNomes.Items.Count < 1)
            {
                cboNomes.Items.Add("Nenhum aluno com esse nome cadastrado");
                cboNomes.SelectedIndex = 0;
                txtNomeAluno.Focus();

            }
            cboNomes.SelectedIndex = 0;
            //cboNomes.Items.Add(x.Result);
            //cboNomes.Text = x.Result;
            /*
            cboNomes.Items.Clear();
            Array.Resize(ref sql.nome, sql.nome.Length - sql.nome.Length);
            sql.Select("SELECT * FROM ", "aluno WHERE aluno.nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC", 1);

            for (int i = 0; i < sql.nome.Length; i++)
            {
                cboNomes.Items.Add(sql.nome[i]);
            }
            cboNomes.Text = sql.nome[0];
            var select = Task.Factory.StartNew(() => modificaCbo());
                            select.ContinueWith((x) =>
                                 {
                                     //ConvertStringArrayToStringJoin(sql.nome)
                                     cbo = ConvertStringArrayToStringJoin(sql.nome);
                                     //cboNomes.Items.Clear();
                                     //.Items.Add(cbo);
                                     //cboNomes.Text = x.Result;
                                     //var oi = select.Exception;
                                     //MessageBox.Show(Convert.ToString(oi.Message), "Erro");
                                 }, TaskScheduler.FromCurrentSynchronizationContext());
                        //cboNomes.Items.Add(cbo);
                        */

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cboNomes.Text == "")
            {
                if (MessageBox.Show("Digite seu nome", "Falta de dados", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    txtNomeAluno.Text = "";
                    txtNomeAluno.Focus();
                    return;
                }
            }
            else
            {
                if (cboNomes.Text == "Nenhum aluno com esse nome cadastrado")
                {
                    if (MessageBox.Show("Insira um nome válido", "Nome errado", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                    {
                        Close();
                    }
                    else
                    {
                        txtNomeAluno.Text = "";
                        txtNomeAluno.Focus();
                        return;
                    }
                }
            }
            try
            {

                txtNomeAluno.Focus();
                txtNomeAluno.SelectAll();
                frmDigitacao digitacao = new frmDigitacao();
                digitacao.NomeDoAluno.Text = cboNomes.Text;
                //select id_aluno FROM aluno WHERE nome = "Adrian Tetzner Filgueira"
                //sql.Select("SELECT id_aluno FROM ", "aluno WHERE nome = \"" + cboNomes.Text + "\"", 2);
                digitacao.aluno = sql.id_aluno[0];
                //select licao FROM aluno WHERE id_aluno = 2
                //sql.Select("SELECT licao FROM ", "aluno WHERE id_aluno = " + sql.id_aluno + "", 2);
                digitacao.lblLicaoNEW.Text = Convert.ToString(sql.licao[0] + 1);
                digitacao.lblLicaoOLD.Text = Convert.ToString(sql.licao[0]);
                digitacao.lblId.Text = Convert.ToString(sql.id_aluno[0]);
                digitacao.lblLinhasRestantes.Text = Convert.ToString(sql.nvl[0]);

                digitacao.ShowDialog();
            }
            catch (Exception)
            {
                txtNomeAluno.Focus();
                txtNomeAluno.SelectAll();
            }
        }

        private void cboNomes_MouseLeave(object sender, EventArgs e)
        {
            txtNomeAluno.Focus();
            txtNomeAluno.SelectAll();
            cliquei = 0;

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void txtNomeAluno_KeyDown_1(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
        int cliquei = 0;
        private void cboNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cliquei == 1)
            {

                //MessageBox.Show(cboNomes.SelectedItem.ToString());
                var select = Task.Factory.StartNew(() => index());
                select.ContinueWith((x) =>
                {
                    try
                    {
                        txtNomeAluno.Text = cboNomes.SelectedItem.ToString();

                    }
                    catch (Exception)
                    {
                    //throw;
                }

                }, TaskScheduler.FromCurrentSynchronizationContext());
                cliquei = 0;
                txtNomeAluno.SelectAll();
            }
            else
            {
                cliquei = 0;
            }
        }

        private void cboNomes_Click(object sender, EventArgs e)
        {
            cliquei = 1;
        }
    }
}
