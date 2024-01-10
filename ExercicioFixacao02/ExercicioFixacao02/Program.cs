using System;
using System.Globalization;

namespace exerciciofixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa:");
            string quartos = Console.ReadLine();
            Console.WriteLine("Entre com o preço de um produto:");
            string produtos = Console.ReadLine();
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");      
         
            string[] vet = Console.ReadLine().Split(' ');

            string nomel = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            

            Console.WriteLine(nomel);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));







        }
    }
}
