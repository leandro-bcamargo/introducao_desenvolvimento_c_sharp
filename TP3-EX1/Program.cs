// 1. Classe é um molde para a criação de objetos de um mesmo tipo, definindo os campos e os métodos que suas instâncias devem possuir. Objetos são instâncias de classes que agrupam campos e métodos com valores e implementações específicas. Campos são dados que compõem o estado de uma classe, sejam esses dados primitivos ou não-primitivos. Métodos são funções que compõem o comportamento de uma classe, em geral com o propósito de manipular seus campos.
// 

// Criação de objeto
Carro impreza = new Carro("Subaru", "Impreza");

// Classe
class Carro
{
    // Campos
    private string _fabricante;
    private string _modelo;
    private int _velocidade;

    // Construtor
    public Carro(string fabricante, string modelo)
    {
        _fabricante = fabricante;
        _modelo = modelo;
        _velocidade = 0;
    }

    // Atributos com getters e setters
    public string Fabricante
    {
        get
        {
            return _fabricante;
        }
        set
        {
            _fabricante = value;
        }
    } 

    public string Modelo
    {
        get
        {
            return _modelo;
        }
        set
        {
            _modelo = value;
        }
    }
    
    // Métodos
    public void Acelerar(int aceleracao)
    {
        _velocidade += aceleracao;
    } 

    public void Brecar(int desaceleracao)
    {
        _velocidade -= desaceleracao;
    }
    
}



