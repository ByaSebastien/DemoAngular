using System.Numerics;

namespace BLLFactorial
{
    /// <summary>
    /// Cette classe gere les concepts lié aux factorielles
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// Calcul la factorielle d'un nombre donné
        /// </summary>
        /// <param name="pNumber">Le nombre donné</param>
        /// <returns>Resultat de la factorielle en BigInteger</returns>
        public static BigInteger Calculate(decimal pNumber)
        {
            BigInteger resultat = 1;
            for (long currentNumber = 2; currentNumber <= pNumber; currentNumber++)
            {
                resultat *= currentNumber;
            }
            return resultat;
        }
    }
}