using System;

class Program
{
    static double Sum(double[] num)
    {
        return num[0] + num[1];
    }

    static double Subtract(double[] num)
    {
        return num[0] - num[1];
    }

    static double Multiply(double[] num)
    {
        return num[0] * num[1];
    }

    static double Divide(double[] num)
    {
        return num[0] / num[1];
    }

    static void Calculate(double[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            num[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Digite a operação: ");
        string operation = Console.ReadLine().ToLower();

        if (operation == "soma")
        {
            Console.WriteLine("A soma dos números é: " + Sum(num));
        }
        else if (operation == "subtracao")
        {
            Console.WriteLine("A subtração dos números é: " + Subtract(num));
        }
        else if (operation == "multiplicacao")
        {
            Console.WriteLine("A multiplicação dos números é: " + Multiply(num));
        }
        else if (operation == "divisao")
        {
            if (num[1] == 0)
            {
                Console.WriteLine("Erro: divisão por zero.");
            }
            else
            {
                Console.WriteLine("A divisão dos números é: " + Divide(num));
            }
        }
        else
        {
            Console.WriteLine("Operação inválida.");
        }
    }

    static void Main(string[] args)
    {
        double[] num = new double[2];

        Calculate(num);

        Console.WriteLine("Deseja continuar? (s/n)");
        string continuar = Console.ReadLine().ToLower();

        while (continuar == "s")
        {
            Calculate(num);

            Console.WriteLine("Deseja continuar? (s/n)");
            continuar = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Programa encerrado.");
    }
}