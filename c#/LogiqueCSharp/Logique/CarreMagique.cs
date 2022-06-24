using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class CarreMagique : ICommand
    {
        public string Name => "Carré magique";

        public void Execute()
        {
            int [,] tab = new int[5,5];		

			FillArray(tab);
			VerifCarreMagique(tab);
		
		}


        public static void FillArray(int[,] array)
		{
			int counter = 0;

			for (int i = 0; i < array.GetLength(0) - 1; i++)
			{
				for (int j = 0; j < array.GetLength(1) - 1; j++)
				{
					array[i, j] = 5;
				}
			}
		}
		public static void VerifCarreMagique(int [,] tab)
        {
			int sommeRef = 0, somme = 0, somme2 = 0, j = 0;
			bool lev = true;

			for (int i = 0; i < tab.GetLength(0) - 1 && lev; i++)
			{
				for (j = 0; j < tab.GetLength(1) - 1 && lev; j++)
				{
					if (i == 0)
					{
						sommeRef = sommeRef + tab[i, j];
					}
					tab[i, tab.GetLength(0) - 1] = tab[i, tab.GetLength(0) - 1] + tab[i, j];
					tab[tab.GetLength(1) - 1, j] = tab[tab.GetLength(1) - 1, j] + tab[i, j];
				}
				if (tab[i, tab.GetLength(0) - 1] != sommeRef)
				{
					lev = false;
				}
			}
			if (tab[tab.GetLength(1) - 1, 0] != sommeRef || tab[tab.GetLength(1) - 1, 1] != sommeRef || tab[tab.GetLength(1) - 1, 2] != sommeRef || tab[tab.GetLength(1) - 1, 3] != sommeRef)
			{
				lev = false;
			}
			j = 0;
			for (int i = 0; i < tab.GetLength(0) - 1 && lev; i++)
			{
				somme = somme + tab[i, j];
				somme2 = somme2 + tab[tab.GetLength(1) - i - 2, j];
				j++;
			}
			if (sommeRef != somme || sommeRef != somme2)
			{
				lev = false;
			}
			tab[tab.GetLength(0) - 1, tab.GetLength(1) - 1] = somme;
			Methods.ShowArray(tab);
			if (lev)
			{
				Console.WriteLine("c'est un carré magique");
			}
			else
			{
				Console.WriteLine("ce n'est pas un carré magique");
			}
        }
	}
}
