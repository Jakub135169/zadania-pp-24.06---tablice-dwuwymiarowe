using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_dwuwymiarowa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1:");
            int[,] array1 = FillArrayAscendingDescending(10);
            PrintArray(array1);

            Console.WriteLine("\nZadanie 2:");
            int[,] array2 = FillArraySpiral(10);
            PrintArray(array2);

            Console.WriteLine("\nZadanie 3:");
            int size;
            do
            {
                Console.Write("Podaj rozmiar tablicy: ");
            } while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);

            int[,] array3 = FillArrayAscendingDescending(size);
            PrintArray(array3);
        }

        static int[,] FillArrayAscendingDescending(int size)
        {
            int[,] array = new int[size, size];

            int num = 1;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        array[i, j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        array[i, j] = num;
                        num++;
                    }
                }
            }

            return array;
        }

        static int[,] FillArraySpiral(int size)
        {
            int[,] array = new int[size, size];

            int num = 1;
            int rowStart = 0;
            int rowEnd = size - 1;
            int colStart = 0;
            int colEnd = size - 1;

            while (num <= size * size)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    array[rowStart, i] = num;
                    num++;
                }

                for (int i = rowStart + 1; i <= rowEnd; i++)
                {
                    array[i, colEnd] = num;
                    num++;
                }

                for (int i = colEnd - 1; i >= colStart; i--)
                {
                    array[rowEnd, i] = num;
                    num++;
                }

                for (int i = rowEnd - 1; i > rowStart; i--)
                {
                    array[i, colStart] = num;
                    num++;
                }

                rowStart++;
                rowEnd--;
                colStart++;
                colEnd--;
            }

            return array;
        }

        static void PrintArray(int[,] array)
        {
            int size = array.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}