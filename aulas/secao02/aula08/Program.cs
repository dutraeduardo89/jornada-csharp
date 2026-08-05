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
            char ch1 = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            int codigo = int.Parse(vet[2]);
            char genero = char.Parse(vet[3]);

            Console.WriteLine(n1);
            Console.WriteLine(ch1);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(codigo);
            Console.WriteLine(genero);

            
        }
    }
}   