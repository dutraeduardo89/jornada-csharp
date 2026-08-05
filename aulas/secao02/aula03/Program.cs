//Imprimir saída padrão no console
//Comandos: 

//Console.WriteLine( valor );
//Console.Write( valor );



using System;
using System.Globalization; //Serve para usar a cultura invariante para evitar problemas de formatação com diferentes culturas

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!"); //Escreve na mesma linha
            Console.WriteLine("Boa tarde!"); //Escreve e pula uma linha
            Console.WriteLine("Boa noite!"); 
    
            Console.WriteLine("--------------------------------");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maithe";
             
             Console.WriteLine(genero);
             Console.WriteLine(idade);
             Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //ToString("F2", CultureInfo.InvariantCulture) 
             //para formatar o saldo com 2 casas decimais e usar a cultura invariante para evitar problemas de formatação com diferentes culturas
             //To String serve para converter o saldo para uma string e formatar o numero de casas decimais
             //CultureInfo.InvariantCulture é uma classe que representa a cultura invariante, que é a cultura padrão do sistema
             Console.WriteLine(nome);        

            Console.WriteLine("--------------------------------");

            //Exemplo de uso de placeholder

            Console.WriteLine("{0} tem {1} anos, genero {2} e tem saldo igual a {3:F2} reais", nome, idade, genero, saldo);
            //{0} é o primeiro parametro, {1} é o segundo parametro, {2} é o terceiro parametro, {3} é o quarto parametro
            //:F2 é o formato de saida para 2 casas decimais
            //Depois que passar os parametros, colocar uma virgula e depois colocar as variavéis que seram exibidas

            Console.WriteLine("--------------------------------");

            //Exemplo de uso de interpolação de strings
            
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //Usa o cifrão para exibir o valor da variavel e o :F2 para formatar o numero de casas decimais
            //Colocar o nome da variavel entre chaves

            Console.WriteLine("--------------------------------");

            //Exemplo de uso de concatenação de strings
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            //Usa o sinal de mais para concatenar as strings
            //Colocar o nome da variavel entre aspas e depois colocar o sinal de mais e a variavel
            //Depois que passar os parametros, colocar uma virgula e depois colocar as variavéis que seram exibidas

           
        }
    }
}