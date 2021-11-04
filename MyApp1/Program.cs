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
            int type = Int32.Parse(Console.ReadLine());
            //type 1 = Soma
            //type 2 = Multi
            //type 3 = Divi

            if(type == 1)
            {
                int soma = numberOne + numberTwo;
                Console.WriteLine("A Soma foi:" + soma);
            }
            else if(type == 2)
            {
                int multiplcao = numberOne * numberTwo;
                Console.WriteLine("A Multiplicação foi:" + multiplcao);
            }
            else if(type == 3)
            {
                var divisao = numberOne / numberTwo;
                Console.WriteLine("A Divisão foi:" + divisao);
            }
            else
            {
                Console.WriteLine("Nenhum tipo encontrado");
            }

        }
    }
}
