//Escopo de uma variável 

//É a região de do programa onde a variável é válida, ou seja, ela pode ser referenciada. 

//Uma variável não pode ser usada, senão for iniciada. 

using System;

namespace Aula12{
    class Program{
        static void Main(){


            //int x;

            //Console.WriteLine(x); //Ao tentar imprimir, retorna erro pela tentativa de usar 
            //Uma variável não atribuída, ou seja, que não foi iniciada. 

            //Sempre é obrigatório independente da forma, você iniciar a variável com um valor. 

            //Escopo

            //Console.WriteLine("Digite o preço: ")

            //double preco = double.Parse(Console.ReadLine());

            //if (preco > 100.0)
                //double desconto = preco * 0.1;
            
            
            //Console.WriteLine(desconto); //Ao tentar imprimir essa variável, retorna erro porque ela
            //é iniciada somente ao rodar a estrutura de decisão, e ao fim dela, ela é deletada. Se pertencesse ao escopo global
            //ou seja, atribuida fora da estrutura de decisão, no escopo global, onde todos tem acesso,
            //e ela não vai ser deletada. Não ocorreria esse problema. 

            //Resolvendo este erro

            Console.WriteLine("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            //double desconto; Retorna erro se não atribuir o valor. Por isso iniciado, com valor 0.  

            if (preco > 100.0)
                desconto = preco * 0.1;
            Console.WriteLine(desconto);


            

        }
    }
}