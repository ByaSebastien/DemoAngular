using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptTest.Models
{
    internal class Exercice
    {
        public int NumeroEx { get; set; }
        public string NomEx { get; set; }
        public Exercice(int num,string nom)
        {
            NumeroEx = num;
            NomEx = nom;
        }
    }
}
