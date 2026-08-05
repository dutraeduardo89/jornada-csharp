using System;
using System.Globalization;

namespace Ex_Fixacao13{
    class Program{

        static double salario(int horas, double valor){
            return horas * valor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Seu numero de funcionario: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu valor da hora trabalhada: ");
            double valor = double.Parse(Console.ReadLine());


            
            Console.WriteLine("Seu salario é: " + salario(horas, valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}