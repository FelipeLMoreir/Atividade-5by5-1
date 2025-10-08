// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 3 notas: ");
float Nota1 = float.Parse(Console.ReadLine());
float Nota2 = float.Parse(Console.ReadLine());
float Nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite os 3 pesos: ");
float Peso1 = float.Parse(Console.ReadLine());
float Peso2 = float.Parse(Console.ReadLine());
float Peso3 = float.Parse(Console.ReadLine());

float Media = ((Nota1 * Peso1) + (Nota2 * Peso2) + (Nota3 * Peso3)) / (Peso1 + Peso2 + Peso3);

Console.WriteLine($"A média é: {Media}");

if (Media >= 9)
{
    Console.WriteLine("A");
}

else if (Media >= 7 && Media < 9)
{
    Console.WriteLine("B");
}

else if ((Media >= 5 && Media < 7))
{
    Console.WriteLine("C");
}

else if (Media < 5)
{
    Console.WriteLine("D");
}

else
{
    Console.WriteLine("Valor Inválido");
}