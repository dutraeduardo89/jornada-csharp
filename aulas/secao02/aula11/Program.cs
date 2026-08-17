//Estrutura condicional if-else

//Serve para a tomada de decisões com base em condições.
//Se a condição for verdadeira, o bloco de código dentro do if é executado.
//Se a condição for falsa, o bloco de código dentro do else é executado.

//Sintaxe:

//if (condição) {
//    //bloco de código a ser executado se a condição for verdadeira
//} else {
//    //bloco de código a ser executado se a condição for falsa
//}

//Estrutura simples: 
 
//Só funciona se a condição for verdadeira.

//if (condição) {
//    //bloco de código a ser executado se a condição for verdadeira
//}

//Estrutura composta: 

// //Só funciona se a condição for verdadeira retorna o bloco de código dentro do if, ou retorna o bloco de código dentro do else se a condição for falsa.

//if (condição) {
//    //bloco de código a ser executado se a condição for verdadeira
//} else {
//    //bloco de código a ser executado se a condição for falsa
//}

//Estrutura encadeada: 

//Só funciona se a condição for verdadeira retorna o bloco de código dentro do if, 
// ou retorna o bloco de código dentro do else if se a condição for falsa, ou retorna o bloco de código dentro do else se a condição for falsa.

//if (condição) {
//    //bloco de código a ser executado se a condição for verdadeira
//} else if (condição) {
//    //bloco de código a ser executado se a condição for verdadeira
//} else {
//    //bloco de código a ser executado se a condição for falsa
//}

//If signifca se, 
//Else signifca senão,
//Else if signifca senão se,




using System;
using System.Globalization;

namespace Aula11{
    class Program{
        static void Main(string[] args){

            int x = 10;
            Console.WriteLine(x);

            Console.WriteLine("Bom dia!");

            if ( x < 5){ //Só executa se a condição for verdadeira.
                Console.WriteLine("Boa tarde!"); //Não vai ser executado porque a condição é falsa.
            }

            if ( x > 5){ //Só executa se a condição for verdadeira.
                Console.WriteLine("Boa tarde!"); //Vai ser executado porque a condição é verdadeira.
            }



            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine()); //Entrada de um número inteiro pelo usuário.


            if(num % 2 == 0){ //Verifica se o resto da divisão por 2 do número digitado pelo usuário é igual a 0.
                //Se a condição for verdadeira, executa o bloco de código dentro do if. 
                Console.WriteLine("Este número é par: {0}", num); //Exibe que o número é par. O {0} é um placeholder para o número digitado pelo usuário.
            }else{
                //Se a condição for falsa, executa o bloco de código dentro do else.
                Console.WriteLine("Este número é impar: {0}", num); //Exibe que o número é impar. O {0} é um placeholder para o número digitado pelo usuário.
            }

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12){ //Se a hora for menor que 12, executa o bloco de código dentro do if.
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18){ //Se a hora for menor que 18, executa o bloco de código dentro do else if.
                Console.WriteLine("Boa tarde!");

            }else { //Se a hora for maior que 18, executa o bloco de código dentro do else.
                Console.WriteLine("Boa noite!");
            }


        }
    }

}