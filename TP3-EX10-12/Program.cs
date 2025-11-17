using TP3_EX10_12;

class Program
{
    public static void Main()
    {
        Circulo circulo = new Circulo();
        Esfera esfera = new Esfera();

        circulo.Raio = 3;
        esfera.Raio = 5;

        double areaCirculo = circulo.CalcularArea();
        double volumeEsfera = esfera.CalcularVolume();

        Console.WriteLine($"A área do círculo de raio {circulo.Raio} é {areaCirculo:F2}");
        Console.WriteLine($"O volume da esfera de raio {esfera.Raio} é {volumeEsfera:F2}");
    }

}
