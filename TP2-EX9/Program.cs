//screva um programa que solicite o salário bruto do usuário e calcule o valor líquido após descontos de impostos. 

//Observações:

//Utilize faixas de imposto definidas no código.
//Exiba o salário bruto, os descontos e o salário líquido.
//Considerações:

//Uso correto de estruturas condicionais.
//Cálculo correto dos descontos.
//Exibição formatada das informações.

Console.WriteLine("Digite seu salário bruto:");
double salarioBruto = double.Parse(Console.ReadLine());
try
{
    double aliquotaIR = salarioBruto switch
    {
        > 0 and <= 2428.8 => 0,
        > 2428.8 and <= 2826.65 => 0.075,
        > 2826.65 and <= 3751.05 => 0.15,
        > 3751.05 and <= 4664.68 => 0.225,
        > 4664.68 => 0.275,
        _ => throw new Exception("Salário inválido.") // Salário negativo
    };
    double ir = salarioBruto * aliquotaIR;
    double salarioLiquido = salarioBruto - ir;
    Console.WriteLine($"Salário Bruto: {salarioBruto}\n" +
        $"Desconto IR: {ir:F2}\n" +
        $"Salário Líquido: {salarioLiquido:F2}");
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}
