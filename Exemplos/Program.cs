using Exemplos;

Console.Write("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Idade = {idade}");
Console.WriteLine($"O nome informado foi {nome}");

Calculadora calc = new Calculadora();

int resultado = calc.Somar(22, 20);
Console.WriteLine($"O resultado da soma é: {resultado}");