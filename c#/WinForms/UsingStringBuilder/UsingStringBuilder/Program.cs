using System.Diagnostics;
using System.Text;

string s = "a";
Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < 200000; i++)
{
    s += "b";
}
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);
StringBuilder stringBuilder = new StringBuilder("a");
stopwatch.Reset();
stopwatch.Start();
for (int i = 0; i < 20000000; i++)
{
    stringBuilder.Append("b");
}
s = stringBuilder.ToString();
stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);