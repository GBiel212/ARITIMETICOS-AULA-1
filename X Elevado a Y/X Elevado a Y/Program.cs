using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Elevado_a_Y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X:"   );
            
            Double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y:");
           
            Double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O resultado de X elevado a Y é: " + Math.Pow(x, y));

            Console.WriteLine("Obrigado!!  , pressione qualquer tecla para sair.");
            Console.ReadKey();










        }
    }
}
