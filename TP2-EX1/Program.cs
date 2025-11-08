Console.WriteLine("Digite o dia do seu nascimento:");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o mês do seu nascimento:");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano do seu nascimento:");
int ano = int.Parse(Console.ReadLine());
DateTime dataNascimento = new DateTime(ano, mes, dia);
DateTime hoje = DateTime.Today;
int idade = hoje.Year - dataNascimento.Year;
/* se a data de hoje for menor do que a data de nascimento acrescida da idade, significa que não fez aniversário
este ano ainda  */
if (hoje < dataNascimento.AddYears(idade)) {
    idade--;
}

Console.WriteLine(idade);

