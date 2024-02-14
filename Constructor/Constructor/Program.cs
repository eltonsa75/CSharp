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

            p.SetNome("TV 4k");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco);
            Console.WriteLine(p.GetQuantidade);




        }
    }
}