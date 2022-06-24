namespace Demo;

public class Node
{
    public int? Value;
    public Node Gauche;
    public Node Droite;

    public Node()
    {
        Value = null;
        Gauche = null;
        Droite = null;
    }

    public void Insert(int value)
    {
        Console.WriteLine($"{Value} >? {value}");
        if (Value == null)
        {
            Value = value;
        }
        else if (Value >= value)
        {
            if (Gauche == null)
            {
                Gauche = new Node();
            }
            Gauche?.Insert(value);
        }
        else if (Value < value)
        {
            if (Droite == null)
            {
                Droite = new Node();
            }
            Droite?.Insert(value);
        }
        
    }

    public void Afficher()
    {
        Gauche?.Afficher();
        Console.WriteLine(Value);
        Droite?.Afficher();
    }
}