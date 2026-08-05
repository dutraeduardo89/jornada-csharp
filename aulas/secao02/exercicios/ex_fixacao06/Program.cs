using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o peso em kg:");
        double peso = double.Parse(Console.ReadLine());

        double peso_gramas = peso * 1000;
        Console.WriteLine("O peso em gramas é: " + peso_gramas);

        peso += peso * 0.1;
        Console.WriteLine("O peso com o acréscimo de 10% é: " + peso);

        
        Console.WriteLine("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("O IMC é: " + imc.ToString("F2")); 

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc >= 30 && imc <= 34.9)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc >= 35 && imc <= 39.9)
        {
            Console.WriteLine("Obesidade grau II"); /
        }
        else
        {
            Console.WriteLine("Obesidade grau III"); 
        }


    }
}
