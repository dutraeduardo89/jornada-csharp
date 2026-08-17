using System;

namespace ex_fixacao16{
    class Program{


        static string op(){
            
            string escolha = Console.ReadLine();

            bool continuar = true;

            switch (escolha.ToLower()){
                case "sim":
                    vector();
                    break;
                case "não":
                    continuar = false;
                    Console.WriteLine("Encerrando o programa");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida: ");
                    op();
                    break;                
            }

            return escolha;

            
        }

        static void vector(){


            Console.WriteLine("Digite o número inteiro de valores a ser armazenado: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] numero = new int [tamanho];

            Console.WriteLine("Digite um número");

            for(int i = 0; i < numero.Length; i++){

                numero[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Valores armazenados: ");

            foreach (int valor in numero){
                Console.WriteLine(valor);
            }

            
            Console.WriteLine("Deseja iniciar novamente?");
            op();


        }


        static void Main(string[] args){
            
            Console.WriteLine("Deseja inciar? Sim ou Não");
            op();

            
            

        }
    }
}