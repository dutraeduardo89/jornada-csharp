using System;

namespace Ex_Fixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "PC";
            string produto2 =  "Office desk";
            int codigo = 5290;
            byte idade = 30;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preco é {1:F2})", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é {1:F2})", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero); 
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado: (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: (três casas decimais): {0:F3, CultureInfo.InvariantCulture}", medida);
            

        }
    }
}