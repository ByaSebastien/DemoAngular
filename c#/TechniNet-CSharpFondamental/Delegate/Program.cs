using Delegate.Delegates;

Voiture v = new Voiture("1-BWW-114");
Carwash carwash = new Carwash();
int program = new Random().Next(0, 2);
carwash.Traiter(v, (ProgramLavage)program);

public class Voiture
{
    public string Plaque { get; }

    public Voiture(string plaque)
    {
        Plaque = plaque;
    }
}

public class Carwash
{
    private void Preparer(Voiture v)
    {
        Console.WriteLine($"Prepare {v.Plaque}");
    }

    private void Laver(Voiture v)
    {
        Console.WriteLine($"Lave {v.Plaque}");
    }

    private void Secher(Voiture v)
    {
        Console.WriteLine($"Seche {v.Plaque}");
    }

    private void Finaliser(Voiture v)
    {
        Console.WriteLine($"Finalise {v.Plaque}");
    }

    public void Traiter(Voiture v, ProgramLavage programLavage)
    {
        CarwarshFlow flow = Preparer;
        flow += Laver;
        if (programLavage == ProgramLavage.Program2)
        {
            flow += Secher;
        }
        flow += Finaliser;

        flow?.Invoke(v);
    }
}

public enum ProgramLavage
{
    Program1,
    Program2
}
