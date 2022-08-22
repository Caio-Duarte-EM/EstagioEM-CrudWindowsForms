using FirebirdSql.Data.FirebirdClient;
using System.Linq.Expressions;

namespace ProjetoCrud;
public class RepositorioAluno : RepositorioAbstrato<Aluno>
{

    public string conexao = @"DataSource=localhost;Port=3054; Database=D:\DBESTAGIO.FDB; username= SYSDBA; password = masterkey";
    public FbConnection? con;

    public override void Add(Aluno aluno)
    {
        con = new(conexao);
        con.Open();
        FbCommand comando = new($"INSERT INTO TBALUNO (ALUMATRICULA, ALUNOME, ALUSEXO, ALUNASCIMENTO, ALUCPF) VALUES ({aluno.Matricula}, '{aluno.Nome}', {(int)aluno.Sexo}, '{aluno.Nascimento:dd.MM.yyyy}', '{aluno.Cpf}');", con);
        comando.ExecuteNonQuery();
        con.Close();
    }

    public override void Remove(Aluno aluno)
    {
        con = new(conexao);
        con.Open();
        FbCommand comando = new($"DELETE FROM TBALUNO WHERE ALUMATRICULA = {aluno.Matricula};", con);
        comando.ExecuteNonQuery();
        con.Close();
    }

    public override void Update(Aluno aluno)
    {
        con = new(conexao);
        con.Open();
        FbCommand comando = new($"UPDATE TBALUNO SET ALUMATRICULA = {aluno.Matricula}," + 
            $"ALUNOME = '{aluno.Nome}'," +
            $"ALUSEXO = {(int)aluno.Sexo}," +
            $"ALUNASCIMENTO = '{aluno.Nascimento:dd.MM.yyyy}'," +
            $"ALUCPF = '{aluno.Cpf}'" + 
            $"WHERE ALUMATRICULA = {aluno.Matricula}; ", con);
        comando.ExecuteNonQuery();
        con.Close();
    }

    public override IEnumerable<Aluno> GetAll()
    {
        con = new(conexao);
        con.Open();
        FbCommand comando = new($"SELECT * FROM TBALUNO", con);
        FbDataReader Reader = comando.ExecuteReader();
        List<Aluno> alunos = new();
        while (Reader.Read())
        {
            Aluno aluno = new(
                Convert.ToInt32(Reader["ALUMATRICULA"]),
                Reader["ALUNOME"].ToString() ?? "",
                (EnumeradorSexo)Convert.ToInt32(Reader["ALUSEXO"].ToString()),
                Convert.ToDateTime(Reader["ALUNASCIMENTO"]),
                Reader["ALUCPF"].ToString() ?? ""
            );
            alunos.Add(aluno);
        } 
        Reader.Close();
        con.Close();
        return alunos;
    }

    public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
    {
        return GetAll().Where(predicate.Compile());
    }

    public Aluno GetByMatricula(int matricula)
    {
        return Get(aluno => aluno.Matricula == matricula).First();
    }

    public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
    {
        return Get(aluno => aluno.Nome.Contains(parteDoNome)).ToList();
    }

    public IEnumerable<Aluno> GetByContendoNaMatricula(string parteDaMatricula)
    {
        return Get(aluno => aluno.Matricula.ToString().Contains(parteDaMatricula)).ToList();
    }
}