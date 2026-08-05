using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do produto: ");
        double produto = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a porcentagem do desconto: ");
        double porc = double.Parse(Console.ReadLine());
        
        
        double valorDesconto = produto * (porc / 100);
        double vfp = produto - valorDesconto;
        
        Console.WriteLine("Total desconto = " + valorDesconto.ToString("F2"));
        Console.WriteLine("Valor a pagar = " + vfp.ToString("F2"));
        
    }
}
