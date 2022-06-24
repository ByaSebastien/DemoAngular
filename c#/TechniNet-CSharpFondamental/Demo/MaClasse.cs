namespace Demo;

public class MaClasse
{
    private int _MaVariable;
    
    public int Age { get; set; }

    public int MaVariable
    {
        get { return _MaVariable; }
        set
        {
            if (value >= 84)
            {
                Age = value;
                _MaVariable = value;
                Console.WriteLine($"Valeur mise = {_MaVariable}");
            }
            else
            {
                Console.WriteLine("Pas de modif");
            }

        }
    }

    public void Changer(int variable)
    {
        _MaVariable = variable;
    }
}