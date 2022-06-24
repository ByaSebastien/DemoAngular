namespace UsingLambdaExpressions
{
    public delegate int ArithmetiqueDelegate(int x, int y);
    public delegate int PowerDelegate(int x);
    public class Program
    {
        public static void Main(String[] args)
        {
            //call named method direct
            Console.WriteLine(Add(3, 5));
            //call delegate
            ArithmetiqueDelegate mydel = Add;
            Console.WriteLine(mydel(10, 7));
            //Anonymous method with delegate
            mydel = delegate (int x, int y) { return x - y; };
            Console.WriteLine(mydel(80, 50));
            //Anonymous method with lambda operator
            mydel = (int x, int y) =>
             {
                 int result = x * y;
                 return result;
             };
            Console.WriteLine(mydel(8, 5));
            //
            mydel = (x, y) => x / y;
            Console.WriteLine(mydel(9, 3));
            //Delegate with one parameter
            PowerDelegate mypower = v => v * v * v;
            Console.WriteLine(mypower(5));
            int[] chiffres = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> chiffresInférieurCinq = chiffres.Where(n => n < 5);
            foreach (var nombre in chiffresInférieurCinq)
            {
                Console.WriteLine(nombre);
            }

        }
        public static int Add(int pValue1, int pValue2)
        {
            return pValue1 + pValue2;
        }
    }
}