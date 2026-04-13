using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("DIGITE A TEMPERATURA EM GRAUS CELSIUS:");
                string input = Console.ReadLine();
                double celsius;
                if (double.TryParse(input, out celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("A TEMPERATURA EM FAHRENHEIT É: " + fahrenheit);

                    Console.WriteLine("DESEJA CONVERTER OUTRA TEMPERATURA? ( DIGITE SIM): ");
                    string retry = Console.ReadLine();
                    if (string.IsNullOrEmpty(retry) || retry.Trim().ToUpper() != "SIM")
                    {
                        Console.WriteLine("Obrigado por usar o conversor de temperaturas.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("ENTRADA INVÁLIDA. POR FAVOR, DIGITE UM NÚMERO.");
                    
                    Console.Write("DESEJA TENTAR NOVAMENTE? ( DIGITE SIM): ");
                    string retry = Console.ReadLine();
                    if (string.IsNullOrEmpty(retry) || retry.Trim().ToUpper() != "SIM")
                    {
                        Console.WriteLine("Obrigado por usar o conversor de temperaturas.");
                        break;
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR...");
            Console.ReadKey();
        }
    }
}
