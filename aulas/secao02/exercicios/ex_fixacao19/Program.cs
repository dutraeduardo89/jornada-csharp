using System;

namespace ExFixacao19
{
    class Program
    {
        static void Main()
        {
            
            string[] vetor = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vetor[0]);
            int n2 = int.Parse(vetor[1]);

            if (n1 > n2 && n1 % n2 == 0)
                Console.Write("Os números {0} e {1} que foram digitados são múltiplos.",n1, n2);            
            else if (n2 > n1 && n2 % n1 == 0)
                Console.Write("Os números {0} e {1} que foram digitados são múltiplos.",n1, n2);
            else 
                Console.Write("Os números {0} e {1} que foram digitados não são múltiplos.",n1, n2);
                
                

            
                          

        }
    }

}