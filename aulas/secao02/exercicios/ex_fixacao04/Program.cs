using System;

namespace ExFixacao04;

class Program
{
    static int Sum(double[] num){
        return (int)num.Sum();
    }

    static int media(double[] num){

        return Sum(num) / num.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de números: ");
        int quantidade = int.Parse(Console.ReadLine());

        double[] num = new double[(int)quantidade];

        for (int i = 0; i < quantidade; i++){
            Console.WriteLine($"Digite o {i + 1}º número: ");
            num[i] = double.Parse(Console.ReadLine());           
        }

        
        Console.WriteLine("A média dos números é: " + media(num));
    }
}