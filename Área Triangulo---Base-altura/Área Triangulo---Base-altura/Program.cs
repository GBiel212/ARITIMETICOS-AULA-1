using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_Triangulo___Base_altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do triângulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());        

          Console.WriteLine("Digite a altura do triângulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("A área do triângulo é: " + areaTriangulo);

            Console.WriteLine("Parabens, você calculou a área do triângulo com sucesso!  ;)  " );

           Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();






        }
    }
}
