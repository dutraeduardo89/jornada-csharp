using System;

namespace ExFixacao18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
                Console.WriteLine("O número digitado: {0}, é par.", n1);
            else 
                Console.WriteLine("O número digitado: {0}, é impar.", n1);

        }
    }
}