using Logique;

internal class CollectionWhile : ICommand
{
    public string Name => "Collection while";

    public void Execute()
    {
        int nb = 5;
        int compteurNombrePremier = 1;
        int compteurDiviseur = 0;
        int limite = 0;
        List<int> listeNbPremier = new List<int>();
        double racine = 0.0;


        listeNbPremier.Add(2);
        listeNbPremier.Add(3);

        Console.Write("Entre un nombre : ");
        limite = int.Parse(Console.ReadLine());


        while (nb < limite)
        {
            racine = Math.Pow(nb, 0.5);
            compteurDiviseur = 1;
            while (listeNbPremier[compteurDiviseur] <= racine && nb % listeNbPremier[compteurDiviseur] != 0)
            {
                compteurDiviseur++;
            }
            if (nb % listeNbPremier[compteurDiviseur] != 0)
            {
                listeNbPremier.Add(nb);
            }
            nb += 2;
        }
        foreach (int c in listeNbPremier)
        {
            Console.Write(c+" / ");
        }
    }
}