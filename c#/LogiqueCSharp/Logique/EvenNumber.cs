using Logique;

internal class EvenNumber : ICommand
{
    public string Name => "Even number";

    public void Execute()
    {
        int number = 0;

        Console.WriteLine("Entrez un nombre");
        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("un nombre !!!");
        }
        if((number/2)*2 == number)
        {
            Console.WriteLine("Ce nombre est pair.");
        }
        else
        {
            Console.WriteLine("Ce nombre est impair.");
        }
    }
}