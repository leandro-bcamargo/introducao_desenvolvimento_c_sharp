Console.WriteLine("Digite o dia da primeira data:");
int dia1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o mês da primeira data:");
int mes1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano da primeira data:");
int ano1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o dia da segunda data:");
int dia2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o mês da segunda data:");
int mes2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano da segunda data:");
int ano2 = int.Parse(Console.ReadLine());

DateTime data1 = new DateTime(ano1, mes1, dia1);
DateTime data2 = new DateTime(ano2, mes2, dia2);

// Certificando-se que data2 vem depois de data1
if (data1 > data2)
{
    (data1, data2) = (data2, data1);
}

int diferencaAnos = data2.Year - data1.Year;
int diferencaMeses = data2.Month - data1.Month;
int diferencaDias = data2.Day - data1.Day;

Console.WriteLine($"A diferença entre as datas é de {diferencaDias} dias, {diferencaMeses} meses e {diferencaAnos} anos.");