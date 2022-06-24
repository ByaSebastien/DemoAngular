namespace CSharp_OO.Exceptions;

public class SoldeInsuffisantException: Exception
{
    public SoldeInsuffisantException(string context, string message): base($"{context}: {message}")
    {
        
    }
    public SoldeInsuffisantException(string? message) : base(message)
    {
    }
}