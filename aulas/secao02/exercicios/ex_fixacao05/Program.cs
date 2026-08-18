using System;

namespace ExFixacao05;

class Program
{
    static void Main(string[] args)
    {
        int escolha;
        int op; 
        double[] temperatura = new double[2];

        Console.WriteLine("Escolha a unidade de medida inicial: (1 - Celsius, 2 - Fahrenheit, 3 - Kelvin): ");
        escolha = int.Parse(Console.ReadLine());
        op = escolha;

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite a temperatura em Celsius: ");
                temperatura[0] = double.Parse(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                temperatura[0] = double.Parse(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Digite a temperatura em Kelvin: ");
                temperatura[0] = double.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Unidade de medida inválida");
                return; 
        }

        Console.WriteLine("Digite para qual unidade de medida você deseja converter: (1 - Celsius, 2 - Fahrenheit, 3 - Kelvin): ");
        escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1: 
                if (op == 1)
                {
                    temperatura[1] = temperatura[0];
                }
                else if (op == 2) 
                {
                    temperatura[1] = (temperatura[0] - 32) / 1.8; 
                }
                else if (op == 3) 
                {
                    temperatura[1] = temperatura[0] - 273.15; 
                }
                Console.WriteLine("A temperatura em Celsius é: " + temperatura[1]); 
                break;

            case 2: 
                if (op == 2)
                {
                    temperatura[1] = temperatura[0];
                }
                else if (op == 1) 
                {
                    temperatura[1] = (temperatura[0] * 1.8) + 32;
                }
                else if (op == 3) 
                {
                    temperatura[1] = (temperatura[0] - 273.15) * 1.8 + 32; 
                }
                Console.WriteLine("A temperatura em Fahrenheit é: " + temperatura[1]); 
                break;

            case 3: 
                if (op == 3)
                {
                    temperatura[1] = temperatura[0];
                }
                else if (op == 1) 
                {
                    temperatura[1] = temperatura[0] + 273.15;
                }
                else if (op == 2) 
                {
                    temperatura[1] = ((temperatura[0] - 32) / 1.8) + 273.15; 
                }
                Console.WriteLine("A temperatura em Kelvin é: " + temperatura[1]); 
                break;

            default:
                Console.WriteLine("Unidade de medida inválida");
                break;
        }
    }
}
