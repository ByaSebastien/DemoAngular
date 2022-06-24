using ProjectEuler;

internal class SummationOfPrimes : ICommand
{
    public string Name => "Summation of primes";

    public void execute()
    {
        int nb = 3;
        int compteurNombrePremier = 2;
        int compteurDiviseur = 0;
        long somme = 5;
        int[] tableauNombrePremier = new int[1000000];
        double racine = 0.0;

        tableauNombrePremier[0] = 2;
        tableauNombrePremier[1] = 3;

        while (nb < 2000000)
        {
            racine = Math.Pow(nb, 0.5);
            compteurDiviseur = 0;
            nb += 2;
            while (tableauNombrePremier[compteurDiviseur] <= racine && nb % tableauNombrePremier[compteurDiviseur] != 0)
            {
                compteurDiviseur++;
            }
            if (nb % tableauNombrePremier[compteurDiviseur] != 0)
            {
                tableauNombrePremier[compteurNombrePremier] = nb;
                somme += nb;
                compteurNombrePremier++;
            }
        }
        Console.WriteLine(somme);
    }
}