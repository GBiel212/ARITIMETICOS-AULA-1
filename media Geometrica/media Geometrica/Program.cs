using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_Geometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Valor: ");
            string input1 = Console.ReadLine();
            double valor1 = double.Parse(input1);

            Console.WriteLine("Digite o Segundo Valor: ");
            string input2 = Console.ReadLine();
            double valor2 = double.Parse(input2);   

            double Mediageometrica = Math.Sqrt(valor1 * valor2);    

            Console.WriteLine("A Média Geométrica é: "  + Mediageometrica);

            





        }
    }
}
