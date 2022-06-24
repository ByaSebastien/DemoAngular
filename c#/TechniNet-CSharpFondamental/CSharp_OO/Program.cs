using CSharp_OO.Exceptions;
using CSharp_OO.Models;
using CSharp_OO.Models.Comptes;

namespace CSharp_OO;

public class Program
{
    public static void Main(params string[] Args)
    {
        Banque banque = new Banque();
        banque.Nom = "PicsouBank";

        string action;
        do
        {
            Console.WriteLine("Actions: ");
            Console.WriteLine("1. Créer un compte");
            Console.WriteLine("2. Selectionner un compte");
            Console.WriteLine("3. Avoir des comptes");
            Console.WriteLine("q. Quitter");
            action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    CreateAction(banque);
                    break;
                case "2":
                    Compte compte = SelectAction(banque);
                    Console.WriteLine($"Actions sur le compte: {compte.Numero}");
                    Console.WriteLine("1. Depot");
                    Console.WriteLine("2. Retrait");
                    Console.WriteLine("3. Solde");
                    Console.WriteLine("q. Quitter");

                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1": SelectDepotAction(compte); break;
                        case "2": SelectRetraitAction(compte); break;
                        case "3": Console.WriteLine(compte.Solde); break;
                    }
                    break;
                case "3":
                    Console.Write("Entrer le nom et le prenom séparer par un espace");
                    string nomPrenom = Console.ReadLine();
                    string[] args = nomPrenom.Split(" ");
                    
                    Personne titulaire = new Personne(args[0], args[1]);
                    
                    AvoirDesComptes(banque, titulaire);
                    break;
            }
        } while (action != "q");

    }

    public static void SelectRetraitAction(Compte courant)
    {
        Console.WriteLine("Entrer le montant à retirer");
        string montant = Console.ReadLine();

        try
        {
            courant.Retrait(double.Parse(montant));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void SelectDepotAction(Compte courant)
    {
        Console.WriteLine("Entrer le montant à déposer");
        string montant = Console.ReadLine();

        try
        {
            courant.Depot(double.Parse(montant));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void CreateAction(Banque banque)
    {
        Console.Write("Numero de compte: ");
        string numero = Console.ReadLine();
        Console.Write("Le nom du titulaire: ");
        string titulaireNom = Console.ReadLine();
        Console.Write("Le prenom du titulaire: ");
        string titulairePrenom = Console.ReadLine();
        Compte compte;

        Console.Write("Le type (1: Courant, 2: Epargne): ");
        
        Personne titulaire = new Personne(titulaireNom, titulairePrenom);
        string type = Console.ReadLine();
        switch (type)
        {
            case "1":
                Console.Write("Ligne de credit > 0: ");
                string ligneDeCredit = Console.ReadLine();
                try
                {
                    compte = new Courant(numero, titulaire, double.Parse(ligneDeCredit));
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    compte = new Courant(numero, titulaire, 0);
                }
                break;
            case "2":
                compte = new Epargne(numero, titulaire, DateTime.Now);
                break;
            default:
                compte = new Epargne(numero, titulaire, DateTime.Now);
                break;
        }

        banque.Ajouter(compte);
    }

    public static Compte SelectAction(Banque banque)
    {
        Console.Write("Entrez le numero de compte: ");
        string numero = Console.ReadLine();

        return banque[numero];
    }

    public static void AvoirDesComptes(Banque banque, Personne titulaire)
    {
        double avoir = banque.AvoirDesComptes(titulaire);
        Console.WriteLine($"L'avoir des comptes de Mr. {titulaire.Nom} est de {avoir}");
    }
}



