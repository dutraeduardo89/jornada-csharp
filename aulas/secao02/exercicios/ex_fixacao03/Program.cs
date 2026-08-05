using System;
using System.Globalization;

namespace ExFixacao03;

class Program
{


    static double mult(double[] A_ret){
        
        return A_ret[0] * A_ret[1];
        
    }

    static void input(double[] A_ret){
        
        for (int i = 0; i < 2; i++){


            if (i == 0){
                Console.WriteLine("Digite o valor da base: ");
            }

            if (i == 1){
                Console.WriteLine("Digite o valor da altura: ");
            }
            
            A_ret[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
        }
    }

    
    static void Main(string[] args)
    {

        
        double[] A_ret = new double[2];

        input(A_ret);
        
        
        Console.WriteLine("A area do retangulo é: " + mult(A_ret));
        Console.WriteLine("Deseja continuar? (s/n)");
        string continuar = Console.ReadLine();
        while (continuar == "sim"){
            input(A_ret);
            Console.WriteLine("Deseja continuar? (s/n)");
            continuar = Console.ReadLine();
        }
    }
}