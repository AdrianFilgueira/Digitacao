using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmDigitacao : Form
    {
        public int aluno;
        Stopwatch cronometro = new Stopwatch();
        string completo = "";
        string ltt = "ASDFG ASDFG ASDFG ASDFG ASDFG ASDFG ASDFG ASDF";
        int completoCount;
        int letra;
        string pressionada;
        int posicao;
        string correta;
        int erros;
        string LicaoTerminada;
        int linhasTerminada;
        int toques;
        int dificuldade = 200;
        double porcentagem;
        public frmDigitacao()
        {
            InitializeComponent();
        }

        private void txtLicaoAtual_TextChanged(object sender, EventArgs e)
        {
            //= UltimaLicao + 1
        }

        private void frmDigitacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmDigitacao_Load(object sender, EventArgs e)
        {
            if (ltt != "")
            {
                lblLicao.Text = ltt.ToUpper();
                completo = ltt;
                completoCount = Convert.ToInt32(completo.Count());
                int colunas = Convert.ToInt32(lblLinhasRestantes.Text);

            }
            else
            {
                lblLicao.Text = "Lição não encontrada";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
        }

        private void frmDigitacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Tchau");
            Query sql = new Query();
            sql.letras = "";
            lblLicao.Text = "Lição não encontrada";

        }
        public void VariaveisTempo(int toques)
        {

            int count = 1;

            for (int i = 0; i < toques; i++)
            {
                count++;

                porcentagem = (count * 100) / dificuldade;

            }
        }

        private void Tempodeaula_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblLinhasRestantes.Text)!= 0)
            {
                lblTempo.Text = String.Format("{0:00}:{1:00}:{2:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds);
                if (posicao != completoCount)
                {
                    txtDigitar.Text = completo[posicao].ToString().ToUpper();

                }

                var select = Task.Factory.StartNew(() => VariaveisTempo(Convert.ToInt32(lblToquesMin.Text)));
                select.ContinueWith((x) =>
                {
                    try
                    {
                        lblToquesMin.Text = Convert.ToString(toques * 60 / Convert.ToInt32(lblTempo.Text.Replace(":", "")));
                        lblAproveitamento.Text = Convert.ToString(porcentagem) + "%";
                        progressBar1.PerformStep();
                        progressBar1.Value = Convert.ToInt32(lblAproveitamento.Text.Replace("%", ""));

                    }
                    catch (Exception)
                    {

                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                cronometro.Stop();
                Tempodeaula.Enabled = false;
                txtLetraDigitada.Enabled = false;
                LicaoTerminada += txtFinal.Text;
                Query sql = new Query();
                //UPDATE aluno SET licao =q, licaoFeitaEm =now(), aproveitamento =q, tempoDecorrido =q, erros =q, toques =q, feita =q WHERE 1
                sql.Update("UPDATE aluno SET licao = " + Convert.ToInt32(lblLicaoNEW.Text) + ", licaoFeitaEm =now(), aproveitamento = " + Convert.ToInt32(lblAproveitamento.Text.Replace("%", "")) + ", tempoDecorrido = " + Convert.ToInt32(lblTempo.Text.Replace(":", "")) + ", erros = " + Convert.ToInt32(lblErros.Text) + ", toques =" + Convert.ToInt32(lblToquesMin.Text) + ",feita =\"" + LicaoTerminada + "\" WHERE id_aluno = " + aluno);
                MessageBox.Show("Lição terminada, chame seu professor", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void txtLetraADigitar_TextChanged(object sender, EventArgs e)
        {
            txtLetraDigitada.Text = pressionada;
            Tempodeaula.Enabled = true;

            //iniciar o cronometro
            cronometro.Start();
        }

        public void piscaTXT()
        {
            txtDigitar.BackColor = Color.Red;
            txtFinal.BackColor = Color.Red;
            lblErros.BackColor = Color.Red;
        }

        private void txtLetraADigitar_KeyDown(object sender, KeyEventArgs e)
        {

                pressionada = e.KeyCode.ToString();
                correta = completo[posicao].ToString();
                txtLetraDigitada.Clear();
                if (letra + 1 < completoCount)
                {
                    letra++;
                    //txtLetraADigitar.Text += e.KeyCode.ToString();
                    if (e.KeyCode == Keys.Space)
                    {
                        pressionada = " ";
                        txtFinal.Text += " ";

                    }

                    else if (e.KeyCode == Keys.Back)
                    {
                        MessageBox.Show("Não tente apagar ou isso irá gerar mais erros!!");
                        txtFinal.Text += "";
                        pressionada = "";
                    }
                    else if (e.KeyCode == Keys.Oem1)
                    {
                        pressionada = "Ç";
                    }

                    if (correta.ToUpper() == pressionada)
                    {
                        txtFinal.Text += pressionada;
                        toques++;
                    }
                    else
                    {
                        txtFinal.Text += "?";
                        erros++;
                        lblErros.Text = erros.ToString();
                        SystemSounds.Beep.Play();
                        piscaTXT();
                        piscaDigitar.Enabled = true;
                    }
                }

                else
                {
                    //MessageBox.Show("Linha terminada");
                    lblLinhasFeitas.Text = Convert.ToString(Convert.ToInt32(lblLinhasFeitas.Text) + 1);
                    lblLinhasRestantes.Text = Convert.ToString(Convert.ToInt32(lblLinhasRestantes.Text) - 1);
                    letra = 0;
                    posicao = 0;
                    pressionada = "";
                    LicaoTerminada += txtFinal.Text + "///";
                    txtFinal.Clear();
                    linhasTerminada++;
                    return;

                }

                label16.Text = letra.ToString();
                label17.Text = completoCount.ToString();
                lblToques.Text = Convert.ToString(toques);
                posicao++;

        }
        public void verifica(string letra)
        {
            Query sql = new Query();
            //sql.letras;
        }

        private void piscaDigitar_Tick(object sender, EventArgs e)
        {
            txtDigitar.BackColor = Color.White;
            txtFinal.BackColor = Color.White;
            lblErros.BackColor = Color.Transparent;
            piscaDigitar.Enabled = false;
        }
    }
}
