using Delegue.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegue.Models
{
    internal class Carwash
    {
        private void Preparer(Voiture voiture)
        {
            Console.WriteLine($"Je prépare la voiture : {voiture.Plaque}");
        }
        private void Laver(Voiture voiture)
        {
            Console.WriteLine($"Je lave la voiture : {voiture.Plaque}");
        }
        private void Secher(Voiture voiture)
        {
            Console.WriteLine($"Je seche la voiture : {voiture.Plaque}");
        }
        private void Finaliser(Voiture voiture)
        {
            Console.WriteLine($"Je finalise la voiture : {voiture.Plaque}");
        }
        public void Traiter(Voiture voiture)
        {
            MyDelegate mydelegate = Preparer;
            mydelegate += Laver;
            mydelegate += Secher;
            mydelegate += Finaliser;

            mydelegate?.Invoke(voiture);
        }
    }
}
