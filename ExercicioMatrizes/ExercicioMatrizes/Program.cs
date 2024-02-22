using System;
using System.Collections.Specialized;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal");

            for (int a = 0; a < mat.GetLength(0); a++) Console.Write(mat[a, a] + " ");

            Console.WriteLine("");



            int valorNeg = 0;

            foreach (int a in mat) if (a < 0) valorNeg++;
            Console.WriteLine("Qtde Negativos = " + valorNeg);
        }
    }
}