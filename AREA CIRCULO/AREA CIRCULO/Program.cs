using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_CIRCULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Diametro do Circulo: ");
            double diametro = Convert.ToDouble(Console.ReadLine());
            double raio = diametro / 2;
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("A area do circulo é: " + area);

            Console.Write(" Obrigado! ");
            Console.WriteLine(" Pressione qualquer tecla para sair... ");
            Console.ReadKey();  



        }



        
    }
}
