namespace CSharp_OO.Models;

public class Banque
{
    public string Nom { get; set; }
    private Dictionary<string, Compte> _Comptes = new Dictionary<string, Compte>();

    public KeyValuePair<string, Compte>[] Comptes
    {
        get
        {
            return _Comptes.ToArray();
        }
    }

    public Compte this[string numero]
    {
        get
        {
            Compte compte;
            _Comptes.TryGetValue(numero, out compte);
            return compte;
        }
    }

    public Compte[] this[Personne titulaire]
    {
        get
        {
            List<Compte> comptes = new List<Compte>();

            foreach (Compte compte in _Comptes.Values)
            {
                if (compte.Titulaire == titulaire)
                {
                    comptes.Add(compte);
                }
            }

            return comptes.ToArray();
        }
    }

    public void Ajouter(Compte compte)
    {
        if (_Comptes.ContainsKey(compte.Numero))
        {
            return;
        }

        compte.PassageEnNegatifEvent += PassageEnNegatifAction;
        _Comptes.Add(compte.Numero, compte);
    }

    public void Supprimer(string numero)
    {
        if (!_Comptes.ContainsKey(numero))
        {
            return;
        }
        _Comptes.Remove(numero);
    }

    public void Supprimer(Compte compte)
    {
        Supprimer(compte.Numero);
    }

    public double AvoirDesComptes(Personne titulaire)
    {
        double total = 0;
        // foreach (KeyValuePair<string, Courant> kvp in _Comptes)
        // {
        //     if (kvp.Value.Titulaire == titulaire)
        //     {
        //         total += kvp.Value;
        //     }
        //     
        // }
        Compte[] courants = this[titulaire];
        foreach (Compte courant in courants)
        {
            total += courant;
        }
        return total;
    }

    public void AppliquerInteret()
    {
        foreach (Compte compte in _Comptes.Values)
        {
            compte.AppliquerInteret();
        }
    }
    private void PassageEnNegatifAction(Compte c)
    {
        Console.WriteLine($"Le compte numero {c.Numero} est passé en négatif");
    }
}