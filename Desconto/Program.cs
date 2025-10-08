// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o valor do produto: ");
float valorProduto = float.Parse(Console.ReadLine());

Console.WriteLine("Selecione a forma de pagamento(1 para à vista e 2 para parcelado): ");
int Pagamento = int.Parse(Console.ReadLine());

switch (Pagamento)
{
    case 1:
        Console.WriteLine($"O valor do produto é {valorProduto - 0.10}");
        break;
    
    case 2:
        Console.WriteLine($"O valor do produto é {valorProduto}");
        break;
}
    

