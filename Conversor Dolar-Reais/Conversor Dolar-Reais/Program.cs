using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Dolar_Reais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em Dolar: "); 
            double valorDolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a cotação do Dolar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("O valor em Reais é: " + (valorDolar * cotacaoDolar));

            Console.WriteLine("Obrigado por usar o conversor de Dolar para Reais, volte sempre!");








        }



    }
}
