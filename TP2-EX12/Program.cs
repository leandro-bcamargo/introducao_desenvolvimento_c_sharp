////Escreva um programa que gere um número aleatório de 1 a 100 e permita que o usuário tente adivinhá-lo, informando se o palpite é maior ou menor até acertar. 

//Observações:

//Utilize um laço de repetição para permitir múltiplos palpites.
//Utilize a classe Random para gerar o número secreto.
//Considerações:

//Uso correto do laço de repetição.
//Implementação correta da lógica de adivinhação.
//Exibição de mensagens de feedback adequadas.

int numAleatorio = new Random().Next(0, 101);
int palpite;
do
{
    Console.WriteLine("Digite o seu chute de 1 a 100:");
    palpite = int.Parse(Console.ReadLine());
    if (palpite > numAleatorio)
    {
        Console.WriteLine("Seu palpite está acima do número gerado.");
    } else if (palpite < numAleatorio)
    {
        Console.WriteLine("Seu palpite está abaixo do número gerado.");
    }
}
while (palpite != numAleatorio);
Console.WriteLine($"Você acertou: o número gerado foi {numAleatorio}");