///Conversao implicita de tipos
/// explicita de tipos (casting)

/// Conversao implicita de tipos é a conversão de um tipo para outro tipo que é mais amplo
/// Conversao explicita de tipos é a conversão de um tipo para outro tipo que é mais restrito

//Implicita: Quando voce quer converter do tipo de dado mais restrito para o tipo de dado mais amplo
//Explicita (Casting): Quando voce quer converter do tipo de dado mais amplo para o tipo de dado mais restrito

using System;

namespace Aula05{
    class Program{
        static void Main(string[] args)
        {

            // Conversao implicita de tipos por conta de que o float é mais restrito que o double
            // O double é mais amplo que o float 
            // Por isso, o float pode ser convertido para double sem perda de informação
            //FLoat tem 4 bytes e double tem 8 bytes, cabe perfeitamente

            
            float x = 4.5f;

            double y = x;
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;

            b = (float)a; 
            //(tipo de dado) (variavel) = (valor)
            //Tem que por o (float) para converter o double para float, tendo em vista que o float é mais restrito que o double e havera perda de informação
            Console.WriteLine(b);

            double c;
            int d; 

            c = 5.2;
            d = (int)c; //Havera perda de informação, pois o double é mais amplo que o int e havera truncamento (perda de casas decimais)
            Console.WriteLine(d);


            int e = 5;
            int f = 2; 

            double resultado = e / (double)f; //Sem o double, o resultado seria 2, pois e(variavel) e f(variavel) sao int e a divisao de int por int resulta em int
            Console.WriteLine(resultado);

        }
    }
}   