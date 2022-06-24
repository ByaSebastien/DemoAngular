namespace CSharp_OO.Models;

public class Personne
{
    public string Nom { get; private set; }
    public string Prenom { get; private set; }
    public DateTime DateNaiss { get; private set; }

    public Personne(string nom, string prenom): this(nom, prenom, DateTime.Now)
    {
    }

    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        Nom = nom;
        Prenom = prenom;
        DateNaiss = dateNaiss;
    }

    public static bool operator ==(Personne? p1, Personne? p2)
    {
        if (p1 is null) return false;
        if (p2 is null) return false;

        if (p1.Nom != p2.Nom) return false;
        if (p1.Prenom != p2.Prenom) return false;

        return true;
    }

    public static bool operator !=(Personne? p1, Personne? p2)
    {
        return !(p1 == p2);
    }
}