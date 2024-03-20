using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioPolimorfismo.Entities;


namespace ExercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.WriteLine("enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerhours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y') 
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerhours, additionalCharge));
                }

            }
        }
    }
}
