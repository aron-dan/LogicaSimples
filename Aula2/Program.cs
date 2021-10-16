using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //declaracao das variaveis
            string nome;
            int quartos;
            double preco;

            //entrada de dados
            //tipo 1
            //<tipo>.<Parse>(Console.ReadLine());
            

            Console.WriteLine("Entre com seu noem completo.");
            nome = (Console.ReadLine());

            Console.WriteLine("Quantos quartos tem na casa");
            quartos = int.Parse(Console.ReadLine());
                              
            Console.WriteLine("Digite o preço do produto");
            preco = double.Parse(Console.ReadLine());


            //processamento
            
            //saida de dados
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome = " + nome);                                
            Console.WriteLine("n quartos = " + quartos);
            Console.WriteLine($"Preço do produto = {preco.ToString("F2")}");
            Console.ReadKey();

        }
    }
}
