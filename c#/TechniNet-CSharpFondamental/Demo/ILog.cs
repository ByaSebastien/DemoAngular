using System.Text;

namespace Demo;

public interface ILog
{
    void Debug(string context, string message);
    void Info(string context, string message);
    void Error(string context, string message);
}

public class ConsoleLog: ILog
{
    public virtual ConsoleColor ColorDebug => ConsoleColor.Green;
    public virtual ConsoleColor ColorInfo => ConsoleColor.Yellow;
    public virtual ConsoleColor ColorError => ConsoleColor.Red;
    public void Debug(string context, string message)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ColorDebug;
        Console.WriteLine($"DEBUG({context}): {message}");
        Console.ForegroundColor = oldColor;
    }

    public void Info(string context, string message)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ColorInfo;
        Console.WriteLine($"INFO({context}): {message}");
        Console.ForegroundColor = oldColor;
    }

    public void Error(string context, string message)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ColorError;
        Console.WriteLine($"ERROR({context}): {message}");
        Console.ForegroundColor = oldColor;
    }
}

public class SapinConsoleLog : ConsoleLog
{
    public override ConsoleColor ColorDebug { get => ConsoleColor.Cyan; }
    public override ConsoleColor ColorInfo { get => ConsoleColor.Magenta; }
    public override ConsoleColor ColorError { get => ConsoleColor.DarkYellow; }
}

public class FileLog : ILog
{
    public void Debug(string context, string message)
    {
        using (FileStream stream = File.Open("./debug.txt", FileMode.OpenOrCreate))
        {
            stream.Write(Encoding.ASCII.GetBytes($"DEBUG({context}: {message}"));
        }
    }

    public void Info(string context, string message)
    {
        throw new NotImplementedException();
    }

    public void Error(string context, string message)
    {
        throw new NotImplementedException();
    }
}