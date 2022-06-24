using Logique;

internal class StructurePoint : ICommand
{
    public string Name => "Structure Point";

    public void Execute()
    {
        Point?[,]tableau = new Point?[5, 5];
        int x = 0;
        int y = 0;

        for (x = 0, y = 0; x < tableau.GetLength(0); x++, y++)
        {
            tableau[x, y] = new Point(x, y);
        }
        for (x = 0; x < tableau.GetLength(0); x++)
        {
            for (y = 0; y < tableau.GetLength(1); y++)
            {
                if (tableau[x, y] is null)
                    Console.Write($"              ");
                else
                    tableau[x, y]?.afficher();
            }
            Console.WriteLine();
        }
    }
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void afficher()
        {
            Console.Write($"X : {X} - Y : {Y}");
        }
    }
}