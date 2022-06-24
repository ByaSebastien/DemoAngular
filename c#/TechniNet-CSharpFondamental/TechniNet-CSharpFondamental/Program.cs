#region Exo-1A

using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using TechniNet_CSharpFondamental;

{
    // Console.Write("Entre un nombre, pouyeux !: ");
    // int nb1 = int.Parse(Console.ReadLine());
    //
    // Console.Write("Ha Mamia, entre encore un nombre, esclave: ");
    // int nb2 = int.Parse(Console.ReadLine());
    //
    // Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
}
#endregion
#region Exo-1B
{
    // Console.Write("Entre un nombre, pouyeux !: ");
    // int nb1;
    // while(!int.TryParse(Console.ReadLine(), out nb1))
    // {
    //     Console.WriteLine("INCAPABLEUH... un nombre entier c'est trop complexe...");
    // }
    //
    // Console.Write("Ha Mamia, entre encore un nombre, esclave: ");
    // int nb2;
    // while(!int.TryParse(Console.ReadLine(), out nb2))
    // {
    //     Console.WriteLine("INCAPABLEUH... un nombre entier c'est trop complexe...");
    // }
    //
    // Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
}
#endregion

#region Exo - 2
// {
//     int n = int.Parse(Console.ReadLine());
//
//     if (n / 2 + n / 2 == n) Console.WriteLine($"{n} est pair");
//     else Console.WriteLine($"{n} est impair");
// }
#endregion

#region Exo - 3A
{
    // Console.WriteLine($"Division entière: {5/2}, Modulo: {5%2}, Division: {5F/2}");
}
#endregion
#region Exo - 3
// {
//     string bban = Console.ReadLine();
//
//     #region Exo - 3B - Attendu
//
//     // long toModulo = long.Parse(bban.Substring(0, 3) + bban.Substring(4, 7));
//     // int checkModulo = int.Parse(bban.Substring(12, 2));
//     //
//     // if (checkModulo == toModulo % 97 || toModulo % 97 == 0 && checkModulo == 97)
//     // {
//     //     Console.WriteLine("OK");
//     // }
//     // else
//     // {
//     //     Console.WriteLine("KO");
//     // }
//
//     #endregion
//
//     #region Exo - 3B - Regex
//
//     Regex regex = new Regex(@"(\d{3})-(\d{7})-(\d{2})");
//
//     var match = regex.Match(bban);
//     if (match.Success)
//     {
//         long ten = long.Parse(match.Groups[1].Value+ match.Groups[2].Value);
//         long modulo = long.Parse(match.Groups[3].Value);
//
//         if (ten % 97 == modulo || ten % 97 == 0 && modulo == 97)
//         {
//             Console.WriteLine("OK");
//         }
//         else
//         {
//             Console.WriteLine("KO");
//         }
//     }
//     else
//     {
//         Console.WriteLine("KO");
//     }
//
//     #endregion
//
//     #region Exo - 3C
//
//     string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//     string iban = bban + $"{digits.IndexOf("B")}{digits.IndexOf("E")}00";
//     bban = bban.Replace("-", "");
//     iban = iban.Replace("-", "");
//     long ibanNumber = long.Parse(iban);
//     long check = 98 - ibanNumber % 97;
//     
//     StringBuilder builder = new StringBuilder();
//     builder
//         .Append("BE")
//         .Append($"{(check >= 10 ? check : "0" + check)} ")
//         .Append(bban.Substring(0, 4))
//         .Append(" ")
//         .Append(bban.Substring(4, 4))
//         .Append(" ")
//         .Append(bban.Substring(8, 4));
//
//     Console.WriteLine(builder.ToString());
//
//     #endregion
// }
#endregion

