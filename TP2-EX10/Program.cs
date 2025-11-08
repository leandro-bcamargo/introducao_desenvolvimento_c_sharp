//Crie um programa que solicite um número ao usuário e exiba uma contagem regressiva até 0. 

//Observações:

//Utilize um laço de repetição para realizar a contagem.
//Exiba os números separados por vírgula.
//Considerações:

//Uso correto do laço de repetição.
//Exibição correta da contagem.

Console.WriteLine("Digite um número para a contagem:");
int num = int.Parse(Console.ReadLine());

for (int i = num; i >= 0; i--)
{
    if (i == 0) Console.WriteLine(i);
    else Console.Write($"{i},");
}