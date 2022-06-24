using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class NombrePremier : ICommand
    {
        public string Name => "Nombres premiers";

        public void Execute()
        {
            int nb = 3;
            int compteurNombrePremier = 1;
            int compteurDiviseur=0;
            int [] tableauNombrePremier = new int[100];
            double racine = 0.0;

            tableauNombrePremier[0] = 3;

            Console.WriteLine("2");
            Console.WriteLine("3");

            while (compteurNombrePremier < 100)
            {
                racine = Math.Pow(nb, 0.5);
                compteurDiviseur = 0;
                nb += 2;
                while (tableauNombrePremier[compteurDiviseur]<=racine && nb%tableauNombrePremier[compteurDiviseur] != 0)
                {
                    compteurDiviseur++;
                }
                if(nb % tableauNombrePremier[compteurDiviseur] != 0)
                {
                    Console.WriteLine(nb);
                    tableauNombrePremier[compteurNombrePremier] = nb;
                    compteurNombrePremier++;
                }
            }
            foreach(int c in tableauNombrePremier)
            {
                Console.Write(c);
            }
        }
    }
}
