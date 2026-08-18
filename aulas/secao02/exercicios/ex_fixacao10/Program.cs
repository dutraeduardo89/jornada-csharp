using System;

namespace ExFixacao10{
    class Program{
        static void Main(string[] args)
        {
            int[] num = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º numero: ");
                num[i] = int.Parse(Console.ReadLine());
                
            }

            int soma = num[0] + num[1];

            Console.WriteLine("Soma: " + soma);
        }
    }
}   