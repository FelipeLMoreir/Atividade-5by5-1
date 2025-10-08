// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 3 números: ");
float A = float.Parse(Console.ReadLine());
float B = float.Parse(Console.ReadLine());
float C = float.Parse(Console.ReadLine());

float Media = (A + B + C) / 3;

Console.WriteLine($"A média é: {Media} ");

if (Media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
