using CSharp_OO.Exceptions;

namespace CSharp_OO.Models.Comptes;

public class Epargne : Compte
{
    public DateTime DateDernierRetrait { get; private set; }

    public Epargne(string numero, Personne titulaire, DateTime dateDernierRetrait) : base(numero, titulaire)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public Epargne(string numero, Personne titulaire, double solde, DateTime dateDernierRetrait) : base(numero, titulaire, solde)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public override void Retrait(double montant)
    {
        if (Solde - montant <= 0)
        {
            throw new SoldeInsuffisantException(GetType().Name, "Le montant n'est pas disponible");
        }
        base.Retrait(montant);
        DateDernierRetrait = DateTime.Now;
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}