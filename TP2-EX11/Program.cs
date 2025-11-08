//Desenvolva um programa que solicite um número ao usuário e exiba sua tabuada de 1 a 10. 

//Observações:

//Utilize um laço de repetição para calcular a tabuada.
//Considerações:

//Uso adequado do laço de repetição.
//Cálculo correto da tabuada.

Console.WriteLine("Digite um número para mostrar sua tabuada:");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {i * num}");
}