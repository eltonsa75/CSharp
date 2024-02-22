
using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("ELton");
            list.Add("Amanda");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            //Predicado 

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int post1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + post1);

            int post2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + post2);
           

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("=============================");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
        }

        

    }
}