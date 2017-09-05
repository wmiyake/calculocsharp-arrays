using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero;
            double total;
            string operacao;

            total = 0;
            operacao = "+";

            while (operacao != "=")
            {
                Console.Write("Entre com o valor: ");
                numero = Convert.ToDouble(Console.ReadLine());

                switch (operacao)
                {
                    case "+":
                        total = total + numero;
                        break;
                    case "-":
                        total = total - numero;
                        break;
                    case "*":
                        total = total * numero;
                        break;
                    case "/":
                        total = total / numero;
                        break;

                }


                Console.Write("Digite a operaçâo: ");
                operacao = Console.ReadLine();


            }

            Console.WriteLine("O resultado é : " + total);
            Console.ReadKey();

        }
    }
}
