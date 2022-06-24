namespace CSharp_OO.Models;

public interface IBanker: ICustomer
{
    string Numero { get; }
    Personne Titulaire { get; }
    void AppliquerInteret();
    // double LigneDeCredit { get; }
}