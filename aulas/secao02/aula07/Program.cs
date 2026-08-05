//Entrada de dados
//Console.ReadLine() - Leitura de dados do teclado (string)
//Le da entrada padrao ate a quebra de linha.
//Retorna os dados lidos  na forma de string.

//Vetores: Array unidimensional de elementos do mesmo tipo
//Vetor é uma estrutura de dados que armazena uma colecao de elementos do mesmo tipo.
//split: Divide a string em partes baseado em um delimitador
//Comeca com indice 0 por motivos de eficiencia de memoria e processamento.


using System;

namespace Aula07{
    class Program{
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] vet = s.Split(' ');
            int p1 = vet[0];
            int p2 = vet[1];
            int p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p3);
        }
    }
}   