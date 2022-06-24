using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDAppPalindrome
{
    [TestClass]
    public class UnitTestPalindrome
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMotUneLettreResultThrowException()
        {
            // Arrangement
            string word = "a";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
        }
        [TestMethod]
        [ExpectedException(typeof(PalindromeException))]
        public void TestMotDeuxLettresThrowException()
        {
            // Arrangement
            string word = "ab";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
        }
        [TestMethod]
        public void TestMotDeuxLettresOK()
        {
            // Arrangement
            string word = "aa";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [ExpectedException(typeof(PalindromeException))]
        public void TestMotTroisLettresThrowException()
        {
            // Arrangement
            string word = "abz";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
        }
        [TestMethod]
        public void TestMotTroisLettresOK()
        {
            // Arrangement
            string word = "aba";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [ExpectedException(typeof(PalindromeException))]
        public void TestMotQuatreLettresThrowException()
        {
            // Arrangement
            string word = "abzz";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
        }
        [TestMethod]
        public void TestMotQuatreLettresOK()
        {
            // Arrangement
            string word = "abba";
            // Action
            bool result = BLLPalindrome.IsPalindrome(word);
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPalindromeResultOK()
        {
            // Arrangement
            string word = "ababa";
            //Action
            bool result = BLLPalindrome.IsPalindrome(word);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void BugWord_ère()
        {
            // Arrangement
            string word = "ère";
            //Action
            bool result = BLLPalindrome.IsPalindrome(word);
            //Assert
            Assert.IsTrue(result);
        }
    }
}