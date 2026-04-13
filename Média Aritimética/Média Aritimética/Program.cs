using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_Aritimética
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DiGITE O PRIMEIRO VALOR: ");
            Double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("DiGITE O SEGUNDO VALOR: ");
            Double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("DiGITE O TERCEIRO VALOR: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("DiGITE O QUARTO VALOR: ");   
            double valor4 = Convert.ToDouble(Console.ReadLine());




            Double media = (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine("A MÉDIA É: " + media);

            
            Console.WriteLine(" PARA CALCULAR A MÉDIA DE OUTROS VALORES, PRESSIONE QUALQUER TECLA PARA CONTINUAR OU 'ESC' PARA SAIR. ");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            Console.Clear();
            Main(args); 
        }
    }
}
