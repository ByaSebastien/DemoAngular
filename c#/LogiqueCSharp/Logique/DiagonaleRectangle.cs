using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class DiagonaleRectangle : ICommand
    {
        public string Name => "Diagonale d'un rectangle";

        public void Execute()
        {
            const int LONGUEUR = 5;
            const int LARGEUR = 11;
            int[,] array = new int[LARGEUR, LONGUEUR];

            array = Diagonale(array);
            ShowArray(array);
        }

        private int[,] Diagonale(int[,] array)
        {
            int longueur = array.GetLength(1);
            int largeur = array.GetLength(0);
            double multiplicateur = 0; 
            double position=0;
            bool reverse = false;

            if (longueur < largeur)
            {
                Methods.Reverse(ref longueur, ref largeur);
                reverse = true;
            }
            multiplicateur = (double)largeur / (double)longueur;
            for (int col = 0; col < longueur; col++)
            {
                position = (double)(col + 0.5) * multiplicateur;
                if (!reverse)
                {
                    array[(int)position, col] = 1;
                }
                else
                {
                    array[col,(int)position] = 1;
                }
            }
            return array;
        }
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
                    if (array[i, j] == 0)
                    {
                        Console.Write("     |");
                    }
                    else
                    {
                        Console.Write("  " + array[i, j] + "  |");
                    }
                }
                Console.WriteLine();
                for (int p = 0; p < array.GetLength(1); p++)
                {
                    Console.Write("------");
                }
                Console.WriteLine();
            }
        }
    }
}
