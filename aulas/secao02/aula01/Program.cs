//TIPOS DE DADOS BÁSICOS C#

//VARIÁVEIS SERVEM PARA ARMAZENAR DADOS. ELAS TÊM UM TIPO E UM VALOR.
//BYTE: 8 BITS, ARMAZENA NÚMEROS DE 0 A 255
//SBYTE: 8 BITS, ARMAZENA NÚMEROS DE -128 A 127

//TIPOS INTEIROS, ARMAZENAM NÚMEROS INTEIROS POSITIVOS E NEGATIVOS
//INT: 32 BITS, ARMAZENA NÚMEROS DE -2147483648 A 2147483647
//UINT: 32 BITS, ARMAZENA NÚMEROS DE 0 A 4294967295
//LONG: 64 BITS, ARMAZENA NÚMEROS DE -9223372036854775808 A 9223372036854775807
//ULONG: 64 BITS, ARMAZENA NÚMEROS DE 0 A 18446744073709551615

//TIPOS FLUTUANTES, ARMAZENAM NÚMEROS COM CASAS DECIMAIS
//FLOAT: 32 BITS, ARMAZENA NÚMEROS COM PRECISÃO DE 6 A 7 DÍGITOS
//DOUBLE: 64 BITS, ARMAZENA NÚMEROS COM PRECISÃO DE 15 A 16 DÍGITOS
//DECIMAL: 128 BITS, ARMAZENA NÚMEROS COM PRECISÃO DE 28 A 29 DÍGITOS

//BOOLEAN: TRUE OU FALSE

//CHAR: ARMAZENA UM ÚNICO CARACTERE
//STRING: ARMAZENA UMA SEQUÊNCIA DE CARACTERES
//OBJECT: ARMAZENA QUALQUER TIPO DE DADO
//VAR: O COMPILADOR INFERE O TIPO DA VARIÁVEL
//DYNAMIC: O TIPO É DEFINIDO EM TEMPO DE EXECUÇÃO
//NULLABLE: PERMITE QUE TIPOS DE VALOR RECEBAM NULL
//ENUM: ARMAZENA UM CONJUNTO DE CONSTANTES
//STRUCT: TIPO DE VALOR QUE AGRUPA DADOS
//CLASS: TIPO DE REFERÊNCIA QUE AGRUPA DADOS E MÉTODOS

//cw + TAB + TAB = Console.WriteLine();


using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de dado + nome da variável = valor
            sbyte x = 100;
            Console.WriteLine(x); //Imprime o valor da variável no console

            //Valor máximo do tipo sbyte
            x = 127;

            unchecked //Sempre que for usar um tipo de dado que pode extrapolar o valor máximo, usar unchecked
            {
                x++; //Extrapola o valor máximo do tipo sbyte e volta para -128
            }

            Console.WriteLine(x);

            //Valor máximo do tipo byte
            byte n1 = 255;

            unchecked
            {
                n1++; //Extrapola o valor máximo do tipo byte e volta para 0
            }

            Console.WriteLine(n1); //Imprime o valor da variável n1

            //Overflow: ocorre quando um valor extrapola o valor máximo
            //que o tipo de dado consegue armazenar.
            //Quando ocorre overflow, é recomendado utilizar um tipo maior.

            int n2 = 1000;
            Console.WriteLine(n2);

            //Maior valor positivo que o tipo int pode armazenar
            int n3 = 2147483647;
            Console.WriteLine(n3);

            unchecked
            {
                n3++; //Extrapola o valor máximo do tipo int e volta para -2147483648
            }

            Console.WriteLine(n3);

            //Valor que ultrapassa o limite do int, por isso usamos long
            long n4 = 2147483648L;
            Console.WriteLine(n4);

            bool completo = false;
            Console.WriteLine(completo);

            //char armazena um único caractere
            //Deve ser colocado entre aspas simples
            char genero = 'F';
            Console.WriteLine(genero);

            //\u0041 é o código Unicode da letra A
            char letra = '\u0041';
            Console.WriteLine(letra);

            float n5 = 4.5f; //Tem que colocar o f no final para indicar que é um float
            Console.WriteLine(n5);

            double n6 = 4.5; 
            Console.WriteLine(n6);

            decimal n7 = 4.5m; //Tem que colocar o m no final para indicar que é um decimal
            Console.WriteLine(n7);

            //Uma cadeia de caractreres unicode e imutável.
            string nome = "Maithe"; //string tem que ser  entre aspas duplas
            Console.WriteLine(nome);

            object obj1 = "Alex Green";  //object é um tipo de dado que pode armazenar qualquer tipo de dado.
            Console.WriteLine(obj1);
            //Toda classe do C# 'e uma subclasse de object.

            object obj2 = 4.5f;
            Console.WriteLine(obj2);

            int a = int.MinValue; //int.MinValue é o menor valor que o tipo int pode armazenar
            Console.WriteLine(a);

            int b = int.MaxValue; //int.MaxValue é o maior valor que o tipo int pode armazenar
            Console.WriteLine(b);

            unchecked
            {
                b++; //Extrapola o valor máximo do tipo int e volta para o menor valor
            }
            Console.WriteLine(b);
            
            sbyte c = sbyte.MinValue;
            Console.WriteLine(c);

            sbyte d = sbyte.MaxValue;
            Console.WriteLine(d);

            decimal e = decimal.MinValue;
            Console.WriteLine(e);

        }
    }
}