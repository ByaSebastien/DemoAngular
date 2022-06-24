using ConceptTest.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConceptTest.Models
{
    enum Status { Formateur, Stagiaire }
    enum Etats { en_cour, en_pause, fait_exercice }
    internal class Personne : IPersonne, IFormateur, IStagiaire
    {
        public event Action<List<Exercice>, Personne, List<IStagiaire>> DonnerExerciceEvent;
        public event Action<Personne, List<IStagiaire>> DonnerPauseEvent;
        public event Action<Exercice, Personne> FaireExerciceEvent;
        public event Action<Personne> RalerEvent;
        private string _Nom;
        private string _Prenom;
        public string Nom
        {
            get { return _Nom; }
            set
            {
                string strRegex = @"^[A-Z][a-z]*$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(value))
                {
                    _Nom = value;
                }
                else
                {
                    throw new FormatException("Format non valide");
                }
            }
        }
        public string Prenom
        {
            get { return _Prenom; }
            set
            {
                string strRegex = @"^[A-Z][a-zA-Z\-]*$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(value))
                {
                    _Prenom = value;
                }
                else
                {
                    throw new FormatException("Format non valide");
                }
            }
        }
        public Status Statu { get; set; }
        public Etats Etat { get; set; }
        public Personne(string nom,Status statu)
        {
            Statu = statu;
            _Nom = nom;
        }
        public void RaiseDonnerExercice(List<Exercice> exercices, List<IStagiaire> stagiaires)
        {
            DonnerExerciceEvent?.Invoke(exercices, this, stagiaires);
        }
        public void RaiseDonnerPause(List<IStagiaire> stagiaires)
        {
            DonnerPauseEvent?.Invoke(this, stagiaires);
        }
        public void RaiseFaireExercice(Exercice exercice)
        {
            FaireExerciceEvent?.Invoke(exercice, this);
        }
        public void RaiseRaler()
        {
            RalerEvent?.Invoke(this);
        }
    }
}
