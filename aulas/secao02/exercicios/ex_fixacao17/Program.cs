using System;

namespace ExFixacao17
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
                Console.WriteLine("Número digitado: {0}, é negativo", n1);
            else if(n1 == 0)
                Console.WriteLine("Número digitado: {0}, é neutro", n1);
            else
                Console.WriteLine("Número digitado: {0}, é positivo", n1);

        }
    }
}