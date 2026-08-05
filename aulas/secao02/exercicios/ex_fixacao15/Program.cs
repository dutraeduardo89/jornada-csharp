using System;
using System.Globalization;

namespace Ex_Fixacao15{
    class Program{

        static double areaTriangulo(double a, double c){
            return (a * c) / 2;
        }

        static double areaCirculo(double c, double pi){
            return Math.Pow(c, 2) * pi;
        }

        static double areaTrapezio(double a, double b, double c){
            return ((a + b) * c) / 2.0;
        }

        static double areaQuadrado(double b){
            return Math.Pow(b, 2);
        }

        static double areaRetangulo(double a, double b){
            return a * b;
        }



        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            double a = double.Parse(vetor[0]);
            double b = double.Parse(vetor[1]);
            double c = double.Parse(vetor[2]);

            double pi = 3.14159;

            Console.WriteLine("Area do triangulo: " + areaTriangulo(a, c).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do circulo: " + areaCirculo(c, pi).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do trapezio: " + areaTrapezio(a, b, c).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do quadrado: " + areaQuadrado(b).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do retangulo: " + areaRetangulo(a, b).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}