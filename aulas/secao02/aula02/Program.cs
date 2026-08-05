//Restricoes para nome de variaveis:

//Não pode conter espaços
//Não usar acentos ou til
//Não pode conter espaços em branco
//Usar nomes que sejam significativos

//Convenções para nome de variaveis:

//CamelCase: lastName (paramêtro de metódos, variáveis dentro de metódos) 
//PascalCase: LastName (classes, interfaces, metódos, propriedades, campos, constantes, enumeracoes)
//Por padrão, o C# usa PascalCase para nomes de classes e interfaces.   


using System;

namespace ExemploPadroesCase
{
    // PascalCase: Usado para nomes de Classes e Namespaces
    public class GerenciadorConta
    {
        // PascalCase: Usado para Propriedades
        public string NomeCliente { get; set; }
        public decimal SaldoAtual { get; private set; }

        // camelCase: Usado para campos privados (geralmente com underline _)
        private DateTime _dataCriacao;

        // PascalCase: Usado para Construtores e Métodos
        public GerenciadorConta(string nomeInicial, decimal depositoInicial)
        {
            // camelCase: Usado para parâmetros de métodos
            NomeCliente = nomeInicial;
            SaldoAtual = depositoInicial;
            _dataCriacao = DateTime.Now;
        }

        // PascalCase: Usado para Métodos
        public void ProcessarDeposito(decimal valorDeposito)
        {
            // camelCase: Usado para variáveis locais
            decimal impostoMinimo = 0.05m;
            decimal valorLiquido = valorDeposito - impostoMinimo;

            SaldoAtual += valorLiquido;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
