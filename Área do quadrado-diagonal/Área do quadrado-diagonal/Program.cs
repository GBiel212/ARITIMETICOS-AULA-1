using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_do_quadrado_diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a diagonal do quadrado:");
            double diagonal = Convert.ToDouble(Console.ReadLine());
            double area = (diagonal * diagonal) / 2;
            Console.WriteLine("A área do quadrado é: " + area); 
        }
    }
}
