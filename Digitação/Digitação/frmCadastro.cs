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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
            Query sql = new Query();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double nivel = 0;
            if (rbFacil.Checked == true)
            {
                //MessageBox.Show("Fácil");
                nivel = 10;
            }
            else
            {
                if (rbMedio.Checked == true)
                {
                    //MessageBox.Show("Médio");
                    nivel = 20;
                }
                else
                {
                    if (rbDificil.Checked == true)
                    {
                        //MessageBox.Show("Difícil");
                        nivel = 25;
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecione o nível desejado", "Selecione o nível", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbFacil.Focus();
                        return;
                        /*if (MessageBox.Show("Deseja personallizar o nível?", "Personalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                        }*/

                    }
                }
            }

            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Insira um nome de usuário", "Insira nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeAluno.Focus();
                return;
            }
            else
            {
                if (txtNomeAluno.TextLength < 10)
                {
                    MessageBox.Show("Insira um nome de usuário completo com sobrenome", "Insira nome completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeAluno.Focus();
                    return;
                }
            }
            //02-12-2018 to 2018-12-02
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            
            string data = dateTimePicker1.Text;
            sql.Insert("INSERT INTO ", "aluno", "(nome, nvl, dataCad) VALUES (\"" + txtNomeAluno.Text + "\"" + ", " + nivel + ", \""+ data + "\")");
            Close();
            //INSERT INTO aluno (nome, nvl, dataCad) VALUES ("Roberto", 1.5, "2018-12-02 7:50:31")
            //INSERT INTO `aluno` (`id_aluno`, `nome`, `licao`, `licaoFeitaEm`, `aproveitamento`, `tempoDecorrido`, `erros`, `dataCad`) VALUES (NULL, 'Ronaldo', NULL, NULL, NULL, NULL, NULL, CURRENT_TIMESTAMP);
        }

        private void frmCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
