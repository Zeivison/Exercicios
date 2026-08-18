using Exemplos.fixacao;
using Exemplos.Salario;

AumentoSalarial aumentoSalarial= new AumentoSalarial();

Console.WriteLine("Informe o salario: ");
double s = double.Parse(Console.ReadLine());
Console.WriteLine("informe o percentual de aumento: ");
double p = double.Parse(Console.ReadLine());

Console.WriteLine($"Salario antigo: {s}");
Console.WriteLine($"Salario novo: {aumentoSalarial.aumentoSalario(s,p)}");
Console.WriteLine($"Salario aumento: {aumentoSalarial.valorAumento(s,p)}");
