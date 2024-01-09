﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:" + produto1 + ", cujo preço é $" + preco1.ToString("F2") + " " + produto2 + ", cujo preço é $" + preco2.ToString("F2"));
            Console.WriteLine("====================================");
            Console.WriteLine("Registro:" + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("=====================================");
            Console.WriteLine("Medida com oito casas decimais:" + medida + " Arredondado (três casas decimais):" + medida.ToString("F3") + " Separador decimal invarinat culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));
            





        }
    }
}