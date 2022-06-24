using CSharp_OO.Delegates;

namespace CSharp_OO.Models;

public abstract class Compte: IBanker, ICustomer
{
    public event Action<Compte> PassageEnNegatifEvent;
    // protected double _LigneDeCredit = 0;
    public string Numero { get; private set; }
    public double Solde { get; private set; } = 0;
    public Personne Titulaire { get; private set; }

    // public virtual double LigneDeCredit => 0;
    // public virtual double LigneDeCredit
    // {
    //     get => _LigneDeCredit;
    //     set => _L;
    // }
    // // {
    //     // get => 0;
    // // }

    protected Compte(string numero, Personne titulaire): this(numero, titulaire, 0)
    {
    }

    protected Compte(string numero, Personne titulaire, double solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }
    
    public virtual void Retrait(double montant)
    {
        if (montant <= 0 /*&& Solde - montant <= LigneDeCredit*/)
        {
            throw new ArgumentOutOfRangeException("Le montant doit être positif");
        }

        Solde -= montant;
    }

    public void Depot(double montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentOutOfRangeException("Le montant doit être positif");
        }

        Solde += montant;
    }

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }

    public static double operator +(Compte c1, Compte c2)
    {
        return (c1.Solde > 0 ? c1.Solde : 0) +
               (c2.Solde > 0 ? c2.Solde : 0);
    }

    public static double operator +(double d, Compte c)
    {
        return d + c.Solde > 0 ? c.Solde : 0;
    }

    protected void RaisePassageEnNegatif()
    {
        PassageEnNegatifEvent?.Invoke(this);
    }
}