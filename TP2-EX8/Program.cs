//Desenvolva um programa que peça ao usuário uma nota de 0 a 10 e classifique-a como "Insuficiente", "Regular", "Bom" ou "Excelente". 

//Observações:

//Utilize estruturas condicionais para determinar a classificação.
//Considerações:

//Uso adequado das estruturas condicionais.
//Classificação correta conforme a nota informada.

Console.WriteLine("Digite uma nota de 0 a 10:");
double nota = double.Parse(Console.ReadLine());
string classificacao = nota switch
{
    < 5 => "Insuficiente",
    >= 5 and < 7 => "Regular",
    >= 7 and < 9 => "Bom",
    >= 9 and <= 10 => "Excelente",
    _ => "Inválida"
};

Console.WriteLine($"Sua classificação é: {classificacao}.");