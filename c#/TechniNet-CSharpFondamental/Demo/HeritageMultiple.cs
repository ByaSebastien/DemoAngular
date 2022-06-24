namespace Demo;

public abstract class Voiture
{
    public abstract void Tourner();
}

public interface IBateau
{
    void Tourner();
}

public class VoitureAmphibie: Voiture, IBateau
{
    public override void Tourner()
    {
        Console.WriteLine("Biblop");
    }

    void IBateau.Tourner()
    {
        Console.WriteLine("BLOP");
    }
}

public class Bateau : IBateau
{
    public void Tourner()
    {
        throw new NotImplementedException();
    }
}