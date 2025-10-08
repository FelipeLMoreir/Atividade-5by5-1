// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o comprimento dos lados do triângulo: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());

if ((A < (B + C)) && (B < (A + C)) && (C < (A + B)))
{
    Console.WriteLine("É um triângulo");

    if ((A == C) && (C == B))
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if (A == B && A != C || A == C && C != B || B == C && B != A)
    {
        Console.WriteLine("O triângulo é isósceles");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}
else
{
    Console.WriteLine("Não é um triângulo!");
    return;
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

