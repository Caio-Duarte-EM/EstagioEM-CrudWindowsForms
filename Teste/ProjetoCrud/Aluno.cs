namespace ProjetoCrud;
public class Aluno : IEntidade
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public EnumeradorSexo Sexo { get; set; }
    public DateTime Nascimento { get; set; }
    public string? Cpf { get; set; }
    public Aluno(int matricula, string nome, EnumeradorSexo sexo, DateTime nascimento, string cpf)
    {
        Matricula = matricula;
        Nome = nome;
        Sexo = sexo;
        Nascimento = nascimento;
        Cpf = cpf;
    }

    public override bool Equals(object? obj)
    {
        return obj is Aluno aluno &&
               Matricula == aluno.Matricula &&
               Nome == aluno.Nome &&
               Cpf == aluno.Cpf &&
               Nascimento == aluno.Nascimento &&
               Sexo == aluno.Sexo;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Matricula, Nome, Cpf, Nascimento, Sexo);
    }

    public override string ToString()
    {
        return $"Matrícula: {Matricula}" +
               $"Nome: {Nome}" +
               $"Sexo: {Sexo}" +
               $"Data de Nascimento: {Nascimento}" +
               $"Cpf: {Cpf}";
    }
}