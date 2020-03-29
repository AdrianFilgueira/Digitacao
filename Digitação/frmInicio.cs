using System;
using System.Linq;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmInicio : Form
    {
        Conexao sql = new Conexao();
        ipPass verificacao = new ipPass();
        public int licaoAtual;
        public string licaoNEW;
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {

                tempoInicio.Enabled = true;

                if (sql.SelectLicao("SELECT aluno.id_aluno FROM aluno, aula where aula.licao = " + licaoAtual) != 0)
                {

                    //SELECT aluno.nome, aula.aproveitamento from aula, aluno WHERE aula.aproveitamento = (select max(aula.aproveitamento) from aula where aula.licao = 3) AND aluno.nome = aula.aluno
                    lblAproveitamento.Text = sql.Select("SELECT aluno.nome, aula.aproveitamento from aula, aluno WHERE aula.aproveitamento = (select max(aula.aproveitamento) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero + "% de Aproveitamento";
                    //SELECT aluno.nome, aula.erros from aula, aluno WHERE aula.erros = (select min(aula.erros) from aula where aula.licao = 1) AND aluno.nome = aula.aluno
                    lblErros.Text = sql.Select("SELECT aluno.nome, aula.erros from aula, aluno WHERE aula.erros = (select min(aula.erros) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero + " Erros";
                    //SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = 3) AND aluno.nome = aula.aluno
                    sql.Select("SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno");
                    int total = sql.Numero.Count();
                    if (total == 2)
                    {
                        lblTempo.Text = sql.Select("SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero + " Segundos";//.Substring(0, total-4) + ":" + sql.Numero.Substring(total-4, total-2) + ":" + sql.Numero.Substring(total-2, total) 

                    }
                    else if (total == 3)
                    {
                        lblTempo.Text = sql.Select("SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero.Substring(0, 1) + ":" + sql.Numero.Substring(1, 2) + " Minutos";

                    }
                    else if (total == 4)
                    {
                        lblTempo.Text = sql.Select("SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero.Substring(0, 2) + ":" + sql.Numero.Substring(2, 2) + " Minutos";

                    }
                    else if (total == 5)
                    {
                        lblTempo.Text = sql.Select("SELECT aluno.nome, aula.tempoDecorrido from aula, aluno WHERE aula.tempoDecorrido = (select min(aula.tempoDecorrido) from aula where aula.licao = " + licaoAtual + ") AND aluno.nome = aula.aluno") + " Com " + sql.Numero.Substring(0, 1) + ":" + sql.Numero.Substring(1, 2) + ":" + sql.Numero.Substring(3, 2) + " Minutos";

                    }

                }
                else
                {
                    lblAproveitamento.Text = "Seja o primeiro a realizar essa lição!";
                    lblErros.Text = "Seja o primeiro a realizar essa lição!";
                    lblTempo.Text = "Seja o primeiro a realizar essa lição!";
                }

                Cor();
            }
            catch (Exception)
            {
                Cor();

            }
        }
        string [] l = new string[0];
        public void Cor()
        {
            try
            {
                sql.Select("SELECT * FROM licoes WHERE numero = " + licaoAtual, 2);
                string letra = sql.letras.ToUpper();
                for (int i = 0; i < letra.Count(); i++)
                {
                    Array.Resize(ref l, l.Length + 1);
                    l[i] = letra[i].ToString();
                }
                /*
                for (int i = 0; i < letra.Count(); i++)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Name != "pbTeclado" && ctrl.Name != "pbTrufeu" && ctrl.Name != "pbMao" && ctrl.Name == l[i])
                        {
                            ((PictureBox)(ctrl)).BackColor = System.Drawing.Color.White;
                        }
                    }
                }*/
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is PictureBox && ctrl.Name != "pbTeclado" && ctrl.Name != "pbTrufeu" && ctrl.Name != "pbMao")
                    {
                        ((PictureBox)(ctrl)).BackColor = System.Drawing.Color.White;
                    }
                }
                foreach (string ll in l)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            Colorir(ll);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public void Colorir(string Tecla)
        {
            if (Tecla == "1" || Tecla == "!")
            {
                D1.BackColor = System.Drawing.Color.DarkTurquoise;
            }
            if (Tecla == "Q")
            {
                Q.BackColor = System.Drawing.Color.DarkTurquoise;
            }
            if (Tecla == "A")
            {
                A.BackColor = System.Drawing.Color.DarkTurquoise;
            }
            if (Tecla == "Z")
            {
                Z.BackColor = System.Drawing.Color.DarkTurquoise;
            }
            if (Tecla == "\\")
            {
                OemBackslash.BackColor = System.Drawing.Color.DarkTurquoise;
            }


            if (Tecla == "2" || Tecla == "@")
            {
                D2.BackColor = System.Drawing.Color.DarkOrange;
            }
            if (Tecla == "W")
            {
                W.BackColor = System.Drawing.Color.DarkOrange;
            }
            if (Tecla == "S")
            {
               S.BackColor = System.Drawing.Color.DarkOrange;
            }
            if (Tecla == "X")
            {
                X.BackColor = System.Drawing.Color.DarkOrange;
            }


            if (Tecla == "3" || Tecla == "#")
            {
                D3.BackColor = System.Drawing.Color.Green;
            }
            if (Tecla == "E")
            {
                E.BackColor = System.Drawing.Color.Green;
            }
            if (Tecla == "D")
            {
                D.BackColor = System.Drawing.Color.Green;
            }
            if (Tecla == "C")
            {
                C.BackColor = System.Drawing.Color.Green;
            }


            if (Tecla == "4" || Tecla == "$")
            {
                D4.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "R")
            {
                R.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "F")
            {
                F.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "V")
            {
                V.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "5" || Tecla == "%")
            {
                D5.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "T")
            {
                T.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "G")
            {
                G.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "B")
            {
                B.BackColor = System.Drawing.Color.DarkMagenta;
            }
            if (Tecla == "6" || Tecla == "¨")
            {
                D6.BackColor = System.Drawing.Color.DarkMagenta;
            }


            if (Tecla == "7" || Tecla == "&")
            {
                D7.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "Y")
            {
                Y.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "H")
            {
                H.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "N")
            {
                N.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "8" || Tecla == "*")
            {
                D5.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "U")
            {
                U.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "J")
            {
                J.BackColor = System.Drawing.Color.Salmon;
            }
            if (Tecla == "M")
            {
                M.BackColor = System.Drawing.Color.Salmon;
            }


            if (Tecla == "9" || Tecla == "(")
            {
                D9.BackColor = System.Drawing.Color.Gold;
            }
            if (Tecla == "I")
            {
                I.BackColor = System.Drawing.Color.Gold;
            }
            if (Tecla == "K")
            {
                K.BackColor = System.Drawing.Color.Gold;
            }
            if (Tecla == ",")
            {
                Oemcomma.BackColor = System.Drawing.Color.Gold;
            }

            
            if (Tecla == "0" || Tecla == "0")
            {
                D0.BackColor = System.Drawing.Color.Magenta;
            }
            if (Tecla == "O")
            {
                O.BackColor = System.Drawing.Color.Magenta;
            }
            if (Tecla == "L")
            {
                L.BackColor = System.Drawing.Color.Magenta;
            }
            if (Tecla == ".")
            {
                OemPeriod.BackColor = System.Drawing.Color.Magenta;
            }

            
            if (Tecla == "-" || Tecla == "_")
            {
                OemMinus.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "P")
            {
                P.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "Ç")
            {
                Oem1.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == ";" || Tecla == ":")
            {
                OemQuestion.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "=" || Tecla == "+")
            {
                Oemplus.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "[" || Tecla == "{" || Tecla == "ª")
            {
                Oem6.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "]" || Tecla == "}" || Tecla == "º")
            {
                Oem5.BackColor = System.Drawing.Color.Red;
            }
            if (Tecla == "?" || Tecla == "/" || Tecla == "º")
            {
                None.BackColor = System.Drawing.Color.Red;
            }


            if (Tecla == " ")
            {
                Space.BackColor = System.Drawing.Color.DodgerBlue;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int contaPassadas = 0;
        private void tempoInicio_Tick(object sender, EventArgs e)
        {
            if (contaPassadas < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    progressBar1.Value++;

                }
                tempo.Text = Convert.ToString(Convert.ToInt32(tempo.Text.Replace("...", "")) - 1) + "..."; 
                contaPassadas++;
            }
            else
            {
                this.Close();
            }
        }
    }
}
