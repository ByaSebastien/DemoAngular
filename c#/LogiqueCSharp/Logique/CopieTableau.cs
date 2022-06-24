using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class CopieTableau : ICommand
    {
        public string Name => "Copie de tableau";

        public void Execute()
        {
            const int LIGNE = 3;
            const int COLONE = 4;
            int cpt = 1;
            int[,] tableau = new int[LIGNE, COLONE];
            int[] tab = new int[LIGNE * COLONE];

            for (int l = 0; l < LIGNE; l++)
            {
                for (int c = 0; c < COLONE; c++)
                {
                    tableau[l, c] = cpt++;
                    //Console.Write(tableau[l,c]+"   ");
                }
                //Console.WriteLine("");
            }
            for (int i = 0; i < COLONE*LIGNE; i++)
            {
                tab[i] = tableau[i/4,i%4];
                Console.Write(tab[i]+"   ");
            }
        }
    }
}
