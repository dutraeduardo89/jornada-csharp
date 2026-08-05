//Operadores aritmeticos

// + Adição (soma de valores)
// - Subtração (subtração de valores)
// * Multiplicação (multiplicação de valores)
// / Divisão (divisão de valores)
// % Resto da divisão (resto da divisão de valores)
// ++ Incremento (incrementa o valor em 1)
// -- Decremento (decrementa o valor em 1)

//Notas: 
//1) * / % tem precedencia sobre + -
//2) () tem precedencia sobre * / % + -
//3) O que mod(resto da divisão) faz é pegar o resto da divisão de um numero por outro numero

using System;

namespace Aula06{
    class Program{
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; //Primeiro faz a multiplicação e depois a adição por conta de que * tem precedencia sobre +
            Console.WriteLine(n1);
            int n2 = (3 + 4) * 2; //Primeiro faz a adição e depois a multiplicação por conta de que () tem precedencia sobre *
            Console.WriteLine(n2);
            int n3 = 17 % 3; //O que mod faz é pegar o resto da divisão de 17 por 3
            Console.WriteLine(n3);

            double n4 = 10 / 8.0; //Usar casas decimais ou casting para que o resultado saia como um double pra nao ser int
            Console.WriteLine(n4);
        }
    }
}   