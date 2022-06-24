using Logique;

internal class Division : ICommand
{
    public string Name => "Division / Modulo";

    public void Execute()
    {      
        Console.WriteLine($"5 / 2 = {5/2}");
        Console.WriteLine($"5 % 2 = {5%2}");
        Console.WriteLine($"5 / 2 = {5.0/2}");
    }
}