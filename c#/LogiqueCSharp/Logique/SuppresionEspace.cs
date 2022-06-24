using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class SuppresionEspace : ICommand
    {
        public string Name => "Suppression des espaces";

        public void Execute()
        {
            int lecture = 0;
            int ecriture = 0;
            char[] texte = "suppression  des espaces ".ToCharArray();
            int taille = texte.Length;

            for (lecture = 0; lecture < taille; lecture++) 
            {
                if (texte[lecture] != ' ')
                {
                    texte[ecriture] = texte[lecture];
                    ecriture++;
                }
            }
            for (lecture=ecriture; lecture < taille; lecture++)
            {
                texte[lecture] = ' ';
            }
            foreach (char c in texte)
            {
                Console.Write(c);
            }
        }
    }
}
