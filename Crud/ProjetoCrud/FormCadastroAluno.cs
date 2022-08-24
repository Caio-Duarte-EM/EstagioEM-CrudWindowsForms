namespace ProjetoCrud;
public partial class FormCadastroAluno : Form
{
    private readonly BindingSource alunoSource = new();
    private readonly RepositorioAluno repositorio = new();
    public FormCadastroAluno()
    {
        InitializeComponent();
        PreencheGridOrdenado();
        if (!repositorio.GetAll().Any())
        {
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
        }
    }

    private void TextBoxMatricula_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
        {
            e.Handled = true;
        }
    }

    private void TextBoxNome_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
        {
            e.Handled = true;
        }
    }

    private void ButtonLimparOuCancelar_Click(object sender, EventArgs e)
    {
        if (buttonLimparOuCancelar.Text == "Limpar")
        {
            LimpeTela();
        }
        else if (buttonLimparOuCancelar.Text == "Cancelar")
        {
            VolteTelaInicial();
        }
    }

    private void ButtonAdicionarOuModificar_Click(object sender, EventArgs e)
    {
        if (!DadosSaoValidos())
        {
            return;
        }
        else
        {
            Aluno aluno = InicieAluno();
            if (buttonAdicionarOuModificar.Text == "Adicionar")
            {
                repositorio.Add(aluno);
                MostreMensagemDe("Sucesso", "Aluno(a) adicionado(a) com sucesso");
            }
            if (buttonAdicionarOuModificar.Text == "Modificar")
            {
                repositorio.Update(aluno);
                MostreMensagemDe("Sucesso", "Aluno(a) modificado(a) com sucesso");
            }
            VolteTelaInicial();
        }
    }

    private Aluno InicieAluno()
    {
        int matricula = Convert.ToInt32(textBoxMatricula.Text);
        string nome = textBoxNome.Text.Trim();
        string sexoSelecionado;
        if (comboBoxSexo.SelectedIndex == 0)
        {
            sexoSelecionado = "Masculino";
        }
        else
        {
            sexoSelecionado = "Feminino";
        }
        EnumeradorSexo sexo = (EnumeradorSexo)Enum.Parse(typeof(EnumeradorSexo), sexoSelecionado);
        DateTime dataDeNascimento = Convert.ToDateTime(maskedTextBoxNascimento.Text);
        string cpf;
        if (textBoxCPF.Text == string.Empty)
        {
            cpf = textBoxCPF.Text;
        }
        else
        {
            cpf = (Cpf)textBoxCPF.Text;
        }
        Aluno novoAluno = new(matricula, nome, sexo, dataDeNascimento, cpf);
        return novoAluno;
    }

    private void ButtonEditar_Click(object sender, EventArgs e)
    {
        textBoxMatricula.Enabled = false;
        buttonAdicionarOuModificar.Text = "Modificar";
        buttonLimparOuCancelar.Text = "Cancelar";
        groupBoxNovoAluno.Text = "Editar Aluno";

        textBoxMatricula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        textBoxNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        comboBoxSexo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        maskedTextBoxNascimento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        textBoxCPF.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString()?.Replace("-", "").Replace(".", "");
    }

    private void ButtonExcluir_Click(object sender, EventArgs e)
    {
        int matricula = (int)dataGridView1.CurrentRow.Cells[0].Value;
        var aluno = repositorio.GetByMatricula(matricula);
        DialogResult desejaExcluir = MessageBox.Show($"Deseja realmente excluir {aluno.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (desejaExcluir == DialogResult.Yes)
        {
            repositorio.Remove(aluno);
            MostreMensagemDe("Sucesso", "Aluno(a) removido(a) com sucesso");
            VolteTelaInicial();
        }
    }

    private void ButtonPesquisa_Click(object sender, EventArgs e)
    {
        IEnumerable<Aluno> alunos;
        bool ehNumerico = int.TryParse(textBoxPesquisa.Text, out _);
        if (ehNumerico)
        {
            alunos = repositorio.GetByContendoNaMatricula(textBoxPesquisa.Text);
        }
        else
        {
            alunos = repositorio.GetByContendoNoNome(textBoxPesquisa.Text);
        }
        alunoSource.DataSource = alunos.OrderBy(aluno => aluno.Matricula);
    }

    private void TextBoxPesquisa_TextChanged(object sender, EventArgs e)
    {
        IEnumerable<Aluno> alunos;
        bool ehNumerico = int.TryParse(textBoxPesquisa.Text, out _);
        if (ehNumerico)
        {
            alunos = repositorio.GetByContendoNaMatricula(textBoxPesquisa.Text).OrderBy(aluno => aluno.Matricula);
        }
        else
        {
            alunos = repositorio.GetByContendoNoNome(textBoxPesquisa.Text.ToLower()).OrderBy(aluno => aluno.Nome);
        }
        if (!alunos.Any())
        {
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
        }
        else
        {
            buttonEditar.Enabled = true;
            buttonExcluir.Enabled = true;
        }
        alunoSource.DataSource = alunos;
    }

    private void VolteTelaInicial()
    {
        textBoxMatricula.Enabled = true;
        buttonAdicionarOuModificar.Text = "Adicionar";
        buttonLimparOuCancelar.Text = "Limpar";
        groupBoxNovoAluno.Text = "Novo Aluno";
        LimpeTela();
        PreencheGridOrdenado();

        if (!repositorio.GetAll().Any())
        {
            buttonEditar.Enabled = false;
            buttonExcluir.Enabled = false;
        }
        else
        {
            buttonEditar.Enabled = true;
            buttonExcluir.Enabled = true;
        }
    }

    private void LimpeTela()
    {
        textBoxMatricula.Clear();
        textBoxNome.Clear();
        comboBoxSexo.SelectedIndex = -1;
        maskedTextBoxNascimento.Clear();
        textBoxCPF.Clear();
        textBoxPesquisa.Clear();
        textBoxMatricula.Focus();
    }

    private static void MostreMensagemDe(string tipo, string mensagem)
    {
        if (tipo == "Erro")
        {
            MessageBox.Show(mensagem, tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (tipo == "Sucesso")
        {
            MessageBox.Show(mensagem, tipo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (tipo == "Atenção")
        {
            MessageBox.Show(mensagem, tipo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private bool DadosSaoValidos()
    {
        string matricula = textBoxMatricula.Text;
        if (matricula == string.Empty)
        {
            MostreMensagemDe("Erro", "Matrícula deve conter ao menos um dígito");
            textBoxMatricula.Focus();
            return false;
        }
        else if (matricula == "0")
        {
            MostreMensagemDe("Erro", "Matrícula não pode ser 0");
            textBoxMatricula.Focus();
            textBoxMatricula.Clear();
        }
        else
        {
            foreach (var aluno in repositorio.GetAll())
            {
                if (aluno.Matricula == Convert.ToInt32(matricula) && buttonAdicionarOuModificar.Text == "Adicionar")
                {
                    MostreMensagemDe("Erro", "Já existe um(a) aluno(a) com essa matrícula");
                    textBoxMatricula.Clear();
                    textBoxMatricula.Focus();
                    return false;
                }
            }
        }

        string nome = textBoxNome.Text;
        if (nome == string.Empty)
        {
            MostreMensagemDe("Erro", "Nome deve conter ao menos um dígito");
            textBoxNome.Focus();
            return false;
        }

        int sexo = comboBoxSexo.SelectedIndex;
        if (sexo == -1)
        {
            MostreMensagemDe("Erro", "Escolha uma opção para o sexo");
            comboBoxSexo.Focus();
            return false;
        }

        try
        {
            DateTime dataAtual = DateTime.Now;
            DateTime nascimento = Convert.ToDateTime(maskedTextBoxNascimento.Text);
            if (nascimento.Year < 1900 || nascimento > dataAtual)
            {
                MostreMensagemDe("Erro", $"Digite uma data entre 01/01/1900 e {dataAtual.ToShortDateString()}");
                maskedTextBoxNascimento.Focus();
                return false;
            }
        }
        catch (Exception)
        {
            MostreMensagemDe("Erro", "Esta data não é válida");
            maskedTextBoxNascimento.Focus();
            return false;
        }

        Cpf cpf = (Cpf)textBoxCPF.Text;
        if (textBoxCPF.Text == string.Empty)
        {
            return true;
        }
        else if (cpf == "inválido")
        {
            MostreMensagemDe("Erro", "Este CPF não é válido");
            textBoxCPF.Clear();
            textBoxCPF.Focus();
            return false;
        }
        else
        {
            foreach (Aluno aluno in repositorio.GetAll())
            {
                if (aluno.Cpf == cpf && aluno.Matricula.ToString() != matricula)
                {
                    MostreMensagemDe("Erro", "Ja existe um(a) aluno(a) com esse CPF");
                    textBoxCPF.Clear();
                    textBoxCPF.Focus();
                    return false;
                }
            }
        }
        return true;
    }

    private void PreencheGridOrdenado()
    {
        alunoSource.DataSource = repositorio.GetAll().OrderBy(aluno => aluno.Matricula);
        dataGridView1.DataSource = alunoSource;
        dataGridView1.ClearSelection();
    }
}