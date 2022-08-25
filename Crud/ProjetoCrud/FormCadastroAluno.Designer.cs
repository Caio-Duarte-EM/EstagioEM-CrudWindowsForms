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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNovoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(6, 51);
            this.textBoxMatricula.MaxLength = 9;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.ShortcutsEnabled = false;
            this.textBoxMatricula.Size = new System.Drawing.Size(104, 23);
            this.textBoxMatricula.TabIndex = 0;
            this.textBoxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMatricula_KeyPress);
            // 
            // groupBoxNovoAluno
            // 
            this.groupBoxNovoAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBoxNovoAluno.Location = new System.Drawing.Point(12, 14);
            this.groupBoxNovoAluno.Name = "groupBoxNovoAluno";
            this.groupBoxNovoAluno.Size = new System.Drawing.Size(760, 148);
            this.groupBoxNovoAluno.TabIndex = 0;
            this.groupBoxNovoAluno.TabStop = false;
            this.groupBoxNovoAluno.Text = "Novo Aluno";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSexo.BackColor = System.Drawing.SystemColors.Control;
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
            this.textBoxCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCPF.Location = new System.Drawing.Point(252, 111);
            this.textBoxCPF.MaxLength = 11;
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.ShortcutsEnabled = false;
            this.textBoxCPF.Size = new System.Drawing.Size(237, 23);
            this.textBoxCPF.TabIndex = 4;
            this.textBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMatricula_KeyPress);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(126, 111);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxNascimento.TabIndex = 3;
            this.maskedTextBoxNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // buttonAdicionarOuModificar
            // 
            this.buttonAdicionarOuModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAdicionarOuModificar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdicionarOuModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.buttonAdicionarOuModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarOuModificar.Location = new System.Drawing.Point(638, 111);
            this.buttonAdicionarOuModificar.Name = "buttonAdicionarOuModificar";
            this.buttonAdicionarOuModificar.Size = new System.Drawing.Size(107, 25);
            this.buttonAdicionarOuModificar.TabIndex = 6;
            this.buttonAdicionarOuModificar.Text = "Adicionar";
            this.buttonAdicionarOuModificar.UseVisualStyleBackColor = false;
            this.buttonAdicionarOuModificar.Click += new System.EventHandler(this.ButtonAdicionarOuModificar_Click);
            // 
            // buttonLimparOuCancelar
            // 
            this.buttonLimparOuCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLimparOuCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLimparOuCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonLimparOuCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimparOuCancelar.Location = new System.Drawing.Point(515, 111);
            this.buttonLimparOuCancelar.Name = "buttonLimparOuCancelar";
            this.buttonLimparOuCancelar.Size = new System.Drawing.Size(107, 25);
            this.buttonLimparOuCancelar.TabIndex = 5;
            this.buttonLimparOuCancelar.Text = "Limpar";
            this.buttonLimparOuCancelar.UseVisualStyleBackColor = false;
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
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(126, 51);
            this.textBoxNome.MaxLength = 99;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ShortcutsEnabled = false;
            this.textBoxNome.Size = new System.Drawing.Size(615, 23);
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
            this.textBoxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(18, 184);
            this.textBoxPesquisa.MaxLength = 100;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(616, 23);
            this.textBoxPesquisa.TabIndex = 7;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.TextBoxPesquisa_TextChanged);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Location = new System.Drawing.Point(638, 16);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(107, 23);
            this.buttonPesquisa.TabIndex = 8;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            this.buttonPesquisa.Click += new System.EventHandler(this.ButtonPesquisa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(18, 213);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 197);
            this.dataGridView1.TabIndex = 9;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(ProjetoCrud.Aluno);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(638, 248);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(107, 23);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(515, 248);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(107, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.buttonPesquisa);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 281);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
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
            this.nomeDataGridViewTextBoxColumn.FillWeight = 128.9256F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.FillWeight = 5.509643F;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Width = 75;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.FillWeight = 5.509643F;
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.Width = 98;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.FillWeight = 5.509643F;
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 98;
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.groupBoxNovoAluno);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolar Manager - Cadastro de aluno";
            this.groupBoxNovoAluno.ResumeLayout(false);
            this.groupBoxNovoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    private TextBox textBoxCPF;
    private BindingSource alunoBindingSource;
    private ComboBox comboBoxSexo;
    private Button buttonExcluir;
    private Button buttonEditar;
    private GroupBox groupBox1;
    private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
}