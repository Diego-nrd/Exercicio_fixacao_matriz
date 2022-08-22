using System;

namespace Exercicio_fixacao_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two whole numbers: ");
            string[] value = Console.ReadLine().Split(' ');

            int n = int.Parse(value[0]);
            int m = int.Parse(value[1]);

            int[,] mat = new int[n, m];

            Console.WriteLine("Enter 4 whole number {0} times", n);
            for (int i = 0; i < n; i++)
            {
                value = Console.ReadLine().Split(' ');
                for (int j = 0; j <= n; j++)
                {
                    mat[i, j] = int.Parse(value[j]);
                }
            }

            Console.Write("Enter a number that exist in array: ");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (mat[i, j] == search)
                    {
                        Console.WriteLine("Position {0},{1}:", i, j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);

                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i,j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down " + mat[i + 1, j]);
                        }
                       
                    }
                }
            }
        }
    }
}
