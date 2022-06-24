using DAL;

namespace BLL
{
    public class BLLPalindrome
    {
        /// <summary>
        /// Trouver les palindrome dans un fichier text
        /// </summary>
        /// <param name="pFileName">Nom du fichier ( chemin d accès )</param>
        /// <returns></returns>
        public static List<string> SeekPalindrome(string pFileName)
        {
            string readTexte = DALPalindrome.Readfile(pFileName);
            List<string> palindromes = ExtractPalindrome(readTexte);
            return palindromes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string? word)
        {
            if (word is null || word.Length <= 1)
                throw new ArgumentNullException(nameof(word));
            string wordTest = CleanAccent(word);
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (!wordTest[i].Equals(wordTest[word.Length - i - 1]))
                    throw new PalindromeException(word,word[i],word[word.Length - i - 1]);
            }
            return true;
        }
        private static string CleanAccent(string? word)
        {
            string wordTest = word.Replace('è', 'e');
            wordTest = wordTest.Replace('é', 'e');
            wordTest = wordTest.Replace('ê', 'e');
            wordTest = wordTest.Replace('à', 'a');
            wordTest = wordTest.Replace('â', 'a');
            wordTest = wordTest.Replace('ù', 'u');
            wordTest = wordTest.Replace('û', 'u');
            wordTest = wordTest.Replace('î', 'i');
            return wordTest;
        }
        /// <summary>
        /// Mettre dans une liste les palindrome uniquement
        /// </summary>
        /// <param name="readTexte">Fichier texte en format string</param>
        /// <returns></returns>
        private static List<string> ExtractPalindrome(string readTexte)
        {
            string[] lines = readTexte.Split("\n", StringSplitOptions.TrimEntries);
            List<string> palindromes = new List<string>();
            foreach (string line in lines)
            {
                string[] words = line.Split(',', '(', ' ');
                palindromes.Add(words[0]);
            }
            return palindromes;
        }
    }
}