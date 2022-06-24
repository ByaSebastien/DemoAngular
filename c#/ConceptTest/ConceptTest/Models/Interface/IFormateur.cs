using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptTest.Models.Interface
{
    internal interface IFormateur : IPersonne
    {
        void RaiseDonnerExercice(List<Exercice> exercices, List<IStagiaire> stagiaires);
        void RaiseDonnerPause(List<IStagiaire> stagiaires);
    }
}
