namespace ProjetoCrud;
partial class FormCadastroAluno
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.groupBoxNovoAluno = new System.Windows.Forms.GroupBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdicionarOuModificar = new System.Windows.Forms.Button();
            this.buttonLimparOuCancelar = new System.Windows.Forms.Button();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.groupBoxNovoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(6, 51);
            this.textBoxMatricula.MaxLength = 9;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(104, 23);
            this.textBoxMatricula.TabIndex = 0;
            this.textBoxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMatricula_KeyPress);
            // 
            // groupBoxNovoAluno
            // 
            this.groupBoxNovoAluno.Controls.Add(this.comboBoxSexo);
            this.groupBoxNovoAluno.Controls.Add(this.textBoxCPF);
            this.groupBoxNovoAluno.Controls.Add(this.maskedTextBoxNascimento);
            this.groupBoxNovoAluno.Controls.Add(this.buttonAdicionarOuModificar);
            this.groupBoxNovoAluno.Controls.Add(this.buttonLimparOuCancelar);
            this.groupBoxNovoAluno.Controls.Add(this.labelCPF);
            this.groupBoxNovoAluno.Controls.Add(this.labelNascimento);
            this.groupBoxNovoAluno.Controls.Add(this.labelSexo);
            this.groupBoxNovoAluno.Controls.Add(this.labelNome);
            this.groupBoxNovoAluno.Controls.Add(this.textBoxNome);
            this.groupBoxNovoAluno.Controls.Add(this.textBoxMatricula);
            this.groupBoxNovoAluno.Controls.Add(this.labelMatricula);
            this.groupBoxNovoAluno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNovoAluno.Name = "groupBoxNovoAluno";
            this.groupBoxNovoAluno.Size = new System.Drawing.Size(743, 161);
            this.groupBoxNovoAluno.TabIndex = 0;
            this.groupBoxNovoAluno.TabStop = false;
            this.groupBoxNovoAluno.Text = "Novo Aluno";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(6, 111);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(104, 23);
            this.comboBoxSexo.TabIndex = 2;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(252, 109);
            this.textBoxCPF.MaxLength = 11;
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(242, 23);
            this.textBoxCPF.TabIndex = 4;
            this.textBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCPF_KeyPress);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(126, 109);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxNascimento.TabIndex = 3;
            this.maskedTextBoxNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // buttonAdicionarOuModificar
            // 
            this.buttonAdicionarOuModificar.Location = new System.Drawing.Point(626, 111);
            this.buttonAdicionarOuModificar.Name = "buttonAdicionarOuModificar";
            this.buttonAdicionarOuModificar.Size = new System.Drawing.Size(107, 23);
            this.buttonAdicionarOuModificar.TabIndex = 6;
            this.buttonAdicionarOuModificar.Text = "Adicionar";
            this.buttonAdicionarOuModificar.UseVisualStyleBackColor = true;
            this.buttonAdicionarOuModificar.Click += new System.EventHandler(this.ButtonAdicionarOuModificar_Click);
            // 
            // buttonLimparOuCancelar
            // 
            this.buttonLimparOuCancelar.Location = new System.Drawing.Point(500, 109);
            this.buttonLimparOuCancelar.Name = "buttonLimparOuCancelar";
            this.buttonLimparOuCancelar.Size = new System.Drawing.Size(107, 25);
            this.buttonLimparOuCancelar.TabIndex = 5;
            this.buttonLimparOuCancelar.Text = "Limpar";
            this.buttonLimparOuCancelar.UseVisualStyleBackColor = true;
            this.buttonLimparOuCancelar.Click += new System.EventHandler(this.ButtonLimparOuCancelar_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(252, 91);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(87, 15);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF (Opcional)";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(126, 91);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(76, 15);
            this.labelNascimento.TabIndex = 8;
            this.labelNascimento.Text = "Nascimento*";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(6, 91);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(37, 15);
            this.labelSexo.TabIndex = 9;
            this.labelSexo.Text = "Sexo*";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(126, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 10;
            this.labelNome.Text = "Nome*";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(126, 51);
            this.textBoxNome.MaxLength = 100;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(607, 23);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNome_KeyPress);
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(6, 33);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(62, 15);
            this.labelMatricula.TabIndex = 11;
            this.labelMatricula.Text = "Matrícula*";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(12, 192);
            this.textBoxPesquisa.MaxLength = 100;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(607, 23);
            this.textBoxPesquisa.TabIndex = 7;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.TextBoxPesquisa_TextChanged);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(638, 192);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(117, 23);
            this.buttonPesquisa.TabIndex = 8;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.ButtonPesquisa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunoBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(743, 163);
            this.dataGridView1.TabIndex = 9;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 400;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Width = 75;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.Width = 90;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 110;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(ProjetoCrud.Aluno);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(638, 390);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(117, 23);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(512, 390);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(107, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.groupBoxNovoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolar Manager - Cadastro de aluno";
            this.groupBoxNovoAluno.ResumeLayout(false);
            this.groupBoxNovoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private GroupBox groupBoxNovoAluno;
    private TextBox textBoxMatricula;
    private Label labelMatricula;
    private Button buttonAdicionarOuModificar;
    private Button buttonLimparOuCancelar;
    private Label labelCPF;
    private Label labelNascimento;
    private Label labelSexo;
    private Label labelNome;
    private TextBox textBoxNome;
    private TextBox textBoxPesquisa;
    private Button buttonPesquisa;
    private MaskedTextBox maskedTextBoxNascimento;
    private DataGridView dataGridView1;
    private Button buttonEditar;
    private TextBox textBoxCPF;
    private BindingSource alunoBindingSource;
    private ComboBox comboBoxSexo;
    private Button buttonExcluir;
    private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
}