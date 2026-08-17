using System;

//Operadores de atribuição (operadores de atribuição são usados para atribuir valores a variáveis)  
// = Atribuição de valor (valor direto)
// += Atribuição de valor com adição (valor + valor)
// -= Atribuição de valor com subtração (valor - valor) (subtrai o valor em 1)
// *= Atribuição de valor com multiplicação (valor * valor) (multiplica o valor em 1)
// /= Atribuição de valor com divisão (valor / valor) (divide o valor em 1)
// %= Atribuição de valor com resto (valor % valor) (resto da divisão) 
// ++ Atribuição de valor com incremento (valor + 1) (incrementa o valor em 1)
// -- Atribuição de valor com decremento (valor - 1) (decrementa o valor em 1)




namespace Aula04{
    class Program{

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a*= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 2;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12){
                Console.WriteLine("Bom dia!");
            }
            else if(hora < 18){
                Console.WriteLine("Boa tarde!");

            }else {
                Console.WriteLine("Boa noite!");
            }

            
        }
    }
}   

