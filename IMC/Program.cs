// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu peso:");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura:");
float altura = float.Parse(Console.ReadLine());

float IMC = peso / (altura * altura);

if (IMC < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (IMC > 18.5 && IMC < 24.9)
{
    Console.WriteLine("Peso Normal");
}
else if (IMC > 25 && IMC < 29.9)
{
    Console.WriteLine("Sobrepeso");
}
else if (IMC >= 30)
{
    Console.WriteLine("Obesidade");
}
else
{
    Console.WriteLine("Valor Inválido");
}
