//Operadores comparativos
//Servem para comparar valores. Retorna um valor booleano (verdadeiro ou falso).

// == compara se dois valores são iguais.
// != compara se dois valores são diferentes.
// > compara se um valor é maior que o outro.
// < compara se um valor é menor que o outro.
// >= compara se um valor é maior ou igual ao outro.
// <= compara se um valor é menor ou igual ao outro.


using System;

namespace Aula09{
    class Program{
        static void Main(string[] args){

            int a = 10;

            bool c1 = a < 10;
            Console.WriteLine(c1); //Resulatdo da condição. (false) porque a não é menor que 10.

            bool c2 = a < 20;
            Console.WriteLine(c2); //Resultado da condição. (true) porque a é menor que 20.

            bool c3 = a > 10;
            Console.WriteLine(c3); //Resultado da condição. (false) porque a não é maior que 10.

            bool c4 = a > 5;
            Console.WriteLine(c4); //Resultado da condição. (true) porque a é maior que 5.

            Console.WriteLine("--------------------------------"); 

            bool c5 = a <= 10; //Resultado da condição. (true) porque a é menor ou igual a 10.
            Console.WriteLine(c5); 

            bool c6 = a >= 10; //Resultado da condição. (true) porque a é maior ou igual a 10.
            Console.WriteLine(c6); 

            bool c7 = a == 10; //Resultado da condição. (true) porque a é igual a 10.
            Console.WriteLine(c7); 

            bool c8 = a != 10; //Resultado da condição. (false) porque a não é diferente de 10.
            Console.WriteLine(c8); 

            

             
        }
    }
}