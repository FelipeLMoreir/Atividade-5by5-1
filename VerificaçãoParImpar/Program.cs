// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
float A = float.Parse(Console.ReadLine());

if (A % 2 == 0)
{
    Console.WriteLine($"{A} é par!");
}
else
{
    Console.WriteLine($"{A} é ímpar!");
}
