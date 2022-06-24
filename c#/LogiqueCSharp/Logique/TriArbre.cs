using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class TriArbre : ICommand
    {
        public string Name => "Tri en arbre";

        public void Execute()
        {
            Random random = new Random();
            int[] tableau = new int[300];

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = random.Next(100);
            }
            Methods.ShowArray(tableau);
            trier(tableau);
            Methods.ShowArray(tableau);
        }

        private void trier(int[] tableau)
        {
            int finTas = tableau.Length - 1;

            CreerTas(tableau, (tableau.Length / 2) - 1);
            while (finTas > 0)
            {
                RepartitionTas(tableau, 0, finTas);
                Inverser(tableau,0,finTas);
                finTas--;
            }

        }

        private void Inverser(int[] tableau, int pos1, int pos2)
        {
            int temp = tableau[pos1];

            tableau[pos1] = tableau[pos2];
            tableau[pos2] = temp;
        }

        private void RepartitionTas(int[] tableau, int posMax, int finTas)
        {
            {
                int pos1 = posMax;
                int pos2 = 0;

                if (pos1 * 2 + 1 > finTas)
                {
                }
                else if (pos1 * 2 + 1 == finTas)
                {
                    if (tableau[pos1 * 2 + 1] > tableau[pos1])
                    {
                        pos2 = pos1 * 2 + 1;
                        Inverser(tableau, pos1, pos2);
                        RepartitionTas(tableau, pos2, finTas);
                    }
                }
                else
                {
                    if (tableau[pos1 * 2 + 1] > tableau[pos1 * 2 + 2])
                    {
                        pos2 = pos1 * 2 + 1;
                    }
                    else
                    {
                        pos2 = pos1 * 2 + 2;
                    }
                    if (tableau[pos1] < tableau[pos2])
                    {
                        Inverser(tableau, pos1, pos2);
                        RepartitionTas(tableau, pos2, finTas);
                    }
                }
            }
        }

        private void CreerTas(int[] tableau, int posDepart)
        {
                for (int i = posDepart; i >= 0; i--)
            {
                RepartitionTas(tableau, i, tableau.Length - 1);
            }
        }
    }
}
