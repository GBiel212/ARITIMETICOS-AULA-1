using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Valor da Aresta do Quadrado");
            Double valorAresta = Double.Parse(Console.ReadLine());

           Console.WriteLine(valorAresta
                + " é o valor da Aresta do Quadrado");
           // Console.WriteLine("O Perímetro do Quadrado é: " + (valorAresta * 4));
           //
           Console.WriteLine("A Área do Quadrado é: " + (valorAresta * valorAresta));      
                


        }
    }
}
