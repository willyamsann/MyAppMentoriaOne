using System;

namespace MyApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora primeiro projeto");

            //Dois padrões que vamos utilizar
            //Normal: Willyam Santos de Oliveira
            //CamelCase: WillyamSantosDeOliveira

            //Regra que sempre vamos utilizar nome de variael sempre começa com minusculo
            int numberOne = Int32.Parse(Console.ReadLine());
            int numberTwo = Int32.Parse(Console.ReadLine());

            int soma = numberOne + numberTwo;
            int multiplcao = numberOne * numberTwo;
            var divisao = numberOne / numberTwo;

            Console.WriteLine("A Soma foi:" + soma);
            Console.WriteLine("A Multiplicação foi:" + multiplcao);
            Console.WriteLine("A Divisão foi:" + divisao);
        }
    }
}
