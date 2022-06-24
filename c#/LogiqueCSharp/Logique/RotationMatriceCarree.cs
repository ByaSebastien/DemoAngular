using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class RotationMatriceCarree : ICommand
    {
        public string Name => "Rotation de matrice carrée";

        public void Execute()
        {
            const int SIZE = 5;
            int [,]array = new int[SIZE,SIZE];

            Methods.FillArray(array);
            Methods.ShowArray(array);
            array = Rotation(array);
            Methods.ShowArray(array);
        }

        private static int[,] Rotation(int[,] array)
        {
            int temp = 0;
            int size = array.GetLength(0);

            for (int x = 0; x < size - x ; x++)
            {
                for (int y = 0; y < size / 2 ; y++)
                {
                    temp = array[x,y];
                    array[x,y] = array[(size - 1) - y,x];
                    array[(size - 1) - y,x] = array[(size - 1) - x,(size - 1) - y];
                    array[(size - 1) - x,(size - 1) - y] = array[y,(size - 1) - x];
                    array[y,(size - 1) - x] = temp;
                }
            }
            return array;
        }
    }
}
