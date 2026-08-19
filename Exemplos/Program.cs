using Exemplos.fixacao;
using Exemplos.Salario;
using Exemplos.desconto;

CalculaDesconto calculaDesconto= new CalculaDesconto();

Console.WriteLine("Informe o valor do produto: ");
double s = double.Parse(Console.ReadLine());
Console.WriteLine("informe o percentual de desconto: ");
double p = double.Parse(Console.ReadLine());

Console.WriteLine($"Valor antigo: {s}");
Console.WriteLine($"Valor novo: {calculaDesconto.descontoProd(s,p)}");
Console.WriteLine($"Valor desconto: {calculaDesconto.valorDesconto(s,p)}");
