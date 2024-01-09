using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            /* Diferença de Writeline(faz quebra de linha no final) e Write */
            Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            /* Colocando ponto de separador */
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------------------------------------");
            /*Técnica do placehouder */
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            /*Interpolação */
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            /* Concaternação de dados */
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");



        }
    }
}