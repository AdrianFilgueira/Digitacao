namespace Digitação
{
    partial class frmInicio
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
            this.txtNomeMelhor = new System.Windows.Forms.TextBox();
            this.txtMenorTempo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMenosErros = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeMelhor
            // 
            this.txtNomeMelhor.Location = new System.Drawing.Point(137, 27);
            this.txtNomeMelhor.Name = "txtNomeMelhor";
            this.txtNomeMelhor.Size = new System.Drawing.Size(367, 20);
            this.txtNomeMelhor.TabIndex = 14;
            // 
            // txtMenorTempo
            // 
            this.txtMenorTempo.Location = new System.Drawing.Point(137, 79);
            this.txtMenorTempo.Name = "txtMenorTempo";
            this.txtMenorTempo.Size = new System.Drawing.Size(367, 20);
            this.txtMenorTempo.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(510, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Tempo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Menor tempo:";
            // 
            // txtMenosErros
            // 
            this.txtMenosErros.Location = new System.Drawing.Point(137, 53);
            this.txtMenosErros.Name = "txtMenosErros";
            this.txtMenosErros.Size = new System.Drawing.Size(367, 20);
            this.txtMenosErros.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(510, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Erros";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Menos erros nessa lição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Melhor nessa lição:";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.txtNomeMelhor);
            this.Controls.Add(this.txtMenorTempo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMenosErros);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeMelhor;
        private System.Windows.Forms.TextBox txtMenorTempo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMenosErros;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
    }
}