
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //declaração de variaveis

            double comprimento, largura, valorDom2, valorDoTerreno, area;

            //entrada de dados

            Console.WriteLine("Digite o comprimeto do Terreno em metros:");
            comprimento = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a largura do Terreno em metros:");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do metro quadrado:");
            valorDom2 = double.Parse(Console.ReadLine());

            //processamento

            area = largura * comprimento;
            valorDoTerreno = valorDom2 * area;

            //saida

            Console.WriteLine("Área do terreno = " + area.ToString("F2") + "m2");
            Console.WriteLine("Preço do terreno = " + valorDoTerreno.ToString("F2") + "R$");
            Console.ReadKey();
        }
    }
}
