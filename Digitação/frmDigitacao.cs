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
        int completoCount;
        int posicao;
        string correta;
        int erros;
        string LicaoTerminada;
        int linhasTerminada;
        int toques;
        int dificuldade = 100;
        double porcentagem;
        int pressiona = 0;
        bool modifica = false;
        int totalLetras;
        /*
        string auxiliar = "";
        bool caps;
        bool shift;
        string pressionada;
        */
        public frmDigitacao()
        {
            InitializeComponent();
        }

        private void frmDigitacao_Load(object sender, EventArgs e)
        {
            Conexao sql = new Conexao();
            rchLicao.Clear();
            txtFinal.Clear();
            sql.Select("SELECT * FROM licoes WHERE numero = " + lblLicaoNEW.Text, 2);
            if (sql.letras != "")
            {
                //lblLicao.Text = sql.letras.ToUpper();
                completo = sql.letras;
                completoCount = Convert.ToInt32(completo.Count());
                int colunas = Convert.ToInt32(lblLinhasRestantes.Text);
                if (sql.letras.Count() < 100)
                {
                    for (int i = 1; i <= Convert.ToInt32(lblLinhasRestantes.Text); i++)
                    {
                        rchLicao.Text += sql.letras + "\n";
                        totalLetras += completo.Count();
                    } 
                }
                else
                {
                    rchLicao.Text = sql.letras;
                    totalLetras += completo.Count();
                    lblLinhasRestantes.Text = "1";
                }

            }
            else
            {
                rchLicao.Text = "Lição não encontrada";
            }
        }
        private void frmDigitacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Tchau");
            Conexao sql = new Conexao();
            sql.letras = "";
            rchLicao.Text = "Lição não encontrada";

        }
        public void VariaveisTempo(int toques)
        {
            
            int count = 1;

            for (int i = 0; i < toques; i++)
            {
                count++;

                porcentagem = (count * 100) / totalLetras;

            }
        }

        private void Tempodeaula_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblLinhasRestantes.Text) != 0)
            {
                lblTempo.Text = String.Format("{0:00}:{1:00}:{2:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds);
                if (posicao != completoCount)
                {
                    txtDigitar.Text = completo[posicao].ToString();

                }

                var select = Task.Factory.StartNew(() => VariaveisTempo(Convert.ToInt32(lblToques.Text)));
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
                Conexao sql = new Conexao();
                DateTime timeUtc = DateTime.UtcNow;
                TimeZoneInfo Zona = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                DateTime Fuso = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, Zona);
                string dataFinal = Convert.ToString(timeUtc).Replace("/", "-");
                //UPDATE aluno SET licao =q, licaoFeitaEm =now(), aproveitamento =q, tempoDecorrido =q, erros =q, toques =q, feita =q WHERE 1
                sql.Update("UPDATE aluno SET licao = " + Convert.ToInt32(lblLicaoNEW.Text) + ", licaoFeitaEm = '" + dataFinal + ".000 ' , aproveitamento = " + Convert.ToInt32(lblAproveitamento.Text.Replace("%", "")) + ", tempoDecorrido = " + Convert.ToInt32(lblTempo.Text.Replace(":", "")) + ", erros = " + Convert.ToInt32(lblErros.Text) + ", toques =" + Convert.ToInt32(lblToquesMin.Text) + ",feita ='" + LicaoTerminada + "' WHERE id_aluno = " + aluno);
                MessageBox.Show("Lição terminada, chame seu professor", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Letra()
        {

            if (txtLetraDigitada.Text.Count() >= 1 && modifica == false)
            {
                Tempodeaula.Enabled = true;
                correta = completo[posicao].ToString();
                label16.Text = pressiona.ToString();
                label17.Text = completoCount.ToString();
                lblToques.Text = Convert.ToString(toques);
                pressiona++;
                posicao++;

                if (correta == txtLetraDigitada.Text)
                {
                    txtFinal.Text += txtLetraDigitada.Text;
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
                if (pressiona != completoCount)
                {


                    var select = Task.Factory.StartNew(() => Rch());
                    select.ContinueWith((x) =>
                    {

                        try
                        {

                            string completoo = rchLicao.Text;
                            string final = "";
                            for (int i = 1; i < completoo.Count(); i++)
                            {
                                final += completoo[i].ToString();
                            }
                            rchLicao.Text = final;
                        }
                        catch (Exception)
                        {

                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
                txtLetraDigitada.Clear();
            }
        }
        private void txtLetraDigitada_TextChanged(object sender, EventArgs e)
        {
            //iniciar o cronometro
            cronometro.Start();

            if (pressiona != completoCount)
            {
                Letra();

            }

            else
            {
                Letra();
                //MessageBox.Show("Linha terminada");
                lblLinhasFeitas.Text = Convert.ToString(Convert.ToInt32(lblLinhasFeitas.Text) + 1);
                lblLinhasRestantes.Text = Convert.ToString(Convert.ToInt32(lblLinhasRestantes.Text) - 1);
                //pressiona = 1;
                posicao = 0;
                txtLetraDigitada.Text = "";
                LicaoTerminada += txtFinal.Text + "///";
                txtFinal.Clear();
                linhasTerminada++;

                var select1 = Task.Factory.StartNew(() => Rch());
                select1.ContinueWith((x) =>
                {

                    try
                    {

                        string completoo = rchLicao.Text;
                        string final = "";
                        for (int i = 2; i < completoo.Count(); i++)
                        {
                            final += completoo[i].ToString();
                        }
                        rchLicao.Text = final;
                    }
                    catch (Exception)
                    {

                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
                pressiona = 0;
                return;
            }
        }
        public void piscaTXT()
        {
            txtDigitar.BackColor = Color.Red;
            txtFinal.BackColor = Color.Red;
            lblErros.BackColor = Color.Red;
            string tecla;
            foreach (Control ctrl in Controls)
            {
                if (txtLetraDigitada.Text.ToUpper() == " ")
                {
                    tecla = "Space";
                }
                else if (txtLetraDigitada.Text.ToUpper() == "Ç")
                {
                    tecla = "Oem1";
                }
                else if (txtLetraDigitada.Text.ToUpper() == "\\")
                {
                    tecla = "OemBackslash";
                }
                else if (txtLetraDigitada.Text.ToUpper() == "?")
                {
                    tecla = "None";
                }
                else
                {
                    tecla = txtLetraDigitada.Text.ToUpper();
                }
                if (ctrl.Name == tecla)
                {
                    ((PictureBox)(ctrl)).BackColor = Color.Red;
                }
            }
        }

        private void txtLetraADigitar_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                Capital.BackColor = Color.Green;
            }
            else
            {
                Capital.BackColor = Color.White;

            }
            foreach (Control ctrl in Controls)
            {
                if (ctrl is PictureBox && ctrl != pbTeclado && ctrl != Capital)
                {
                    if (ctrl.Name == e.KeyCode.ToString())
                    {
                        ((PictureBox)(ctrl)).BackColor = Color.Green;
                    }
                    else
                    {
                        ((PictureBox)(ctrl)).BackColor = Color.White;

                    }
                }
            }
            if (ControlKey.BackColor == Color.Green)
            {
                ControlKey1.BackColor = Color.Green;
            }
            else
            {
                ControlKey1.BackColor = Color.White;
            }

            if (ShiftKey.BackColor == Color.Green)
            {
                ShiftKey1.BackColor = Color.Green;
            }
            else
            {
                ShiftKey1.BackColor = Color.White;
            }

            if (Menu.BackColor == Color.Green)
            {
                Menu1.BackColor = Color.Green;
            }
            else
            {
                Menu1.BackColor = Color.White;
            }

            if (LWin.BackColor == Color.Green)
            {
                LWin1.BackColor = Color.Green;
            }
            else
            {
                LWin1.BackColor = Color.White;
            }
            //txtLetraDigitada.Text

        }
        public void verifica(string letra)
        {
            Conexao sql = new Conexao();
            //sql.letras;
        }
        public void Rch()
        {

        }

        private void piscaDigitar_Tick(object sender, EventArgs e)
        {
            txtDigitar.BackColor = Color.White;
            txtFinal.BackColor = Color.White;
            lblErros.BackColor = Color.Transparent;
            piscaDigitar.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}



/*
 * using System;
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
        int completoCount;
        int letra = 1;
        string pressionada;
        int posicao;
        string correta;
        int erros;
        string LicaoTerminada;
        int linhasTerminada;
        int toques;
        int dificuldade = 200;
        double porcentagem;
        int pressiona = 0;
        string auxiliar = "";
        bool caps;
        bool shift;

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
            KeyDown += new KeyEventHandler(frmDigitacao_KeyDown);
            Conexao sql = new Conexao();
            sql.Select("SELECT * FROM licoes WHERE numero = " + lblLicaoNEW.Text, 2);
            if (sql.letras != "")
            {
                //lblLicao.Text = sql.letras.ToUpper();
                completo = sql.letras;
                completoCount = Convert.ToInt32(completo.Count());
                int colunas = Convert.ToInt32(lblLinhasRestantes.Text);
                for (int i = 0; i <= Convert.ToInt32(lblLinhasRestantes.Text); i++)
                {
                    rchLicao.Text += sql.letras + "\n";
                }

            }
            else
            {
                rchLicao.Text = "Lição não encontrada";
            }

            
            var ii = Convert.ToInt32(lblLinhasRestantes.Text);
            ii = ii + 2;
            lblLinhasRestantes.Text = Convert.ToString(ii);

            //zerar as variaveis

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
        }

        private void frmDigitacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Tchau");
            Conexao sql = new Conexao();
            sql.letras = "";
            rchLicao.Text = "Lição não encontrada";

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
                    txtDigitar.Text = completo[posicao].ToString();

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
                Conexao sql = new Conexao();
                DateTime timeUtc = DateTime.UtcNow;
                TimeZoneInfo Zona = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                DateTime Fuso = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, Zona);
                string dataFinal = Convert.ToString(timeUtc).Replace("/", "-");
                //UPDATE aluno SET licao =q, licaoFeitaEm =now(), aproveitamento =q, tempoDecorrido =q, erros =q, toques =q, feita =q WHERE 1
                sql.Update("UPDATE aluno SET licao = " + Convert.ToInt32(lblLicaoNEW.Text) + ", licaoFeitaEm = '" + dataFinal + ".000 ' , aproveitamento = " + Convert.ToInt32(lblAproveitamento.Text.Replace("%", "")) + ", tempoDecorrido = " + Convert.ToInt32(lblTempo.Text.Replace(":", "")) + ", erros = " + Convert.ToInt32(lblErros.Text) + ", toques =" + Convert.ToInt32(lblToquesMin.Text) + ",feita ='" + LicaoTerminada + "' WHERE id_aluno = " + aluno);
                MessageBox.Show("Lição terminada, chame seu professor", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void txtLetraDigitada_TextChanged(object sender, EventArgs e)
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
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    pressionada = e.KeyCode.ToString().ToUpper();
                    caps = true;
                }
                else
                {
                    pressionada = e.KeyCode.ToString().ToLower();
                    caps = false;
                }

            if (e.KeyCode == Keys.CapsLock)
            {
                caps = !caps;
                return;
            }
            if (e.Shift)
            {
                shift = !shift;
                return;
            }
            correta = completo[posicao].ToString();
            txtLetraDigitada.Clear();
            pressiona++;
            if (letra < completoCount)
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
                    pressionada = "ç";
                }
                /////////////////////////////////////////////ACENTO AGÚDO/////////////////////////////////////////////
                if (e.KeyCode == Keys.OemOpenBrackets)
                {
                    auxiliar = "´";
                    return;

                }
                else if (auxiliar == "´")
                {
                    if (caps == false)
                    {
                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "á";
                        }
                        else if (e.KeyCode == Keys.E)
                        {
                            pressionada = "é";

                        }
                        else if (e.KeyCode == Keys.I)
                        {
                            pressionada = "í";

                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "ó";

                        }
                        else if (e.KeyCode == Keys.U)
                        {
                            pressionada = "ú";

                        } 
                    }
                    else
                    {

                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "Á";
                        }
                        else if (e.KeyCode == Keys.E)
                        {
                            pressionada = "É";

                        }
                        else if (e.KeyCode == Keys.I)
                        {
                            pressionada = "Í";

                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "Ó";

                        }
                        else if (e.KeyCode == Keys.U)
                        {
                            pressionada = "Ú";

                        }
                    }
                    auxiliar = "";
                }
                /////////////////////////////////////////////ACENTO AGÚDO FIM/////////////////////////////////////////////
                /////////////////////////////////////////////ACENTO TIO/////////////////////////////////////////////
                if (e.KeyCode == Keys.Oem7 && shift == false)
                {
                    auxiliar = "~";
                    return;

                }
                else if (auxiliar == "~")
                {
                    if (caps == false)
                    {
                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "ã";
                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "õ";

                        }
                    }
                    else
                    {
                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "Ã";
                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "Õ";

                        }
                    }
                    auxiliar = "";
                }
                /////////////////////////////////////////////ACENTO TIO FIM/////////////////////////////////////////////
                /////////////////////////////////////////////ACENTO CIRCUNFLEXO/////////////////////////////////////////////
                if (e.KeyCode == Keys.Oem7 && shift == true)
                {
                    auxiliar = "^";
                    return;

                }
                else if (auxiliar == "^")
                {
                    if (caps == false)
                    {
                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "â";
                        }
                        else if (e.KeyCode == Keys.E)
                        {
                            pressionada = "ê";

                        }
                        else if (e.KeyCode == Keys.I)
                        {
                            pressionada = "î";

                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "ô";

                        }
                        else if (e.KeyCode == Keys.U)
                        {
                            pressionada = "û";

                        }
                    }
                    else
                    {

                        if (e.KeyCode == Keys.A)
                        {
                            pressionada = "Â";
                        }
                        else if (e.KeyCode == Keys.E)
                        {
                            pressionada = "Ê";

                        }
                        else if (e.KeyCode == Keys.I)
                        {
                            pressionada = "Î";

                        }
                        else if (e.KeyCode == Keys.O)
                        {
                            pressionada = "Ô";

                        }
                        else if (e.KeyCode == Keys.U)
                        {
                            pressionada = "Û";

                        }
                    }
                    auxiliar = "";
                    shift = false;
                }
                /////////////////////////////////////////////ACENTO CIRCUNFLEXO FIM/////////////////////////////////////////////
                if (correta == pressionada)
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
                if (pressiona != completoCount)
                {


                    var select = Task.Factory.StartNew(() => Rch());
                    select.ContinueWith((x) =>
                    {

                        try
                        {

                            string completoo = rchLicao.Text;
                            string final = "";
                            for (int i = 1; i < completoo.Count(); i++)
                            {
                                final += completoo[i].ToString();
                            }
                            rchLicao.Text = final;
                        }
                        catch (Exception)
                        {

                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }

            else
            {
                //MessageBox.Show("Linha terminada");
                lblLinhasFeitas.Text = Convert.ToString(Convert.ToInt32(lblLinhasFeitas.Text) + 1);
                lblLinhasRestantes.Text = Convert.ToString(Convert.ToInt32(lblLinhasRestantes.Text) - 1);
                letra = 1;
                posicao = 0;
                pressionada = "";
                LicaoTerminada += txtFinal.Text + "///";
                txtFinal.Clear();
                linhasTerminada++;

                var select1 = Task.Factory.StartNew(() => Rch());
                select1.ContinueWith((x) =>
                {

                    try
                    {

                        string completoo = rchLicao.Text;
                        string final = "";
                        for (int i = 2; i < completoo.Count(); i++)
                        {
                            final += completoo[i].ToString();
                        }
                        rchLicao.Text = final;
                    }
                    catch (Exception)
                    {

                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
                pressiona = 0;
                return;
            }
            label16.Text = pressiona.ToString();
            label17.Text = completoCount.ToString();
            lblToques.Text = Convert.ToString(toques);
            posicao++;


        }
        public void verifica(string letra)
        {
            Conexao sql = new Conexao();
            //sql.letras;
        }
        public void Rch()
        {

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
*/
