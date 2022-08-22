using System.ComponentModel;

namespace ProjetoCrud;
public partial class FormCadastroAluno : Form
{
    private readonly BindingSource alunoSource = new();
    readonly RepositorioAluno repositorio = new();
    public FormCadastroAluno()
    {
        InitializeComponent();
        PreencheGridOrdenado();
        if (!repositorio.GetAll().Any())
        {
            buttonEditar.Enabled = false;
            buttonPesquisa.Enabled = false;
            buttonExcluir.Enabled = false;
        }
    }

    //RESTRI��ES PARA AS CAIXAS DE TEXTO
    private void TextBoxMatricula_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void TextBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

    //EVENTOS DOS CLIQUES DOS BOT�ES DEPENDENDO DO NOME
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
            }
            if (buttonAdicionarOuModificar.Text == "Modificar")
            {
                repositorio.Update(aluno);
            }
            VolteTelaInicial();
            PreencheGridOrdenado();
        }
    } 

    private Aluno InicieAluno()
    {
        int matricula = Convert.ToInt32(textBoxMatricula.Text);
        string nome = textBoxNome.Text.Trim().ToLower();
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

    //BOT�ES QUE N�O MUDAM DE FUNCIONALIDADE
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
        DialogResult desejaExcluir = MessageBox.Show("Deseja realmente excluir esse aluno?", "Aten��o", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if(desejaExcluir == DialogResult.Yes)
        {
            var aluno = repositorio.GetByMatricula((int)dataGridView1.CurrentRow.Cells[0].Value);
            repositorio.Remove(aluno);
            PreencheGridOrdenado();
            VolteTelaInicial();
        }
    }

    private void ButtonPesquisa_Click(object sender, EventArgs e)
    {
        var alunos = repositorio.GetByContendoNoNome(textBoxPesquisa.Text);
        alunoSource.DataSource = alunos;
    } 

    //FUN��ES QUE PODEM SER �TEIS
    private void VolteTelaInicial()
    {
        textBoxMatricula.Enabled = true;
        buttonAdicionarOuModificar.Text = "Adicionar";
        buttonLimparOuCancelar.Text = "Limpar";
        groupBoxNovoAluno.Text = "Novo Aluno";
        LimpeTela();

        if (!repositorio.GetAll().Any())
        {
            buttonEditar.Enabled = false;
            buttonPesquisa.Enabled = false;
            buttonExcluir.Enabled = false;
        }
        else
        {
            buttonEditar.Enabled = true;
            buttonPesquisa.Enabled = true;
            buttonExcluir.Enabled = true;
        }
    }

    private void LimpeTela()
    {
        textBoxMatricula.Clear();
        textBoxNome.Clear();
        comboBoxSexo.SelectedItem = null;
        maskedTextBoxNascimento.Clear();
        textBoxCPF.Clear();
        textBoxPesquisa.Clear();
    }

    private static void MostreMensagemDeErro(string mensagem)
    {
        MessageBox.Show(mensagem, "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private bool DadosSaoValidos()
    {
        string matricula = textBoxMatricula.Text;
        if (matricula == string.Empty)
        {
            MostreMensagemDeErro("Matr�cula deve conter ao menos um d�gito");
            textBoxMatricula.Focus();
            return false;
        }
        else
        {
            foreach (var aluno in repositorio.GetAll())
            {
                if (aluno.Matricula == Convert.ToInt32(matricula) && buttonAdicionarOuModificar.Text == "Adicionar")
                {
                    MostreMensagemDeErro("J� existe um aluno com essa matr�cula");
                    textBoxMatricula.Clear();
                    textBoxMatricula.Focus();
                    return false;
                }
            }
        }

        string nome = textBoxNome.Text;
        if (nome == string.Empty)
        {
            MostreMensagemDeErro("Nome deve conter ao menos um d�gito");
            textBoxNome.Focus();
            return false;
        }

        int sexo = comboBoxSexo.SelectedIndex;
        if (sexo == -1)
        {
            MostreMensagemDeErro("Escolha uma op�ao para o sexo");
            comboBoxSexo.Focus();
            return false;
        }

        try
        {
            DateTime dataAtual = DateTime.Now;
            DateTime nascimento = Convert.ToDateTime(maskedTextBoxNascimento.Text);
            if (nascimento.Year < 1900 || nascimento > dataAtual)
            {
                MostreMensagemDeErro($"Digite uma data entre 01/01/1900 e {dataAtual.ToShortDateString()}");
                return false;
            }
        }
        catch (Exception)
        {
            MostreMensagemDeErro("Insira um data v�lida");
            maskedTextBoxNascimento.Focus();
            return false;
        }

        Cpf cpf = (Cpf)textBoxCPF.Text;
        if (textBoxCPF.Text == string.Empty)
        {
            return true;
        }
        else if (cpf == "inv�lido")
        {
            MostreMensagemDeErro("Este CPF n�o � v�lido");
            textBoxCPF.Clear();
            textBoxCPF.Focus();
            return false;
        }
        else
        {
            foreach(Aluno aluno in repositorio.GetAll())
            {
                if(aluno.Cpf == cpf && aluno.Matricula.ToString() != matricula)
                {
                    MostreMensagemDeErro("Ja existe um aluno com esse CPF");
                    textBoxCPF.Clear();
                    textBoxCPF.Focus();
                    return false;
                }
            }
        }
        return true;
    }

    private void TextBoxPesquisa_TextChanged(object sender, EventArgs e)
    {
        bool ehNumerico = int.TryParse(textBoxPesquisa.Text, out _);
        if (ehNumerico)
        {
            var alunos = repositorio.GetByContendoNaMatricula(textBoxPesquisa.Text);
            alunoSource.DataSource = alunos;
        }
        else
        {
           var alunos = repositorio.GetByContendoNoNome(textBoxPesquisa.Text);
           alunoSource.DataSource = alunos;
        }
    }

    private void PreencheGridOrdenado()
    {
        alunoSource.DataSource = repositorio.GetAll().OrderBy(aluno => aluno.Matricula);
        dataGridView1.DataSource = alunoSource;   
    }
}