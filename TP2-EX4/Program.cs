//Crie um programa que solicite nome, idade, telefone e e-mail do usuário e exiba os dados cadastrados de forma organizada. 

//Observações:

//Utilize Console.ReadLine() para entrada de dados.
//Exiba os dados de forma formatada e clara.
//Considerações:

//Uso correto de Console.ReadLine().
//Exibição organizada e formatada das informações.

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu telefone:");
string telefone = Console.ReadLine();
Console.WriteLine("Digite seu e-mail:");
string email = Console.ReadLine();
Console.WriteLine($"Nome: {nome}\n" +
    $"Idade: {idade}\n" +
    $"Telefone: {telefone}\n" +
    $"Email: {email}\n");