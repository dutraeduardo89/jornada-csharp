//Operadores lógicos
//Servem para combinar valores booleanos. Retorna um valor booleano.

// && (AND) - Retorna true se todas as condições forem verdadeiras.
// || (OR) - Retorna true se pelo menos uma das condições for verdadeira.
// ! (NOT) - Retorna o inverso da condição. Se a condição for true, retorna false. Se a condição for false, retorna true.

//Regras:
//Precedência: !, &&, ||
//Associatividade: esquerda para direita
//Pode usar parênteses para alterar a precedência e agrupar condições.


using System;

namespace Aula10{
    class Program{
        static void Main(string[] args){
            
            bool c1 = 2 > 3 && 4 != 5; //Retorna (false) porque 2 não é maior que 3 e 4 é diferente de 5. 
            //Apenas uma das condições é falsa por isso o resultado é false.
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5; //Retorna (true) porque apenas uma das condições é (true) e a outra é (false. Por apenas uma ser verdadeira o resultado é (true).
            Console.WriteLine(c2);


            bool c3 = !(2 > 3) && 4 != 5; //Retorna (true) porque a primeira condição se torna (true) por conta do ! (NOT).
            //invertendo a saída da primeira condição, tornando-a (true), e a segunda condição é (true) porque 4 é diferente de 5.
            //O () torna a primeira  condição prioridade sobre a segunda.
            //O operador && (AND) retorna (true) se ambas as condições forem (true).
            //Saída final: (true) && (true) = (true).

            bool c4 = 10 < 5;  //Retorna (false) porque 10 não é menor que 5.
            Console.WriteLine(c4);

            bool c5 = c1 || c2 && c3; //Segunda condição (||) é (false) e a primeira (&&) é (true) por conta da condição.
            //&& tem precedência sobre ||, por isso a segunda condição é (true) e a primeira é (false).
            //O || (OR) retorna (true) se pelo menos uma das condições forem (true).
            //Saída final: (false) || (true) = (true).
            Console.WriteLine(c5);
        }
    }
}