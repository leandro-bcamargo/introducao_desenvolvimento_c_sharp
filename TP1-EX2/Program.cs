Console.WriteLine("Informe o dia do seu nascimento:");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o mês do seu nascimento:");
int mes = int.Parse(Console.ReadLine());

DateTime hoje = DateTime.Today;
DateTime proximoAniversario = new DateTime(hoje.Year, mes, dia);

// Se aniversário já passou, incrementa o ano para o próximo aniversário
if (proximoAniversario < hoje)
{
    proximoAniversario = proximoAniversario.AddYears(1);
}

TimeSpan diferenca = proximoAniversario - hoje;

int diasRestantes = diferenca.Days;

Console.WriteLine($"Faltam {diasRestantes} dias para o seu aniversário.");