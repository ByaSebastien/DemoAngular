namespace ConceptTest.Models.Interface
{
    internal interface IPersonne
    {
        string Nom { get; }
        string Prenom { get; }
        public Status Statu { get; set; }
        public Etats Etat { get; set; }
    }
}