#region Exo 4.1 Base
// int fibo1 = 0;
// int fibo2 = 1;
// Console.WriteLine(fibo1);
// Console.WriteLine(fibo2);
// for (int i = 3; i <= 25; i++)
// {
//     int fibo3 = fibo1 + fibo2;
//     Console.WriteLine(fibo3);
//     fibo1 = fibo2;
//     fibo2 = fibo3;
// }
#endregion
#region Exo 4.1 Recusion
// {
//     static long Fibo(int n)
//     {
//         if (n == 1) return 0;
//         if (n == 2) return 1;
//
//         long fibo1 = Fibo(n - 1);
//         long fibo2 = Fibo(n - 2);
//
//         Console.WriteLine($"{fibo1} + {fibo2} = {fibo1 + fibo2}");
//         return fibo1 + fibo2;
//     }
//
//     Console.WriteLine(Fibo(25));
// }
#endregion

#region Exo 4.2
{
    // int n = int.Parse(Console.ReadLine());
    //
    // for (int i = n - 1; i > 1; i--)
    // {
    //     n *= i;
    // }
    //
    // Console.WriteLine(n);
}
#endregion

#region Exo 4.3
//
// {
//     int nbPremier = int.Parse(Console.ReadLine());
//     int nPremierFind = 0;
//     for (int i = 1; nPremierFind < nbPremier; i++)
//     {
//         bool isFirst = true;
//         for (int j = i / 2; j > 1 && isFirst; j--)
//         {
//             if (i % j == 0)
//             {
//                 isFirst = false;
//             }
//         }
//
//         if (isFirst)
//         {
//             Console.WriteLine(i);
//             nPremierFind++;
//         }
//     }
// }
#endregion

#region Exo 4.4

// for (int i = 0; i <= 20; i++)
// {
//     for (int j = 0; j <= 5; j++)
//     {
//         Console.Write($"{j} * {i} = {j * i}\t");
//     }
//     
//     Console.WriteLine();
// }
#endregion

#region Exo 5.1
// List<int> premiers = new List<int>();
// int under = int.Parse(Console.ReadLine());
// int toTest = 1;
// while (toTest < under)
// {
//     bool isFirst = true;
//     
//     int j = toTest / 2;
//     while (j > 1 && isFirst)
//     {
//         if (toTest % j == 0)
//         {
//             isFirst = false;
//         }
//
//         j--;
//     }
//
//     if (isFirst)
//     {
//         premiers.Add(toTest);
//     }
//
//     toTest++;
// }
//
// int i = 0;
// while (i < premiers.Count)
// {
//     Console.WriteLine(premiers[i]);
//     i++;
// }
#endregion
#region Exo 5.2

// List<int> premiers = new List<int>();
// int under = int.Parse(Console.ReadLine());
//
// for (int i = 1; i < under; i++)
// {
//     bool isFirst = true;
//     for (int j = i / 2; j > 1 && isFirst; j--)
//     {
//         if (i % j == 0)
//         {
//             isFirst = false;
//         }
//     }
//     if (isFirst) { premiers.Add(i); }
// }
//
// foreach (int it in premiers)
// {
//     Console.WriteLine(it);
// }
#endregion
#region Exo 5.3

// string str1 = Console.ReadLine();
// string str2 = Console.ReadLine();
//
// int maxLength = str1.Length >= str2.Length ? str1.Length : str2.Length;
// while (str1.Length < maxLength) { str1 = "0"+ str1; }
// while (str2.Length < maxLength) { str2 = "0"+ str2; }
//
// Console.WriteLine(str1);
// Console.WriteLine(str2);
//
// Stack<char> n1 = new Stack<char>(str1.ToCharArray());
// Stack<char> n2 = new Stack<char>(str2.ToCharArray());
// Stack<int> report = new Stack<int>();
// Stack<int> result = new Stack<int>();
//
// while (n1.Count > 0)
// {
//     int i = n1.Pop() - 48;
//     int j = n2.Pop() - 48;
//     int r = report.Count > 0 ? report.Pop() : 0;
//
//     int res = i + j + r;
//     if (res >= 10)
//     {
//         report.Push(1);
//     }
//
//     result.Push(res % 10);
// }
//
// if (report.Count > 0)
// {
//     result.Push(report.Pop());
// }
//
// foreach (int chiffre in result)
// {
//     Console.Write(chiffre);
// }
// char[] str1Chars = str1.ToCharArray();
// for (int i = 0; i < str1Chars.Length; i++)
// {
//     n1.Push(str1Chars[i]);
// }


