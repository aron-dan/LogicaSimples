using System;

namespace ValorDasVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //<tipo><nome> = <valor>
            int resultado, n1, n2;

            /*tipos basicos
             byte 0..255
             sbyte -128..127
            */

            //operadires aritmeticos
            byte n = 255;
            sbyte sb = -128;
            short sh = -32768;
            n1 = 2;
            n2 = 3;

            resultado = n1 + n2;

            //namespace.classe.metodo
            Console.WriteLine("byte min: {0}, max: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte min: {0}, max: {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("short min: {0}, max: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort min: {0}, max: {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int min: {0}, max: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint min: {0}, max: {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long min: {0}, max: {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong min: {0}, max: {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------Com Ponto Flutuante-------------------");

            Console.WriteLine("Float min: {0}, max: {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double min: {0}, max: {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Deciaml min: {0}, max: {1}", decimal.MinValue, decimal.MaxValue);

            char genero = 'M';

            // string
            string nome = "Daniel";
            System.String sobrenome = "Aron";

            // nomeclatura
            int salario;
            int salarioDoFuncionario;

            System.Console.WriteLine(nome + " " + sobrenome);

            Console.ReadKey();
        }
    }
}
