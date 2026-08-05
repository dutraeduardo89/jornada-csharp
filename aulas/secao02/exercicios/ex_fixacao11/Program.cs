using System;

namespace Ex_Fixacao11{
    class Program{


        static double area (double raio){
        return 3.14159 * Math.Pow(raio, 2.0);
                       
        }
        
        


        static void Main(string[] args)
        {
            
            
            Console.WriteLine("DIigte o valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine());
           
           Console.WriteLine("A area do circulo é: " + area(raio));
           


            





            
        }
    }
}   