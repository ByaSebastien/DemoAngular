using ProjectEuler;

internal class SpecialPythagoreanTriplet : ICommand
{
    public string Name => "Special Pythagorean triplet";

    public void execute()
    {
        int result = 0;
        bool find = false;

        for (int a = 1; a < 1000 && !find; a++)
        {
            for (int b = 1; b < 1000 && !find; b++)
            {
                for (int c = 1; c < 1000 && !find; c++)
                {
                    if ( a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        result = a * b * c;
                        find = true;
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}