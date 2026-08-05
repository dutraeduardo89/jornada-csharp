//Entrada de dados
//Console.ReadLine() - Leitura de dados do teclado (string)
//Le da entrada padrao ate a quebra de linha.
//Retorna os dados lidos  na forma de string.

//Vetores: Array unidimensional de elementos do mesmo tipo
//Vetor é uma estrutura de dados que armazena uma colecao de elementos do mesmo tipo.
//split: Divide a string em partes baseado em um delimitador

using System;

namespace Aula07{
    class Program{
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine(frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}   