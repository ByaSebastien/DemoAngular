using Logique;
using System.Text.RegularExpressions;

internal class VerifCompteBBAN : ICommand
{
    public string Name => "Verification de compte BBAN / IBAN";

    public void Execute()
    {
        string bban = "";

        bban = AjouterBBAN(bban);
        bban = bban.Replace("-", null);
        TestValidite(bban);
    }
    private static string AjouterBBAN(string bban)
    {
        bool valide = false;
        while (!valide)
        {
            Console.Write("Entrez vore compte BBAN : ");
            bban = Console.ReadLine();
            valide = valideBBAN(bban);
            if (!valide)
            {
                Console.WriteLine("BBAN non valide");
                Console.ReadKey();
            }
        }
        return bban;
    }
    private static bool valideBBAN(string? bban)
    {
        string strRegex = @"(\d{3})-(\d{7})-(\d{2})";

        Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

        return re.IsMatch(bban);
    }
    private static void TestValidite(string bban)
    {
        long nombreTest = 0;
        int nombreRef = 0;

        nombreTest = long.Parse(bban.Substring(0, 10));
        nombreRef = int.Parse(bban.Substring(10, 2));
        if (nombreTest % 97 == nombreRef || nombreTest % 97 == 0 && nombreRef == 97)
            Console.WriteLine("BBAN valide");
        else
            Console.WriteLine("BBAN non valide");
    }

}