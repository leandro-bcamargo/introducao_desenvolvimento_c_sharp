//Escreva um programa que solicite peso e altura do usuário e calcule seu Índice de Massa Corporal (IMC), classificando-o em faixas de peso. 

//Observações:

//Utilize a fórmula: IMC = peso / (altura * altura).
//Classifique o usuário conforme as faixas do IMC.
//Considerações:

//Cálculo correto do IMC.
//Exibição da classificação correta.

Console.WriteLine("Digite seu peso em kg:");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura em metros:");
double altura = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);
// cria variável classificacao e usa casos do switch para determinar como será inicializada
string classificacao = imc switch
{
    < 18.5 => "Abaixo do peso",
    > 18.5 and <= 24.9 => "Peso normal",
    > 24.9 and <= 29.9 => "Sobrepeso",
    > 29.9 and <= 34.9 => "Obesidade grau 1",
    > 34.9 and <= 39.9 => "Obesidade grau 2",
    > 39.9 => "Obesidade grau 3",
    _ => "IMC inválido",
};

Console.WriteLine($"Sua classificação é: {classificacao}");
