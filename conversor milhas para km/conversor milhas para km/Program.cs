using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_milhas_para_km
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a distância em milhas:  ");
            double milhas = Convert.ToDouble(Console.ReadLine());

            double km = milhas * 1.852;
            Console.WriteLine($"{milhas} milhas equivalem a {km} quilômetros.");    

            
            Console.WriteLine("Obrigado por usar o conversor de milhas para quilômetros!"   );
           


            Console.WriteLine("digite qualquer tecla para sair...");
            
            Console.ReadKey();
                

        }
    }
}
