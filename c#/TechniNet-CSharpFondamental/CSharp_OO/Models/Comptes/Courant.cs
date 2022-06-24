using CSharp_OO.Exceptions;

namespace CSharp_OO.Models.Comptes;

public class Courant: Compte
{
    private double _LigneDeCredit;
    public /*override*/ double LigneDeCredit
    {
        get { return -_LigneDeCredit; }
        set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("La ligne de crédit doit être positive");
            }
            _LigneDeCredit = value;
        }
    }

    public Courant(string numero, Personne titulaire, double ligneDeCredit) : base(numero, titulaire)
    {
        LigneDeCredit = ligneDeCredit;
    }

    public Courant(string numero, Personne titulaire, double solde, double ligneDeCredit) : base(numero, titulaire, solde)
    {
        LigneDeCredit = ligneDeCredit;
    }

    /// <summary>
    /// Méthode permettant le retrait d'un montant positif d'un compte
    /// </summary>
    /// <param name="montant" type="double">montant > 0</param>
    /// <exception cref="SoldeInsuffisantException">Solde - montant lte 0</exception>
    /// <modify>this.Solde</modify>
    public override void Retrait(double montant)
    {
        if (Solde - montant < LigneDeCredit)
        {
            throw new SoldeInsuffisantException(GetType().Name, "Montant trop important");
        }

        double oldSolde = Solde;
        base.Retrait(montant);
        if (Solde < 0 && oldSolde >= 0)
        {
            RaisePassageEnNegatif();
        }
    }


    protected override double CalculInteret()
    {
        return Solde * (Solde > 0 ? 0.03 : 0.0975);
    }

}