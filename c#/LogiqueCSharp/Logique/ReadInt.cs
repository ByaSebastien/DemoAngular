using Logique;

internal class ReadInt : ICommand
{
    public string Name => "Read a int with int.parse and int.tryparse";

    public void Execute()
    {
        int number;
        int number2;

        Console.WriteLine("Entrez un nombre");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine($"le nombre rentré est {number} !");
        while (!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine("J'ai dis un nombre!");
        }
        Console.WriteLine($"le nombre rentré est {number2} !");
        Console.WriteLine($"Leurs somme est {number+number2}");
    }
}