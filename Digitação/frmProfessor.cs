using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }
        Conexao sql = new Conexao();
        string nome;

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dados = sql.Listar("SELECT * FROM aluno ORDER BY aluno.nome ASC");
                dtgDeletar.DataSource = dados;
                DataTable dadoss = sql.ListarAulas("SELECT * FROM digitacao.dbo.aula WHERE digitacao.dbo.aula.licao <> 0 ORDER BY digitacao.dbo.aula.licaoFeitaEm DESC");
                dtgAulas.DataSource = dadoss;
                txtNomeAluno.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Certifique-se de que haja conexão com o servidor", "Conect Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dados = sql.Listar("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC");
                dtgDeletar.DataSource = dados;
                DataTable dados1 = sql.ListarAulas("SELECT * FROM aula WHERE aluno LIKE '%" + txtNomeAluno.Text + "%' ORDER BY aula.licaoFeitaEm DESC");
                dtgAulas.DataSource = dados1;

            }
            catch (Exception)
            {
                //throw;
            }

            if (txtNomeAluno.Text == "")
            {
                txtNomeAluno.Focus();
            }
        }

        private void frmProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //UPDATE aluno SET aluno.licao = 2 WHERE aluno.nome =  'Adrian Tetzner Filgueira'
            sql.Update("UPDATE aluno SET aluno.licao =" + numeroAula.Value + " WHERE aluno.nome =  '" + nome + "'");
            MessageBox.Show("Alterado!");
            //DELETE  FROM digitacao.dbo.aula WHERE aula.aluno = 'Adrian Tetzner Filgueira' AND aula.id_aula = (select max(aula.id_aula) from aula WHERE aula.aluno = 'Adrian Tetzner Filgueira')
            sql.Delete("DELETE  FROM digitacao.dbo.aula WHERE aula.aluno = '" + nome + "' AND aula.id_aula = (select max(aula.id_aula) from aula WHERE aula.aluno = '" + nome + "')");

            var select = Task.Factory.StartNew(() => modificaCbo());
            select.ContinueWith((x) =>
            {
                try
                {

                    DataTable dados = sql.Listar("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC");
                    dtgDeletar.DataSource = dados;
                    DataTable dados1 = sql.ListarAulas("SELECT * FROM aula WHERE aluno LIKE '%" + txtNomeAluno.Text + "%' ORDER BY aula.licaoFeitaEm DESC");
                    dtgAulas.DataSource = dados1;

                }
                catch (Exception)
                {
                    //throw;
                }

            }, TaskScheduler.FromCurrentSynchronizationContext());
            painelLicao.Visible = false;
        }

        private void dtgDeletar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDeletar.Columns[e.ColumnIndex].Name == "excluir" && MessageBox.Show("Deseja realmente deletar " + dtgDeletar.Rows[e.RowIndex].Cells[nomeDataGridViewTextBoxColumn.Index].Value.ToString() + "??", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql.Delete("DELETE  FROM digitacao.dbo.aluno WHERE id_aluno = " + dtgDeletar.Rows[e.RowIndex].Cells[id_aluno.Index].Value.ToString());
                var select = Task.Factory.StartNew(() => modificaCbo());
                select.ContinueWith((x) =>
                {
                    try
                    {

                        DataTable dados = sql.Listar("SELECT * FROM aluno WHERE nome LIKE '%" + txtNomeAluno.Text + "%'  ORDER BY aluno.nome ASC");
                        dtgDeletar.DataSource = dados;
                        DataTable dados1 = sql.ListarAulas("SELECT * FROM aula WHERE aluno LIKE '%" + txtNomeAluno.Text + "%' ORDER BY aula.licaoFeitaEm DESC");
                        dtgAulas.DataSource = dados1;

                    }
                    catch (Exception)
                    {
                        //throw;
                    }

                }, TaskScheduler.FromCurrentSynchronizationContext());

            }
            if (dtgDeletar.Columns[e.ColumnIndex].Name == "licao" && MessageBox.Show("Deseja alterar a lição do aluno " + dtgDeletar.Rows[e.RowIndex].Cells[nomeDataGridViewTextBoxColumn.Index].Value.ToString() + "??", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                numeroAula.Value = sql.SelectLicao("SELECT licao FROM digitacao.dbo.aluno WHERE id_aluno = " + dtgDeletar.Rows[e.RowIndex].Cells[id_aluno.Index].Value.ToString());
                nome = dtgDeletar.Rows[e.RowIndex].Cells[0].Value.ToString();
                painelLicao.Visible = true;

            }
        }
            criptografia crip = new criptografia();
        string ipCadastro;
        private void btnCadastrarIP_Click(object sender, EventArgs e)
        {
            ipCadastro = txtIP.Text;
            crip.Encriptografar(ipCadastro + "true");
            txtIP.Clear();
            txtIP.Focus();
        }

        private void btnCadastrarIP_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtIP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtIP.Text == "senha")
                    {
                        sql.Insert("INSERT INTO server VALUES ('" + ipCadastro + "', '" + crip.senha + "');");
                        //INSERT INTO aluno (nome, nvl, dataCad) VALUES ("Roberto", 1.5, "2018-12-02 7:50:31")
                        MessageBox.Show("Cadastro concluído!", "Sucessso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("INSERT INTO server VALUES ('" + ipCadastro + "', '" + crip.senha + "');");
                    }
                    else
                    {
                        MessageBox.Show("Não tente cadastrar se não for desenvolvedor!!", "Desista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("INSERT INTO server VALUES ('" + ipCadastro + "', '" + crip.senha + "');");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
