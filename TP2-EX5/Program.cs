// SDesenvolva um programa que peça ao usuário um valor em graus Celsius e o converta para Fahrenheit e Kelvin. 

//Observações:

//Utilize a fórmula: F = C * 9 / 5 + 32 e K = C + 273.15.
//Exiba os resultados com duas casas decimais.
//Considerações:

//Cálculo correto das conversões.
//Exibição formatada dos valores convertidos.

Console.WriteLine("Digite a temperatura em Celsius:");
double tempCelsius = double.Parse(Console.ReadLine());
double tempFahrenheit = (tempCelsius * 9 / 5) + 32;
double tempKelvin = tempCelsius + 273.15;

Console.WriteLine($"A temperatura {tempCelsius:F2}°C corresponde a {tempFahrenheit:F2}°F e {tempKelvin:F2}K");