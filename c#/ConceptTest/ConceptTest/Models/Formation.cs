using ConceptTest.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptTest.Models
{
    internal class Formation
    {
        public string Nom { get; set; }
        public Personne Formateur;
        public List<IStagiaire> Stagiaires = new List<IStagiaire>();
        public List<Exercice> Exercices = new List<Exercice>();
        public Formation(Personne formateur)
        {
            Formateur = formateur;
            Formateur.DonnerExerciceEvent += DonnerEx;
            Formateur.DonnerPauseEvent += DonnerPause;
        }
        public void Add(Personne p)
        {
            Stagiaires.Add(p);
            p.FaireExerciceEvent += FaireEx;
            p.RalerEvent += Raler;
        }
        public void Add(Exercice ex)
        {
            Exercices.Add(ex);
        }
        public void DonnerEx(List<Exercice>exercices, IFormateur formateur, List<IStagiaire> stagiaires)
        {
            Random random = new Random();
            int index = random.Next(stagiaires.Count);
            int indexEx= random.Next(exercices.Count);
            Console.WriteLine($"{formateur.Nom} demande à {stagiaires[index].Nom} de faire l'exercice {exercices[indexEx].NumeroEx} : {exercices[indexEx].NomEx}.");
            stagiaires[index].Etat = Etats.fait_exercice;
            stagiaires[index].RaiseFaireExercice(exercices[indexEx]);
            stagiaires[index].Etat = Etats.en_cour;
        }
        public void DonnerPause(IFormateur formateur, List<IStagiaire> stagiaires)
        {
            Random rand = new Random();
            int ralage;
            Console.WriteLine($"{formateur.Nom} accorde une pause aux élèves.");
            foreach (IStagiaire stagiaire in stagiaires)
            {
                stagiaire.Etat = Etats.en_pause;
            }
            foreach (IStagiaire stagiaire in stagiaires)
            {
                ralage = rand.Next(2);
                if (ralage == 1)
                    stagiaire.RaiseRaler();
                stagiaire.Etat = Etats.en_cour;
            }
        }
        public void Raler(IStagiaire stagiaire)
        {
            Console.WriteLine($"{stagiaire.Nom} reprend le cour en râlant.");
        }
        public void FaireEx(Exercice ex, IStagiaire stagiaire)
        {
            Random random = new Random();
            int reussite;
            Console.WriteLine($"{stagiaire.Nom} fais l'exercice {ex.NumeroEx} : {ex.NomEx}.");
            Console.WriteLine("...");
            reussite = random.Next(2);
            if (reussite == 0)
            {
                Console.WriteLine($"{stagiaire.Nom} à raté l'exercice.");
                stagiaire.RaiseRaler();
            }
            else
                Console.WriteLine($"{stagiaire.Nom} à réussi l'exercice.");
        }
    }
}
