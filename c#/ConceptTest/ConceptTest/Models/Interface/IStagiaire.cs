using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptTest.Models.Interface
{
    internal interface IStagiaire: IPersonne
    {
        void RaiseRaler();
        void RaiseFaireExercice(Exercice exercice);
    }
}
