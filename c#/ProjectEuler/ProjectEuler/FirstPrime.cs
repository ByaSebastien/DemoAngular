using ProjectEuler;

internal class FirstPrime : ICommand
{
    public string Name => "10001st prime";

    public void execute()
    {
        int nb = 3;
        int compteurNombrePremier = 2;
        int compteurDiviseur = 0;
        int[] tableauNombrePremier = new int[1000001];
        double racine = 0.0;

        tableauNombrePremier[0] = 2;
        tableauNombrePremier[1] = 3;

        Console.WriteLine("2");
        Console.WriteLine("3");

        while (compteurNombrePremier < 1000001)
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
                compteurNombrePremier++;
            }
        }
        Console.WriteLine(tableauNombrePremier[1000000]);
    }
}