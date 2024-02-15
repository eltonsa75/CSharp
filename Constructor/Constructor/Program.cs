using Constructor;
using System;
using System.Globalization;

namespace Contructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome ="T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);




        }
    }
}