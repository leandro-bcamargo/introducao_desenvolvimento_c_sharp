class Ingresso
{
    private string _nomeDoShow; // identifica o show a que o ingresso se refere
    private double _preco; // identifica o preço do ingresso
    private int _quantidadeDisponivel; // identifica quantos ingressos estão disponíveis. 

    public string NomeDoShow { get { return _nomeDoShow; } set { _nomeDoShow = value; } }
    public double Preco { get { return _preco; } set { _preco = value; } }
    public int QuantidadeDisponivel { get { return _quantidadeDisponivel;} set { _quantidadeDisponivel = value; } }

    public Ingresso() { }

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        _nomeDoShow = nomeDoShow;
        _preco = preco;
        _quantidadeDisponivel = quantidadeDisponivel;
    }

    public void AlterarPreco(double preco)
    {
        Preco = preco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        QuantidadeDisponivel = novaQuantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do show: {NomeDoShow}\n" +
            $"Preço: R$ {Preco}\n" +
            $"Quantidade disponível: {QuantidadeDisponivel}");
    }

    // Getters e setters são úteis para fins de encapsulamento, impedindo o acesso direto de outras classes aos campos desta classe. O acesso passa a ser controlado por intermédio de métodos que podem validar se os acessos e mudanças que se quer fazer nos campos da podem ser feitos sem comprometer seu bom funcionamento.

    public string GetNomeDoShow()
    {
        return _nomeDoShow;
    }

    public void SetNomeDoShow(string novoNome)
    {
        _nomeDoShow = novoNome;
    }


    public double GetPreco() {
        return _preco;
    }

    public void SetPreco(double novoPreco)
    {
        _preco = novoPreco;
    }

    public int GetQuantidadeDisponivel()
    {
        return _quantidadeDisponivel;
    } 

    public void SetQuantidadeDisponivel(int novaQuantidade)
    {
        _quantidadeDisponivel = novaQuantidade;
    }
}