namespace Digitação
{
    partial class frmLogin
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNomes = new System.Windows.Forms.ComboBox();
            this.alunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet1 = new Digitação.digitacaoDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtgNome = new System.Windows.Forms.DataGridView();
            this.alunoTableAdapter1 = new Digitação.digitacaoDataSet1TableAdapters.alunoTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNome)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(104, 10);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(487, 20);
            this.txtNomeAluno.TabIndex = 0;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.txtNomeAluno_TextChanged);
            this.txtNomeAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeAluno_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procurar:";
            // 
            // cboNomes
            // 
            this.cboNomes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNomes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alunoBindingSource1, "nome", true));
            this.cboNomes.DropDownHeight = 100;
            this.cboNomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomes.FormattingEnabled = true;
            this.cboNomes.IntegralHeight = false;
            this.cboNomes.Location = new System.Drawing.Point(266, 36);
            this.cboNomes.Name = "cboNomes";
            this.cboNomes.Size = new System.Drawing.Size(487, 21);
            this.cboNomes.TabIndex = 1;
            this.cboNomes.SelectedIndexChanged += new System.EventHandler(this.cboNomes_SelectedIndexChanged);
            this.cboNomes.Click += new System.EventHandler(this.cboNomes_Click);
            this.cboNomes.MouseLeave += new System.EventHandler(this.cboNomes_MouseLeave);
            // 
            // alunoBindingSource1
            // 
            this.alunoBindingSource1.DataMember = "aluno";
            this.alunoBindingSource1.DataSource = this.digitacaoDataSet1;
            // 
            // digitacaoDataSet1
            // 
            this.digitacaoDataSet1.DataSetName = "digitacaoDataSet1";
            this.digitacaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite seu nome:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(275, 107);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(356, 107);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtgNome
            // 
            this.dtgNome.AutoGenerateColumns = false;
            this.dtgNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.dtgNome.DataSource = this.alunoBindingSource1;
            this.dtgNome.Location = new System.Drawing.Point(3, 190);
            this.dtgNome.Name = "dtgNome";
            this.dtgNome.Size = new System.Drawing.Size(260, 150);
            this.dtgNome.TabIndex = 6;
            // 
            // alunoTableAdapter1
            // 
            this.alunoTableAdapter1.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 343);
            this.Controls.Add(this.dtgNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.cboNomes);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnEntrar;
        public System.Windows.Forms.ComboBox cboNomes;
        public System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnCadastrar;
        private digitacaoDataSet1 digitacaoDataSet1;
        private System.Windows.Forms.BindingSource alunoBindingSource1;
        private digitacaoDataSet1TableAdapters.alunoTableAdapter alunoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dtgNome;
    }
}