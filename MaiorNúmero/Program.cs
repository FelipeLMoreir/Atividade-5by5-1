// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite dois números: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if(A > B)
{
    Console.WriteLine($"{A} é maior que {B}");
}
else
{
    Console.WriteLine($"{B} é maior que {A}");
}
