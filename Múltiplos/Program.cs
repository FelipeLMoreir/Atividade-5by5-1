// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite dois números: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int Multiplo = A % B;

if (Multiplo == 0)
{
    Console.WriteLine("São múltiplos");
}
else
{
    Console.WriteLine("Não são múltiplos");
}
