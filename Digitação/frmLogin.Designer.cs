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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnEntrar = new System.Windows.Forms.Button();
            this.dtgNome = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linhasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoFeitaEmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aproveitamentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDecorridoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toquesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet1 = new Digitação.digitacaoDataSet1();
            this.alunoTableAdapter1 = new Digitação.digitacaoDataSet1TableAdapters.alunoTableAdapter();
            this.dtgAulas = new System.Windows.Forms.DataGridView();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licaoFeitaEmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aproveitamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoDecorridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toquesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitacaoDataSet2 = new Digitação.digitacaoDataSet2();
            this.aulaTableAdapter = new Digitação.digitacaoDataSet2TableAdapters.aulaTableAdapter();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboNomes = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(212, 262);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(128, 37);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // dtgNome
            // 
            this.dtgNome.AllowUserToAddRows = false;
            this.dtgNome.AllowUserToDeleteRows = false;
            this.dtgNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgNome.AutoGenerateColumns = false;
            this.dtgNome.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgNome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.idalunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.linhasDataGridViewTextBoxColumn,
            this.licaoDataGridViewTextBoxColumn1,
            this.licaoFeitaEmDataGridViewTextBoxColumn1,
            this.aproveitamentoDataGridViewTextBoxColumn1,
            this.tempoDecorridoDataGridViewTextBoxColumn1,
            this.errosDataGridViewTextBoxColumn1,
            this.toquesDataGridViewTextBoxColumn1,
            this.feitaDataGridViewTextBoxColumn1,
            this.dataCadDataGridViewTextBoxColumn});
            this.dtgNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgNome.DataSource = this.alunoBindingSource1;
            this.dtgNome.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgNome.EnableHeadersVisualStyles = false;
            this.dtgNome.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtgNome.Location = new System.Drawing.Point(231, 76);
            this.dtgNome.Margin = new System.Windows.Forms.Padding(4);
            this.dtgNome.Name = "dtgNome";
            this.dtgNome.ReadOnly = true;
            this.dtgNome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgNome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgNome.Size = new System.Drawing.Size(121, 11);
            this.dtgNome.TabIndex = 6;
            this.dtgNome.Visible = false;
            this.dtgNome.DoubleClick += new System.EventHandler(this.dtgNome_DoubleClick);
            this.dtgNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgNome_KeyDown);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // idalunoDataGridViewTextBoxColumn
            // 
            this.idalunoDataGridViewTextBoxColumn.DataPropertyName = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.HeaderText = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.Name = "idalunoDataGridViewTextBoxColumn";
            this.idalunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linhasDataGridViewTextBoxColumn
            // 
            this.linhasDataGridViewTextBoxColumn.DataPropertyName = "linhas";
            this.linhasDataGridViewTextBoxColumn.HeaderText = "linhas";
            this.linhasDataGridViewTextBoxColumn.Name = "linhasDataGridViewTextBoxColumn";
            this.linhasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licaoDataGridViewTextBoxColumn1
            // 
            this.licaoDataGridViewTextBoxColumn1.DataPropertyName = "licao";
            this.licaoDataGridViewTextBoxColumn1.HeaderText = "licao";
            this.licaoDataGridViewTextBoxColumn1.Name = "licaoDataGridViewTextBoxColumn1";
            this.licaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // licaoFeitaEmDataGridViewTextBoxColumn1
            // 
            this.licaoFeitaEmDataGridViewTextBoxColumn1.DataPropertyName = "licaoFeitaEm";
            this.licaoFeitaEmDataGridViewTextBoxColumn1.HeaderText = "licaoFeitaEm";
            this.licaoFeitaEmDataGridViewTextBoxColumn1.Name = "licaoFeitaEmDataGridViewTextBoxColumn1";
            this.licaoFeitaEmDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aproveitamentoDataGridViewTextBoxColumn1
            // 
            this.aproveitamentoDataGridViewTextBoxColumn1.DataPropertyName = "aproveitamento";
            this.aproveitamentoDataGridViewTextBoxColumn1.HeaderText = "aproveitamento";
            this.aproveitamentoDataGridViewTextBoxColumn1.Name = "aproveitamentoDataGridViewTextBoxColumn1";
            this.aproveitamentoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tempoDecorridoDataGridViewTextBoxColumn1
            // 
            this.tempoDecorridoDataGridViewTextBoxColumn1.DataPropertyName = "tempoDecorrido";
            this.tempoDecorridoDataGridViewTextBoxColumn1.HeaderText = "tempoDecorrido";
            this.tempoDecorridoDataGridViewTextBoxColumn1.Name = "tempoDecorridoDataGridViewTextBoxColumn1";
            this.tempoDecorridoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // errosDataGridViewTextBoxColumn1
            // 
            this.errosDataGridViewTextBoxColumn1.DataPropertyName = "erros";
            this.errosDataGridViewTextBoxColumn1.HeaderText = "erros";
            this.errosDataGridViewTextBoxColumn1.Name = "errosDataGridViewTextBoxColumn1";
            this.errosDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // toquesDataGridViewTextBoxColumn1
            // 
            this.toquesDataGridViewTextBoxColumn1.DataPropertyName = "toques";
            this.toquesDataGridViewTextBoxColumn1.HeaderText = "toques";
            this.toquesDataGridViewTextBoxColumn1.Name = "toquesDataGridViewTextBoxColumn1";
            this.toquesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // feitaDataGridViewTextBoxColumn1
            // 
            this.feitaDataGridViewTextBoxColumn1.DataPropertyName = "feita";
            this.feitaDataGridViewTextBoxColumn1.HeaderText = "feita";
            this.feitaDataGridViewTextBoxColumn1.Name = "feitaDataGridViewTextBoxColumn1";
            this.feitaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataCadDataGridViewTextBoxColumn
            // 
            this.dataCadDataGridViewTextBoxColumn.DataPropertyName = "dataCad";
            this.dataCadDataGridViewTextBoxColumn.HeaderText = "dataCad";
            this.dataCadDataGridViewTextBoxColumn.Name = "dataCadDataGridViewTextBoxColumn";
            this.dataCadDataGridViewTextBoxColumn.ReadOnly = true;
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
            // alunoTableAdapter1
            // 
            this.alunoTableAdapter1.ClearBeforeFill = true;
            // 
            // dtgAulas
            // 
            this.dtgAulas.AllowUserToAddRows = false;
            this.dtgAulas.AllowUserToDeleteRows = false;
            this.dtgAulas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.dtgAulas.DataSource = this.aulaBindingSource;
            this.dtgAulas.Enabled = false;
            this.dtgAulas.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtgAulas.Location = new System.Drawing.Point(51, 76);
            this.dtgAulas.Margin = new System.Windows.Forms.Padding(4);
            this.dtgAulas.Name = "dtgAulas";
            this.dtgAulas.ReadOnly = true;
            this.dtgAulas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgAulas.Size = new System.Drawing.Size(171, 24);
            this.dtgAulas.TabIndex = 7;
            this.dtgAulas.Visible = false;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            this.alunoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.licaoFeitaEmDataGridViewTextBoxColumn.HeaderText = "Lição feita em";
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
            this.tempoDecorridoDataGridViewTextBoxColumn.HeaderText = "Tempo Decorrido";
            this.tempoDecorridoDataGridViewTextBoxColumn.Name = "tempoDecorridoDataGridViewTextBoxColumn";
            this.tempoDecorridoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempoDecorridoDataGridViewTextBoxColumn.Width = 75;
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
            this.feitaDataGridViewTextBoxColumn.HeaderText = "Feita";
            this.feitaDataGridViewTextBoxColumn.Name = "feitaDataGridViewTextBoxColumn";
            this.feitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.feitaDataGridViewTextBoxColumn.Width = 250;
            // 
            // aulaBindingSource
            // 
            this.aulaBindingSource.DataMember = "aula";
            this.aulaBindingSource.DataSource = this.digitacaoDataSet2;
            // 
            // digitacaoDataSet2
            // 
            this.digitacaoDataSet2.DataSetName = "digitacaoDataSet2";
            this.digitacaoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaTableAdapter
            // 
            this.aulaTableAdapter.ClearBeforeFill = true;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(43, 162);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(297, 29);
            this.txtNomeAluno.TabIndex = 0;
            this.txtNomeAluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNomeAluno_MouseClick);
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.txtNomeAluno_TextChanged);
            this.txtNomeAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeAluno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Location = new System.Drawing.Point(43, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 5);
            this.panel4.TabIndex = 6;
            // 
            // cboNomes
            // 
            this.cboNomes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNomes.FormattingEnabled = true;
            this.cboNomes.Location = new System.Drawing.Point(43, 198);
            this.cboNomes.Name = "cboNomes";
            this.cboNomes.Size = new System.Drawing.Size(297, 25);
            this.cboNomes.TabIndex = 1;
            this.cboNomes.SelectedIndexChanged += new System.EventHandler(this.cboNomes_SelectedIndexChanged);
            this.cboNomes.Click += new System.EventHandler(this.cboNomes_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 361);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = true;
            this.btnCadastrar.Size = new System.Drawing.Size(279, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Novo por aqui? Cadastre - Se agora!!";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAdm.BackgroundImage = global::Digitação.Properties.Resources.administrador;
            this.btnAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Location = new System.Drawing.Point(310, 3);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(71, 66);
            this.btnAdm.TabIndex = 10;
            this.btnAdm.Text = "ADM";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 396);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboNomes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.dtgAulas);
            this.Controls.Add(this.dtgNome);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitacaoDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnEntrar;
        private digitacaoDataSet1 digitacaoDataSet1;
        private System.Windows.Forms.BindingSource alunoBindingSource1;
        private digitacaoDataSet1TableAdapters.alunoTableAdapter alunoTableAdapter1;
        public System.Windows.Forms.DataGridView dtgNome;
        private System.Windows.Forms.DataGridView dtgAulas;
        private digitacaoDataSet2 digitacaoDataSet2;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private digitacaoDataSet2TableAdapters.aulaTableAdapter aulaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoFeitaEmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aproveitamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDecorridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toquesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linhasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licaoFeitaEmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aproveitamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoDecorridoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toquesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboNomes;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrar;
        private System.Windows.Forms.Button btnAdm;
    }
}