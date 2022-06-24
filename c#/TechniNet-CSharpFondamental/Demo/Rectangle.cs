namespace Demo;

public interface IForme
{
    string Color { get; }
    double Perimetre { get; }
    double Aire();
}

public interface IRectangle: IForme
{
    double Longueur { get; }
    double Largeur { get; }
}


public class Rectangle: IRectangle, IForme
{
    private double _Longueur;
    private double _Largeur;
    private string _Color;

    public double Longueur { 
        get => _Longueur;
        set => _Longueur = value;
    }

    public double Largeur
    {
        get => _Largeur;
        set => _Largeur = value;
    }

    public string Color
    {
        get => _Color;
        set => _Color = value;
    }
    public double Perimetre { get => 2*(Longueur + Largeur); }
    public double Aire()
    {
        return Longueur * Largeur;
    }

    public double Diagonal()
    {
        return Math.Sqrt(Largeur * Largeur + Longueur * Longueur);
    }
}

public class Carre : IRectangle, IForme
{
    public string Color { get; set; }
    public double Perimetre { get => 4*Largeur; }
    public double Aire()
    {
        return Largeur * Largeur;
    }

    public double Longueur { get => Largeur; }
    public double Largeur { get; set; }
}