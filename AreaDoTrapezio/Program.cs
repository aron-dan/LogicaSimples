using System;

namespace AreaDoTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracao das variaveis
            double baseMenor, baseMaior, altura, area;

            //entrada de dados
            //tipo 1
            //<tipo>.<Parse>(Console.ReadLine());


            Console.WriteLine("Qual o valor da Base Maior em milimetros?");
            baseMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da Base Menor em milimetros?");
            baseMenor = double.Parse(Console.ReadLine());

            if (baseMenor >= baseMaior)
                {
                    Console.WriteLine("A Base Menor não pode ser superior a Base Maior, Digite Base Menor novamente:");
                    baseMenor = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Qual o valor da Altura em milimetros?");
            altura = double.Parse(Console.ReadLine());


            //processamento
            area = ((baseMenor + baseMaior) / 2) * altura;

            //saida de dados
            
            Console.WriteLine("A área do trapézio é de " + area +"mm");
            Console.ReadKey();
        }
    }
}
