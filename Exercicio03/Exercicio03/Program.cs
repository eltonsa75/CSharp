using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
           Retangulo Ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + Ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}