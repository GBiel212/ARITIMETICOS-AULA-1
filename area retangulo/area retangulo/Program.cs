using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Base do Retângulo: ");
                        double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Altura do Retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A área do retângulo é: " + (baseRetangulo * alturaRetangulo));

            Console.WriteLine(" Obrigado por usar o programa! Pressione qualquer tecla para sair...");
            Console.ReadKey();








        }
    }
}
