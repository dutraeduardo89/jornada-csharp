using System;
using System.Globalization;

namespace Ex_Fixacao14{
    class Program{

        static void Main(string[] args)
        {

            Console.WriteLine("Seu codigo da primeira peca, quantidade e valor: ");

            string[] vetor = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vetor[0]);
            int peca1 = int.Parse(vetor[1]);
            double valor1 = double.Parse(vetor[2]);

            Console.WriteLine("Seu codigo da segunda peca, quantidade e valor: ");

            string[] vetor2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vetor2[0]);
            int peca2 = int.Parse(vetor2[1]);
            double valor2 = double.Parse(vetor2[2]);

            double total = (peca1 * valor1) + (peca2 * valor2);
            Console.WriteLine("Total a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}