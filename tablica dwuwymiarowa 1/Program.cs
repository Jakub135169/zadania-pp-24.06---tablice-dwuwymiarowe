using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_dwuwymiarowa_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tablica[i, j] = 10 * i + j + 1;
                    }
                }
                else
                {
                    for (int j = 9; j >= 0; j--)
                    {
                        tablica[i, j] = 10 * i + 10 - j;
                    }
                }
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
