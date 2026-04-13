using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Valor do primeiro produto: "); 
            
            double produto1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o Valor do segundo produto: ");

            double produto2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Valor do terceiro produto: "    );

            double produto3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Valor do quarto produto: ");
            double produto4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Valor do quinto produto: ");

            double produto5 = Convert.ToDouble(Console.ReadLine());

            double total = produto1 + produto2 + produto3 + produto4 + produto5;

            Console.WriteLine("O valor total da compra é: " + total);

            Console.WriteLine("Digite o Valor do Pagamento para calcular o valor de troco ao cliente: ");
            double pagamento = Convert.ToDouble(Console.ReadLine());

            

           double troco = pagamento - total;
            Console.WriteLine("O valor do troco é: " + troco);

            Console.WriteLine("Obrigado pela preferência de caixa, volte sempre!");




















        }
    }
}
