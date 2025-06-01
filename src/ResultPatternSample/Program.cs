using ResultPatternSample.Services;

var calculator = new CalculatorService();

var result = calculator.Divide(10, 0);

if (result.Success)
{
    Console.WriteLine($"Resultado: {result.Value}");
}
else
{
    Console.WriteLine($"Erro: {result.Error}");
}