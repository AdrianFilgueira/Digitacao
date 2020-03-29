using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmLogin : Form
    {
        criptografia crip = new criptografia();
        Conexao sql = new Conexao();
        ipPass verificacao = new ipPass();
        string senhaMaster = "Hello";

        public frmLogin()
        {
            InitializeComponent();
        }
        public void index()
        {
            Array.Resize(ref sql.nome, sql.nome.Length - sql.nome.Length);
            sql.Select("SELECT * FROM aluno WHERE nome ='" + txtNomeAluno.Text + "'", 1);
        }
        public void FAIL(bool define)
        {
            btnAdm.Enabled = define;
            btnCadastrar.Enabled = define;
            btnEntrar.Enabled = define;
            txtNomeAluno.Enabled = define;
            cboNomes.Enabled = define;

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            string[] verifica = new string[0];
            for (int i = 0; i < ip.Length; i++)
            {
                Array.Resize(ref verifica, verifica.Length + 1);
                crip.Encriptografar(verificacao.Select("SELECT estado FROM server WHERE ip_pc = '" + ip[i].ToString() + "'") + "true");
                verifica[i] = crip.senha;

            }
            foreach (string procura in verifica)
            {
                if (procura != null)
                {

                    if (procura == crip.senha)
                    {

                        FAIL(true);
                    }
                    else if (procura != crip.senha)
                    {
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        //FAIL(false);
                        FAIL(false);
                    }
                }
                else
                {
                    FAIL(false);
                }

            }
            if (btnAdm.Enabled == false)
            {
                MessageBox.Show("Este computador não está autorizado a executar o programa, entre em contato com o administrador para mais informações", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // TODO: This line of code loads data into the 'digitacaoDataSet2.aula' table. You can move, or remove it, as needed.
                this.aulaTableAdapter.Fill(this.digitacaoDataSet2.aula);
                DataTable dados = sql.Listar("SELECT * FROM aluno ORDER BY aluno.nome ASC");
                dtgNome.DataSource = dados;
                DataTable dados1 = sql.ListarAulas("SELECT  * FROM  aula WHERE aula.licao <> 0 ORDER BY aula.licaoFeitaEm DESC");
                dtgAulas.DataSource = dados1;
                sql.Select("SELECT * FROM aluno", 1);

                for (int i = 0; i < sql.nome.Length; i++)
                {

                    cboNomes.Items.Add(sql.nome[i]);
                }
                frmInicio frmi = new frmInicio();
                frmi.WindowState = FormWindowState.Minimized;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conexão mal-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modificaCbo()
        {
            //string[] reultado = new string[0];
            Array.Resize(ref sql.id_aluno, sql.id_aluno.Length - sql.id_aluno.Length);
            Array.Resize(ref sql.nome, sql.nome.Length - sql.nome.Length);
            Array.Resize(ref sql.nvl, sql.nvl.Length - sql.nvl.Length); 
            Array.Resize(ref sql.licao, sql.licao.Length - sql.licao.Length);
            sql.Select("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC", 1);
        }

        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {
            var select = Task.Factory.StartNew(() => modificaCbo());
                select.ContinueWith((x) =>
                {
                    try
                    {

                        DataTable dados = sql.Listar("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC");
                        dtgNome.DataSource = dados;
                        DataTable dados1 = sql.ListarAulas("SELECT * FROM aula WHERE aluno LIKE '%" + txtNomeAluno.Text + "%' ORDER BY aula.licaoFeitaEm DESC");
                        dtgAulas.DataSource = dados1;
                        cboNomes.Items.Clear();
                        cboNomes.Text = sql.nome[0];
                        for (int i = 0; i < sql.nome.Length; i++)
                        {

                            cboNomes.Items.Add(sql.nome[i]);
                        }

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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {

                string nome = cboNomes.Text;
                if (nome == "")
                {
                    if (MessageBox.Show("Digite seu nome", "Falta de dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
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
                    if (nome == "Nenhum aluno com esse nome cadastrado")
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
                txtNomeAluno.Focus();
                txtNomeAluno.SelectAll();
                frmInicio inicio = new frmInicio();
                inicio.licaoAtual = sql.licao[0] + 1;
                frmDigitacao digitacao = new frmDigitacao();
                digitacao.NomeDoAluno.Text = nome;
                digitacao.aluno = sql.id_aluno[0];
                digitacao.lblLicaoNEW.Text = Convert.ToString(sql.licao[0] + 1);
                digitacao.lblLicaoOLD.Text = Convert.ToString(sql.licao[0]);
                digitacao.lblId.Text = Convert.ToString(sql.id_aluno[0]);
                digitacao.lblLinhasRestantes.Text = Convert.ToString(sql.nvl[0]);
                txtNomeAluno.Clear();
                inicio.ShowDialog();
                digitacao.ShowDialog();

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                txtNomeAluno.Focus();
                txtNomeAluno.SelectAll();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtNomeAluno_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
       
        private void dtgNome_DoubleClick(object sender, EventArgs e)
        {
            txtNomeAluno.Text = dtgNome.CurrentRow.Cells[0].Value.ToString();

        }

        private void dtgNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }

        }

        private void cboNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeAluno.Text = cboNomes.SelectedItem.ToString();
            txtNomeAluno.Focus();
            txtNomeAluno.SelectAll();

        }

        private void txtNomeAluno_MouseClick(object sender, MouseEventArgs e)
        {
            txtNomeAluno.SelectAll();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            frmSenha Key = new frmSenha();
            Key.ShowDialog();
            if (Key.senha == senhaMaster)
            {
                frmProfessor P = new frmProfessor();
                P.ShowDialog();
                Key.senha = "";

            }
            else
            {
                MessageBox.Show("Não tente entrar se você é um aluno!!", "Desista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cboNomes_Click(object sender, EventArgs e)
        {
            cboNomes.DroppedDown = true;
        }
    }
}
