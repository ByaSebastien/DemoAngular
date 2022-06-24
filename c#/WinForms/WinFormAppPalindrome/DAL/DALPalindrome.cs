namespace DAL
{
    public class DALPalindrome
    {
        public static string Readfile(string pFileName)
        {
            return File.ReadAllText(pFileName);
        }
    }
}