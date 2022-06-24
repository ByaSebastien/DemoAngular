using ProjectEuler;

internal class SumSquareDifference : ICommand
{
    public string Name => "Sum Square Difference";

    public void execute()
    {
        long SumOfTheSquares = 0;
        long SquareOfTheSum = 0;

        for (int number = 1; number <= 100; number++)
        {
            SumOfTheSquares += (int)Math.Pow(number, 2);
            SquareOfTheSum += number;
        }
        SquareOfTheSum = (int)Math.Pow(SquareOfTheSum, 2);

        Console.WriteLine(SquareOfTheSum-SumOfTheSquares);
    }
}