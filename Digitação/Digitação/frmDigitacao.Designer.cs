namespace Digitação
{
    partial class frmDigitacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLetraDigitada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLinhasFeitas = new System.Windows.Forms.Label();
            this.lblLinhasRestantes = new System.Windows.Forms.Label();
            this.lblLicao = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeDoAluno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLicaoNEW = new System.Windows.Forms.Label();
            this.lblLicaoOLD = new System.Windows.Forms.Label();
            this.lblDataLicaoOLD = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.Tempodeaula = new System.Windows.Forms.Timer(this.components);
            this.txtDigitar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.piscaDigitar = new System.Windows.Forms.Timer(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblToques = new System.Windows.Forms.Label();
            this.lblToquesMin = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblAproveitamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lição Atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aproveitamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Última Lição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Feita em:";
            // 
            // txtLetraDigitada
            // 
            this.txtLetraDigitada.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetraDigitada.Location = new System.Drawing.Point(101, 171);
            this.txtLetraDigitada.MaxLength = 1000;
            this.txtLetraDigitada.Name = "txtLetraDigitada";
            this.txtLetraDigitada.Size = new System.Drawing.Size(47, 32);
            this.txtLetraDigitada.TabIndex = 0;
            this.txtLetraDigitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetraDigitada.TextChanged += new System.EventHandler(this.txtLetraADigitar_TextChanged);
            this.txtLetraDigitada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetraADigitar_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Digitou: ";
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(12, 278);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(945, 32);
            this.txtFinal.TabIndex = 1;
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(12, 316);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(945, 204);
            this.pbImagem.TabIndex = 5;
            this.pbImagem.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Restam: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Feitas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblLinhasFeitas);
            this.groupBox1.Controls.Add(this.lblLinhasRestantes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(611, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linhas:";
            // 
            // lblLinhasFeitas
            // 
            this.lblLinhasFeitas.AutoSize = true;
            this.lblLinhasFeitas.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhasFeitas.Location = new System.Drawing.Point(80, 22);
            this.lblLinhasFeitas.Name = "lblLinhasFeitas";
            this.lblLinhasFeitas.Size = new System.Drawing.Size(21, 23);
            this.lblLinhasFeitas.TabIndex = 3;
            this.lblLinhasFeitas.Text = "0";
            // 
            // lblLinhasRestantes
            // 
            this.lblLinhasRestantes.AutoSize = true;
            this.lblLinhasRestantes.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinhasRestantes.Location = new System.Drawing.Point(241, 22);
            this.lblLinhasRestantes.Name = "lblLinhasRestantes";
            this.lblLinhasRestantes.Size = new System.Drawing.Size(21, 23);
            this.lblLinhasRestantes.TabIndex = 3;
            this.lblLinhasRestantes.Text = "3";
            // 
            // lblLicao
            // 
            this.lblLicao.AutoSize = true;
            this.lblLicao.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicao.Location = new System.Drawing.Point(12, 252);
            this.lblLicao.Name = "lblLicao";
            this.lblLicao.Size = new System.Drawing.Size(620, 25);
            this.lblLicao.TabIndex = 3;
            this.lblLicao.Text = "ASDFG ASDFG ASDFG ASDFG ASDFG ASDFG ASDFG ASDF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Toques:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(245, 537);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Toques/Min:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(585, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Erros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno:";
            // 
            // NomeDoAluno
            // 
            this.NomeDoAluno.AutoSize = true;
            this.NomeDoAluno.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeDoAluno.Location = new System.Drawing.Point(97, 9);
            this.NomeDoAluno.Name = "NomeDoAluno";
            this.NomeDoAluno.Size = new System.Drawing.Size(253, 23);
            this.NomeDoAluno.TabIndex = 7;
            this.NomeDoAluno.Text = "Aqui vai o nome do aluno";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(963, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 212);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLicaoNEW
            // 
            this.lblLicaoNEW.AutoSize = true;
            this.lblLicaoNEW.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicaoNEW.Location = new System.Drawing.Point(133, 85);
            this.lblLicaoNEW.Name = "lblLicaoNEW";
            this.lblLicaoNEW.Size = new System.Drawing.Size(222, 23);
            this.lblLicaoNEW.TabIndex = 3;
            this.lblLicaoNEW.Text = "Número da lição NEW";
            // 
            // lblLicaoOLD
            // 
            this.lblLicaoOLD.AutoSize = true;
            this.lblLicaoOLD.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicaoOLD.Location = new System.Drawing.Point(746, 41);
            this.lblLicaoOLD.Name = "lblLicaoOLD";
            this.lblLicaoOLD.Size = new System.Drawing.Size(216, 23);
            this.lblLicaoOLD.TabIndex = 3;
            this.lblLicaoOLD.Text = "Nomero da lição OLD";
            // 
            // lblDataLicaoOLD
            // 
            this.lblDataLicaoOLD.AutoSize = true;
            this.lblDataLicaoOLD.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLicaoOLD.Location = new System.Drawing.Point(717, 73);
            this.lblDataLicaoOLD.Name = "lblDataLicaoOLD";
            this.lblDataLicaoOLD.Size = new System.Drawing.Size(181, 23);
            this.lblDataLicaoOLD.TabIndex = 3;
            this.lblDataLicaoOLD.Text = "Data da lição OLD";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(81, 125);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(274, 23);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Aqui vai o número do aluno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Aluno:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(289, 41);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(88, 23);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "00:00:00";
            // 
            // Tempodeaula
            // 
            this.Tempodeaula.Tick += new System.EventHandler(this.Tempodeaula_Tick);
            // 
            // txtDigitar
            // 
            this.txtDigitar.Enabled = false;
            this.txtDigitar.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitar.Location = new System.Drawing.Point(101, 219);
            this.txtDigitar.MaxLength = 1000;
            this.txtDigitar.Name = "txtDigitar";
            this.txtDigitar.Size = new System.Drawing.Size(47, 32);
            this.txtDigitar.TabIndex = 0;
            this.txtDigitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigitar.TextChanged += new System.EventHandler(this.txtLetraADigitar_TextChanged);
            this.txtDigitar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetraADigitar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Digitar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piscaDigitar
            // 
            this.piscaDigitar.Interval = 300;
            this.piscaDigitar.Tick += new System.EventHandler(this.piscaDigitar_Tick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(418, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(494, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "label16";
            // 
            // lblToques
            // 
            this.lblToques.AutoSize = true;
            this.lblToques.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToques.Location = new System.Drawing.Point(97, 537);
            this.lblToques.Name = "lblToques";
            this.lblToques.Size = new System.Drawing.Size(21, 23);
            this.lblToques.TabIndex = 3;
            this.lblToques.Text = "0";
            // 
            // lblToquesMin
            // 
            this.lblToquesMin.AutoSize = true;
            this.lblToquesMin.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToquesMin.Location = new System.Drawing.Point(379, 537);
            this.lblToquesMin.Name = "lblToquesMin";
            this.lblToquesMin.Size = new System.Drawing.Size(21, 23);
            this.lblToquesMin.TabIndex = 3;
            this.lblToquesMin.Text = "0";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.Location = new System.Drawing.Point(662, 537);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(21, 23);
            this.lblErros.TabIndex = 3;
            this.lblErros.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(732, 537);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(852, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 23);
            this.label18.TabIndex = 3;
            this.label18.Text = "Nota:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(918, 575);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(21, 23);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "0";
            // 
            // lblAproveitamento
            // 
            this.lblAproveitamento.AutoSize = true;
            this.lblAproveitamento.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproveitamento.Location = new System.Drawing.Point(352, 199);
            this.lblAproveitamento.Name = "lblAproveitamento";
            this.lblAproveitamento.Size = new System.Drawing.Size(63, 23);
            this.lblAproveitamento.TabIndex = 3;
            this.lblAproveitamento.Text = "000%";
            // 
            // frmDigitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 607);
            this.Controls.Add(this.lblAproveitamento);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblLicaoOLD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.NomeDoAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblDataLicaoOLD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLicao);
            this.Controls.Add(this.lblToquesMin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblToques);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLicaoNEW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDigitar);
            this.Controls.Add(this.txtLetraDigitada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmDigitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIgitação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDigitacao_FormClosed);
            this.Load += new System.EventHandler(this.frmDigitacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDigitacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLetraDigitada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label NomeDoAluno;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblLicaoNEW;
        public System.Windows.Forms.Label lblLicaoOLD;
        public System.Windows.Forms.Label lblDataLicaoOLD;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblLinhasRestantes;
        public System.Windows.Forms.Label lblLicao;
        private System.Windows.Forms.Label lblTempo;
        public System.Windows.Forms.Timer Tempodeaula;
        public System.Windows.Forms.Label lblLinhasFeitas;
        private System.Windows.Forms.TextBox txtDigitar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer piscaDigitar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblToques;
        private System.Windows.Forms.Label lblToquesMin;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblAproveitamento;
        public System.Windows.Forms.TextBox txtFinal;
    }
}

