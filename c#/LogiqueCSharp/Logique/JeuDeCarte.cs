using Logique;

internal class JeuDeCarte : ICommand
{
    public string Name => "Jeu de carte";

    public void Execute()
    {
        Carte[] jeu = new Carte[52];
        int i = 0;

        foreach(string color in Enum.GetNames(typeof(CouleursCartes)))
        {
            CouleursCartes colorCarte = Enum.Parse<CouleursCartes>(color);
            foreach (string value in Enum.GetNames(typeof(ValeursCartes)))
            {
                ValeursCartes valeursCartes = Enum.Parse<ValeursCartes>(value);
                jeu[i].couleur = colorCarte;
                jeu[i].valeur = valeursCartes;
                i++;
            }
        }

        foreach (Carte carte in jeu)
        {
            Console.WriteLine($"{carte.valeur} de {carte.couleur}");
        }
    }
    public enum CouleursCartes { Coeur,Carreau,Pique,Trefle}
    public enum ValeursCartes { As=14,deux=2,trois=3,quatre=4,cinq=5,six=6,sept=7,huit=8,neuf=9,dix=10,valet=11,damme=12,roi=13}
    public struct Carte
    {
        public CouleursCartes couleur;
        public ValeursCartes valeur;
    }
}