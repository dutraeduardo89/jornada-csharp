using System;

namespace ExFixacao12{
    class Program{

        

        static int soma(int[] vetor){
            int diferenca = (vetor[0] * vetor[1 ] - vetor[2] * vetor[3]);
            return diferenca;
        }

        static void Main(string[] args)
        {
            int[] vetor = new int[4];

            for (int i = 0; i < 4; i++){
                Console.WriteLine("Digite {0} numero:", i+1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A diferenca é: " + soma(vetor));
        }
    }
}