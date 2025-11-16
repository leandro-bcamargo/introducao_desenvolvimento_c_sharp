class Matricula
{
    private string _nomeDoAluno;
    private string _curso;
    private int _numeroMatricula;
    private string _situacao;
    private string _dataInicial;

    public string NomeDoAluno { get { return _nomeDoAluno;} set { _nomeDoAluno = value;} }
    public string Curso { get { return _curso; } set { _curso = value; } }
    public int NumeroMatricula { get { return _numeroMatricula; } set { _numeroMatricula = value; } }
    public string Situacao { get { return _situacao;} set { _situacao = value; } }
    public string DataInicial { get { return _dataInicial; } set { _dataInicial = value; } }

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do aluno: {NomeDoAluno}\n" +
            $"Curso: {Curso}\n" +
            $"Situação atual: {Situacao}\n" +
            $"Data inicial: {DataInicial}");
    }


}