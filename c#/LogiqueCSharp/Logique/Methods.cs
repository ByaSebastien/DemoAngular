using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class Methods
    {
        public static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write("------");
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write('|');
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4} |",array[i,j]);
                }
                Console.WriteLine();
                for (int p = 0; p < array.GetLength(1); p++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();
            }
        }
        public static void ShowArray(int[] array)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|{0,4} |", array[i]);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------------");
                }
            }
        }
        public static void FillArray(int[,] array)
        {
            int counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = counter++;
                }
            }
        }
        public static void Reverse(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
