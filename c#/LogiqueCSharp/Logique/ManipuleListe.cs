using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class ManipuleListe : ICommand
    {
        public string Name => "Manipulation d'une liste";

        public void Execute()
        {
            Liste l = null;
            affiche(l);
            l = add(l, "toto");
            affiche(l);
            l = add(l, "Dédé");
            affiche(l);
            l = add(l, "Lucas");
            l = add(l, "Mathias");
            affiche(l);
            l = remove(l, 1);
            affiche(l);
            l = insert(l, 0, "Alphonse");
            l = insert(l, 2, "Gilbert");
            l = insert(l, longueur(l), "James");
            affiche(l);
        }

        private void affiche(Liste l)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("La liste contient {0} élément", longueur(l));
            for (int i = 0; i < longueur(l); i++)
            {
                Console.WriteLine("La liste contient {0} est\"{1}\"", i + 1, Get(l, i));
            }
        }

        private Liste insert(Liste l, int i, string value)
        {
            Liste temp = l;
            Liste ajout = new Liste();

            ajout.value = value;

            if (i == 0)
            {
                ajout.suivant = l;
                l = ajout;
            }
            else
            {
                for (int j = 0; j < i - 1; j++)
                {
                    temp = temp.suivant;
                }
                ajout.suivant = temp.suivant;
                temp.suivant = ajout;
            }
            return l;
        }

        private Liste remove(Liste l, int i)
        {
            Liste temp = l;
            for (int j = 0; j < i - 1; j++)
            {
                temp = temp.suivant;
            }
            temp.suivant = temp.suivant.suivant;
            return l;
        }

        private string Get(Liste l, int i)
        {
            int j = 0;
            string result = "";

            for (j = 0; j < i && l != null; j++)
            {
                l = l.suivant;
            }
            result = l.value;

            return result;
        }

        private Liste add(Liste? l, string value)
        {

            Liste temp;
            Liste ajout = new Liste();

            ajout.value = value;
            if (l is null)
            {
                l = ajout;
            }
            else
            {
                temp = l;
                while (temp.suivant != null)
                {
                    temp = temp.suivant;
                }
                temp.suivant = ajout;
            }
            return l;
        }

        private int longueur(Liste? l)
        {
            Liste temp = l;
            int counter = 0;

            while (temp != null)
            {
                temp = temp.suivant;
                counter++;
            }
            return counter;
        }
    }
    internal class Liste
    {
        public string value;
        public Liste suivant;
    }
}
