using Logique;


int choix = -1;
String entree = "";

ICommand[] exercices = new ICommand[]
{
    new SuppresionEspace(),
    new CompteurDigital(),
    new NombrePremier(),
    new CopieTableau(),
    new CarreMagique(),
    new RotationMatriceCarree(),
    new DiagonaleRectangle(),
    new ManipuleListe(),
    new NombresDigitaux(),
    new TriArbre(),
    new ReadInt(),
    new EvenNumber(),
    new Division(),
    new VerifCompteBBAN(),
    new CollectionWhile(),
    new CollectionFor(),
    new StructurePoint(),
    new JeuDeCarte(),
};

do
{

    for (int i = 0; i < exercices.Length; i++)
    {
        Console.WriteLine("{0,2} {1}", i + 1, exercices[i].Name);
    }
    Console.WriteLine("{0,2} {1}", 'q', "Quitter");
    Console.WriteLine("--------------");
    Console.Write("choix : ");
    entree = Console.ReadLine();

    if (Int32.TryParse(entree, out choix))
    {
        Console.Clear();
        try
        {
            if (choix > 0 && choix <= exercices.Length)
            {
                exercices[choix - 1].Execute();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        Console.ReadKey();
        Console.Clear();

    }
} while (entree != "q");