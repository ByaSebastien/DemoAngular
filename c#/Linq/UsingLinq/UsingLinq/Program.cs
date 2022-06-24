using UsingLinq;
using UsingLinq.Models;

//Restriction();
//Ordering();
//Partitioning();
//Projection();
//ExoProjection();
//Set();
//Quantifier();
//Aggregate();
//Conversion();
//RestrictionDB();
//DefferedExecution();

void DefferedExecution()
{
    int[] numbers = { 5, 3, 4, 0, 1, 7, 2, 6, 9, 8 };

    //deffered execution
    int i = 0;
    var defferedQuery = numbers.Select(x => ++i);

    Console.WriteLine($"valeur actuelle de i : {i}");
    foreach (var number in defferedQuery)
    {
        Console.WriteLine($"valeur nombre : {number} valeur i : {i}");
    }
    Console.WriteLine();

    //imediate execution by tolist()
    int j = 0;
    var imediateQuery = numbers.Select(x => ++j).ToList();

    Console.WriteLine($"valeur actuelle de j : {j}");
    foreach (var number in imediateQuery)
    {
        Console.WriteLine($"valeur nombre : {number} valeur j : {j}");
    }
    Console.WriteLine();

    //imediate execution by count()
    int k = 0;
    var imediateCountQuery = numbers.Select(x => ++k).Count();

    Console.WriteLine($"valeur actuelle de k : {k}");

    //foreach impossible count return un int

    //foreach (var number in imediateCountQuery)
    //{
    //    Console.WriteLine($"valeur nombre : {number} valeur i : {k}");
    //}
}
void RestrictionDB()
{
    using (NorthwindContext dbContext = new NorthwindContext())
    {
        var belgeClients = dbContext.Customers
                                              .Where(c => c.Country == "Belgium" || c.Country == "France")
                                              .Select(c => new { NomClient = c.ContactName, Telephone = c.Phone });

        foreach (var belgeClient in belgeClients)
        {
            Console.WriteLine(belgeClient);
        }

        var OddCategories = dbContext.Categories
                                                .Where(c => c.CategoryId % 2 == 1)
                                                .Select(c => new { ID = c.CategoryId, Name = c.CategoryName, Description = c.Description })
                                                .OrderBy(a => a.Name);

        foreach (var category in OddCategories)
        {
            Console.WriteLine(category);
        }

        var products = dbContext.Products
                                         .Where(p => p.ProductName
                                         .Contains("y"))
                                         .OrderBy(p => p.ProductName)
                                         .Select(p => new { Nom = p.ProductName, NomCategory = p.Category.CategoryName });

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Sales by cat");
        var q1 = dbContext.SalesByCategories;
        foreach (var c in q1)
        {
            Console.WriteLine(c);
        }
    }
}
void Conversion()
{
    // operateur ToList, ToArray, ToDictionary, AsEnumerable
    int[] numbers = { 5, 3, 4, 0, 1, 7, 2, 6, 9, 8 };
    List<int> listLowerNumbers = numbers.Where(n => n < 4).ToList();
    listLowerNumbers.Add(15);
    foreach (int number in listLowerNumbers)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    numbers = listLowerNumbers.ToArray();

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Dictionary<int, int> result = numbers.ToDictionary(n => n, n => n);

    foreach (var number in result)
    {
        Console.WriteLine(number.Value);
    }
    Console.WriteLine();

    IEnumerable<int> EnumNumbers = numbers.AsEnumerable();

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
}
void Aggregate()
{
    // operator Count, Sum, Min, Max, Average
    int[] numbers = { 5, 3, 4, 0, 1, 7, 2, 6, 9, 8 };

    int count = numbers.Where(n => n % 2 != 0).Count();

    Console.WriteLine(count);

    Console.WriteLine(numbers.Sum());

    Console.WriteLine(numbers.Average());

    Console.WriteLine(numbers.Max());

    Console.WriteLine(numbers.Min());
}
void Quantifier()
{
    // operator All, Any, Contains
    string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string[] wordies = { "zero", "one", "two", "four" };

    bool resultAll = wordies.All(w => w.ToLower().Contains('o'));

    Console.WriteLine(resultAll);

    bool resultAny = words.Any(w => w.ToLower().Contains('o'));

    Console.WriteLine(resultAny);

    resultAny = words.Any(w => w.ToLower().StartsWith('t'));

    Console.WriteLine(resultAny);
}
void Set()
{
    // operator Union , Intersect , Except , Distinct
    int[] factors300 = { 2, 2, 3, 5, 5 };

    IEnumerable<int> factorsDistinct = factors300.Distinct();

    foreach (int item in factorsDistinct)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

    int[] numbers1 = { 1, 2, 3, 5 };
    int[] numbers2 = { 1, 2, 6, 7 };

    IEnumerable<int> numbers3 = numbers1.Intersect(numbers2);

    foreach (int item in numbers3)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

    IEnumerable<int> numbers4 = numbers1.Union(numbers2);

    foreach (int item in numbers4)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

    IEnumerable<int> numbers5 = numbers1.Except(numbers2);

    foreach (int item in numbers5)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

}
void ExoProjection()
{
    int[] numbers = { 5, 3, 4, 0, 1, 7, 2, 6, 9, 8 };
    string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    var results = numbers.Select(n => new { Nombre = n, Mot = words[n] });

    foreach (var word in results)
    {
        Console.WriteLine(word);
    }

    Console.WriteLine();

    foreach (int number in numbers)
    {
        Console.WriteLine(words[number]);
    }
}
void Restriction()
{
    // Operateur where
    int[] numbers = { 5, 10, 15, 20, 25, 30 };

    // exemple syntax lambda
    IEnumerable<int> result = numbers.Where(n => n >= 15 && n <= 25);

    foreach (int number in result)
    {
        Console.WriteLine(number);
    }

    // exemple syntaxe query
    result = from n in numbers where n >= 15 && n <= 25 select n;

    foreach (int number in result)
    {
        Console.WriteLine(number);
    }

    // exemple avec objet
    Personne[] persons = {
                         new Personne { Name = "Gigi", Age = 18 },
                         new Personne { Name = "Pedro", Age = 99 },
                         new Personne { Name = "Bobo", Age = 2 }
                         };

    IEnumerable<Personne> Personnes = persons.Where(p => p.Name.Length == 4);

    foreach (Personne person in Personnes)
    {
        Console.WriteLine(person);
    }


}
void Ordering()
{
    // OrderBy , OrderByDescending , ThenBy , ThenByDescending , ( Reverse )
    Personne[] persons = {
                         new Personne { Name = "Gigi", Age = 18 },
                         new Personne { Name = "Pedro", Age = 99 },
                         new Personne { Name = "Bobo", Age = 2 },
                         new Personne { Name = "Gigi", Age = 2 }
                         };

    IEnumerable<Personne> Personnes = persons
                                      .OrderBy(p => p.Name)
                                      .ThenByDescending(p => p.Age)
                                      .Reverse()
                                      .Where(p => p.Name.Length == 4);

    foreach (Personne person in Personnes)
    {
        Console.WriteLine(person);
    }

    //exo declarer et charger une collection de dates
    //trier les dates par années puis par mois en desc

    DateTime[] dates = {
                        new DateTime(1991, 12, 5),
                        new DateTime(1991, 3, 27),
                        new DateTime(1995, 6, 23),
                        new DateTime(1993, 6, 9),
                        new DateTime(2000, 12, 13)
                        };

    IEnumerable<DateTime> result = dates.OrderBy(d => d.Year).ThenByDescending(d => d.Month);

    foreach (DateTime date in result)
    {
        Console.WriteLine(date.ToShortDateString());
    }
}
void Partitioning()
{
    // Operateurs Skip, Take , SkipWhile , TakeWhile
    int[] numbers = { 5, 10, 15, 20, 25, 30 };
    IEnumerable<int> results = numbers.Skip(2);
    foreach (int number in results)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
    results = numbers.Take(2);
    foreach (int number in results)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
    results = numbers.Skip(2).Take(2);
    foreach (int number in results)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
    results = numbers.Take(3).Skip(2);
    foreach (int number in results)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    string[] words = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
    IEnumerable<string> resultats = words.SkipWhile(w => w.Length == 3);

    foreach (string word in resultats)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine();

    resultats = words.TakeWhile(w => w.Length == 3);

    foreach (string word in resultats)
    {
        Console.WriteLine(word);
    }
    Console.WriteLine();
}
void Projection()
{
    // operator Select , SelectMany
    decimal[] decimals = { 3.5M, 8.33M, 5.69M, 2.66M, 96.69M };

    IEnumerable<decimal> results = decimals.Select(d => Math.Ceiling(d));

    foreach (decimal number in results)
    {
        Console.WriteLine(number);
    }

    int[] numbers = { 5, 10, 15, 20, 25, 30 };
    string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    var numbers2 = numbers.Select(n => new { Number = n, isEven = n % 2 == 0 });

    foreach (var number in numbers2)
    {
        Console.WriteLine(number);
    }

    foreach (int number in numbers)
    {
        Console.Write(number);
        if (number % 2 == 0)
            Console.WriteLine(" est pair!");
        else
            Console.WriteLine(" est impair!");
    }

    var crossJoin = numbers.SelectMany(n => words, (n, w) => new { Number = n, Word = w });

    Console.WriteLine();
    foreach (var number in crossJoin)
    {
        Console.WriteLine(number);
    }
    //cross join query syntax
    var crossJoinQuery = from n in numbers
                         from w in words
                         select new { Number = n, Word = w };

    Console.WriteLine();
    foreach (var number in crossJoinQuery)
    {
        Console.WriteLine(number);
    }
}