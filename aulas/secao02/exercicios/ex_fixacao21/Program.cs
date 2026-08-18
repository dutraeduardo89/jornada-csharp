using System;

namespace ExFixacao21
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Digite o código do produto e a quantidade: ");

            Console.WriteLine("==============================================");
            Console.WriteLine(" CÓDIGO        ESPECIFICAÇÃO          PREÇO");
            Console.WriteLine("==============================================");
            Console.WriteLine("   1           Cachorro Quente        R$ 4.00");
            Console.WriteLine("   2           X-Salada               R$ 4.50");
            Console.WriteLine("   3           X-Bacon                R$ 5.00");
            Console.WriteLine("   4           Torrada simples        R$ 2.00");
            Console.WriteLine("   5           Refrigerante           R$ 1.50");
            Console.WriteLine("==============================================");

            double[] preco = { 4.00, 4.50, 5.00, 2.00, 1.50 };

            string[] produtos =
            {
                "Cachorro Quente",
                "X-Salada",
                "X-Bacon",
                "Torrada simples",
                "Refrigerante"
            };

            string[] vetor = Console.ReadLine().Split(' ');
            int c1 = int.Parse(vetor[0]);
            int qtd = int.Parse(vetor[1]);

            double total = 0;

           

            switch (c1)
            {
                case 1:
                    total = qtd * preco[0];
                    Console.WriteLine("Produto: {0}, código: {1}, quantidade: {2}, Total: R$ {3:F2}", produtos[0], c1, qtd, total);
                    break;

                case 2:
                    total = qtd * preco[1];
                    Console.WriteLine("Produto: {0}, código: {1}, quantidade: {2}, Total: R$ {3:F2}", produtos[1], c1, qtd, total);
                    break;

                case 3:
                    total = qtd * preco[2];
                    Console.WriteLine("Produto: {0}, código: {1}, quantidade: {2}, Total: R$ {3:F2}", produtos[2], c1, qtd, total);
                    break;

                case 4:
                    total = qtd * preco[3];
                    Console.WriteLine("Produto: {0}, código: {1}, quantidade: {2}, Total: R$ {3:F2}", produtos[3], c1, qtd, total);
                    break;

                case 5:
                    total = qtd * preco[4];
                    Console.WriteLine("Produto: {0}, código: {1}, quantidade: {2}, Total: R$ {3:F2}", produtos[4], c1, qtd, total);
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}