#endregion

#region Exo 6.1
//
//
// Point?[,] Matrix = new Point?[5, 5];
// for (int i = 0, j = 0; i < Matrix.GetLength(0) && j < Matrix.GetLength(1); i++, j++)
// {
//     Point point;
//     point.X = j;
//     point.Y = i;
//
//     Matrix[i, j] = point;
// }
//
// for (int i = 0; i < Matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         if (Matrix[i, j].HasValue)
//         {
//             Point point = Matrix[i, j].Value;
//             Console.Write($"Point<X={point.X}, Y={point.Y}>");
//         }
//         else
//         {
//             Console.Write("               ");
//         }
//     }
//
//     Console.WriteLine();
//
// }

#endregion

// Celsius celsius;
// celsius.Temperature = int.Parse(Console.ReadLine());
// Farenheith farenheith = celsius.Conversion();
// Console.WriteLine(farenheith.Conversion());
// Celsius c2;
// c2.Temperature = 20;
// Console.WriteLine(c2.Conversion().Temperature);
//
// Eq2Degree eq2Degree;
// eq2Degree.A = 1;
// eq2Degree.B = 2;
// eq2Degree.C = 1;
//
// if (eq2Degree.Resoudre(out double? X1, out double? X2))
// {
//     Console.WriteLine($"Les racines sont {X1} et {X2}");
// }
// else
// {
//     Console.WriteLine("Pas solution");
// }
//
// struct Celsius
// {
//     public double Temperature;
//
//     public Farenheith Conversion()
//     {
//         Farenheith farenheith;
//         farenheith.Temperature = Temperature * 9 / 5 + 32;
//         return farenheith;
//     }
// }
//
// struct Farenheith
// {
//     public double Temperature;
//
//     public Celsius Conversion()
//     {
//         Celsius celsius;
//         celsius.Temperature = (Temperature - 32) * 5 / 9;
//         return celsius;
//     }
// }
//
// struct Eq2Degree
// {
//     public double A;
//     public double B;
//     public double C;
//
//     public bool Resoudre(out double? X1, out double? X2)
//     {
//         double delta = Delta();
//         if (delta < 0)
//         {
//             X1 = X2 = null;
//             return false;
//         }
//
//         if (delta == 0)
//         {
//             X1 = X2 = -B / (2 * A);
//             return true;
//         }
//         else
//         {
//             X1 = (-B + Math.Sqrt(delta)) / (2 * A);
//             X2 = (B + Math.Sqrt(delta)) / (2 * A);
//
//             return true;
//         }
//     }
//
//     public double Delta()
//     {
//         return B * B - 4 * A * C;
//     }
// }

Carte[] cartes = new Carte[52];
int index = 0;

foreach (Couleur color in Enum.GetValues<Couleur>())
{
    foreach (Valeur valeur in Enum.GetValues<Valeur>())
    {
        cartes[index].Color = color;
        cartes[index].Value = valeur;
        index++;
    }
}

foreach (Carte carte in cartes)
{
    Console.WriteLine($"{carte.Value} de {carte.Color}");
}

enum Couleur { Coeur, Carreau, Treffle, Pique }
enum Valeur { As= 14, Deux= 2, Trois= 3, Quatre= 4, Cinq= 5, Six= 6, Sept= 7, Huit= 8, Neuf= 9, Dix= 10, Valet= 11, Dame= 12, Roi= 13}

struct Carte
{
    public Couleur Color;
    public Valeur Value;
}