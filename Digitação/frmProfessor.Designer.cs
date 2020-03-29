namespace Digitação
{
    partial class frmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            this.dtgAulas = new System.Windows.Forms.DataGridView();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoFeitaEmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aproveitamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDecorridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toquesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet2 = new Digitação.digitacaoDataSet2();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new Digitação.digitacaoDataSet2TableAdapters.aulaTableAdapter();
            this.tableAdapterManager = new Digitação.digitacaoDataSet2TableAdapters.TableAdapterManager();
            this.dtgDeletar = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet1 = new Digitação.digitacaoDataSet1();
            this.alunoTableAdapter = new Digitação.digitacaoDataSet1TableAdapters.alunoTableAdapter();
            this.tableAdapterManager1 = new Digitação.digitacaoDataSet1TableAdapters.TableAdapterManager();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroAula = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.painelLicao = new System.Windows.Forms.Panel();
            this.btnCadastrarIP = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroAula)).BeginInit();
            this.painelLicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAulas
            // 
            this.dtgAulas.AllowUserToAddRows = false;
            this.dtgAulas.AllowUserToDeleteRows = false;
            this.dtgAulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAulas.AutoGenerateColumns = false;
            this.dtgAulas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgAulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alunoDataGridViewTextBoxColumn,
            this.licaoDataGridViewTextBoxColumn,
            this.licaoFeitaEmDataGridViewTextBoxColumn,
            this.aproveitamentoDataGridViewTextBoxColumn,
            this.tempoDecorridoDataGridViewTextBoxColumn,
            this.errosDataGridViewTextBoxColumn,
            this.toquesDataGridViewTextBoxColumn,
            this.feitaDataGridViewTextBoxColumn});
            this.dtgAulas.DataSource = this.aulaBindingSource1;
            this.dtgAulas.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtgAulas.Location = new System.Drawing.Point(468, 42);
            this.dtgAulas.Name = "dtgAulas";
            this.dtgAulas.ReadOnly = true;
            this.dtgAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAulas.Size = new System.Drawing.Size(688, 280);
            this.dtgAulas.TabIndex = 8;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            this.alunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.alunoDataGridViewTextBoxColumn.Width = 200;
            // 
            // licaoDataGridViewTextBoxColumn
            // 
            this.licaoDataGridViewTextBoxColumn.DataPropertyName = "licao";
            this.licaoDataGridViewTextBoxColumn.HeaderText = "Lição";
            this.licaoDataGridViewTextBoxColumn.Name = "licaoDataGridViewTextBoxColumn";
            this.licaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.licaoDataGridViewTextBoxColumn.Width = 50;
            // 
            // licaoFeitaEmDataGridViewTextBoxColumn
            // 
            this.licaoFeitaEmDataGridViewTextBoxColumn.DataPropertyName = "licaoFeitaEm";
            this.licaoFeitaEmDataGridViewTextBoxColumn.HeaderText = "Data Lição";
            this.licaoFeitaEmDataGridViewTextBoxColumn.Name = "licaoFeitaEmDataGridViewTextBoxColumn";
            this.licaoFeitaEmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aproveitamentoDataGridViewTextBoxColumn
            // 
            this.aproveitamentoDataGridViewTextBoxColumn.DataPropertyName = "aproveitamento";
            this.aproveitamentoDataGridViewTextBoxColumn.HeaderText = "Aproveitamento";
            this.aproveitamentoDataGridViewTextBoxColumn.Name = "aproveitamentoDataGridViewTextBoxColumn";
            this.aproveitamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempoDecorridoDataGridViewTextBoxColumn
            // 
            this.tempoDecorridoDataGridViewTextBoxColumn.DataPropertyName = "tempoDecorrido";
            this.tempoDecorridoDataGridViewTextBoxColumn.HeaderText = "Duração (MM:ss)";
            this.tempoDecorridoDataGridViewTextBoxColumn.Name = "tempoDecorridoDataGridViewTextBoxColumn";
            this.tempoDecorridoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errosDataGridViewTextBoxColumn
            // 
            this.errosDataGridViewTextBoxColumn.DataPropertyName = "erros";
            this.errosDataGridViewTextBoxColumn.HeaderText = "Erros";
            this.errosDataGridViewTextBoxColumn.Name = "errosDataGridViewTextBoxColumn";
            this.errosDataGridViewTextBoxColumn.ReadOnly = true;
            this.errosDataGridViewTextBoxColumn.Width = 50;
            // 
            // toquesDataGridViewTextBoxColumn
            // 
            this.toquesDataGridViewTextBoxColumn.DataPropertyName = "toques";
            this.toquesDataGridViewTextBoxColumn.HeaderText = "Toques";
            this.toquesDataGridViewTextBoxColumn.Name = "toquesDataGridViewTextBoxColumn";
            this.toquesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feitaDataGridViewTextBoxColumn
            // 
            this.feitaDataGridViewTextBoxColumn.DataPropertyName = "feita";
            this.feitaDataGridViewTextBoxColumn.HeaderText = "Lição feita";
            this.feitaDataGridViewTextBoxColumn.Name = "feitaDataGridViewTextBoxColumn";
            this.feitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulaBindingSource1
            // 
            this.aulaBindingSource1.DataMember = "aula";
            this.aulaBindingSource1.DataSource = this.digitacaoDataSet2BindingSource;
            // 
            // digitacaoDataSet2BindingSource
            // 
            this.digitacaoDataSet2BindingSource.DataSource = this.digitacaoDataSet2;
            this.digitacaoDataSet2BindingSource.Position = 0;
            // 
            // digitacaoDataSet2
            // 
            this.digitacaoDataSet2.DataSetName = "digitacaoDataSet2";
            this.digitacaoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaBindingSource
            // 
            this.aulaBindingSource.DataMember = "aula";
            // 
            // aulaTableAdapter
            // 
            this.aulaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aulaTableAdapter = this.aulaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Digitação.digitacaoDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtgDeletar
            // 
            this.dtgDeletar.AllowUserToAddRows = false;
            this.dtgDeletar.AllowUserToDeleteRows = false;
            this.dtgDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgDeletar.AutoGenerateColumns = false;
            this.dtgDeletar.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgDeletar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDeletar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeletar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.dataCadDataGridViewTextBoxColumn,
            this.id_aluno,
            this.licao,
            this.excluir});
            this.dtgDeletar.DataSource = this.alunoBindingSource;
            this.dtgDeletar.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtgDeletar.Location = new System.Drawing.Point(12, 42);
            this.dtgDeletar.Name = "dtgDeletar";
            this.dtgDeletar.ReadOnly = true;
            this.dtgDeletar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDeletar.Size = new System.Drawing.Size(442, 280);
            this.dtgDeletar.TabIndex = 9;
            this.dtgDeletar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDeletar_CellClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataCadDataGridViewTextBoxColumn
            // 
            this.dataCadDataGridViewTextBoxColumn.DataPropertyName = "dataCad";
            this.dataCadDataGridViewTextBoxColumn.HeaderText = "Data do cadastro";
            this.dataCadDataGridViewTextBoxColumn.Name = "dataCadDataGridViewTextBoxColumn";
            this.dataCadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_aluno
            // 
            this.id_aluno.DataPropertyName = "id_aluno";
            this.id_aluno.HeaderText = "id_aluno";
            this.id_aluno.Name = "id_aluno";
            this.id_aluno.ReadOnly = true;
            this.id_aluno.Visible = false;
            // 
            // licao
            // 
            this.licao.DataPropertyName = "licao";
            this.licao.HeaderText = "Lição";
            this.licao.Name = "licao";
            this.licao.ReadOnly = true;
            this.licao.Width = 50;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Image = global::Digitação.Properties.Resources.lixeiraOficiall;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.excluir.Width = 50;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.digitacaoDataSet1;
            // 
            // digitacaoDataSet1
            // 
            this.digitacaoDataSet1.DataSetName = "digitacaoDataSet1";
            this.digitacaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.alunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Digitação.digitacaoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeAluno.Location = new System.Drawing.Point(12, 12);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(442, 20);
            this.txtNomeAluno.TabIndex = 10;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.txtNomeAluno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insira a lição:";
            // 
            // numeroAula
            // 
            this.numeroAula.Location = new System.Drawing.Point(79, 4);
            this.numeroAula.Name = "numeroAula";
            this.numeroAula.Size = new System.Drawing.Size(44, 20);
            this.numeroAula.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(130, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(33, 21);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // painelLicao
            // 
            this.painelLicao.Controls.Add(this.label1);
            this.painelLicao.Controls.Add(this.btnOK);
            this.painelLicao.Controls.Add(this.numeroAula);
            this.painelLicao.Location = new System.Drawing.Point(468, 5);
            this.painelLicao.Name = "painelLicao";
            this.painelLicao.Size = new System.Drawing.Size(173, 31);
            this.painelLicao.TabIndex = 15;
            this.painelLicao.Visible = false;
            // 
            // btnCadastrarIP
            // 
            this.btnCadastrarIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarIP.Location = new System.Drawing.Point(1081, 9);
            this.btnCadastrarIP.Name = "btnCadastrarIP";
            this.btnCadastrarIP.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarIP.TabIndex = 16;
            this.btnCadastrarIP.Text = "Cadastrar IP";
            this.btnCadastrarIP.UseVisualStyleBackColor = true;
            this.btnCadastrarIP.Click += new System.EventHandler(this.btnCadastrarIP_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(936, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 17;
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIP_KeyDown);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 334);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnCadastrarIP);
            this.Controls.Add(this.painelLicao);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.dtgDeletar);
            this.Controls.Add(this.dtgAulas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Alunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProfessor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroAula)).EndInit();
            this.painelLicao.ResumeLayout(false);
            this.painelLicao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAulas;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private digitacaoDataSet2TableAdapters.aulaTableAdapter aulaTableAdapter;
        private digitacaoDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgDeletar;
        private digitacaoDataSet1 digitacaoDataSet1;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private digitacaoDataSet1TableAdapters.alunoTableAdapter alunoTableAdapter;
        private digitacaoDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        public System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.BindingSource digitacaoDataSet2BindingSource;
        private digitacaoDataSet2 digitacaoDataSet2;
        private System.Windows.Forms.BindingSource aulaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoFeitaEmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aproveitamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDecorridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toquesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn licao;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeroAula;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel painelLicao;
        private System.Windows.Forms.Button btnCadastrarIP;
        private System.Windows.Forms.TextBox txtIP;
    }
}