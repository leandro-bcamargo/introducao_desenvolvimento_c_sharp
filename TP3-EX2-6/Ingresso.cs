class Ingresso
{
    private string _nomeDoShow; // identifica o show a que o ingresso se refere
    private double _preco; // identifica o preço do ingresso
    private int _quantidadeDisponivel; // identifica quantos ingressos estão disponíveis. 

    public string NomeDoShow { get { return _nomeDoShow; } set { _nomeDoShow = value; } }
    public double Preco { get { return _preco; } set { _preco = value; } }
    public int QuantidadeDisponivel { get { return _quantidadeDisponivel;} set { _quantidadeDisponivel = value; } }

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