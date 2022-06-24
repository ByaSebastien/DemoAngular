using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PalindromeException : Exception
    {
        public string Word { get; set; }
        public char CharAscendent { get; set; }
        public char CharDescendent { get; set; }
        public PalindromeException(string pWord, char pCharAscendent, char pCharDescendent) :this(pWord, pCharAscendent, pCharDescendent,"Palindrome faux")
        {

        }
        public PalindromeException(string pWord, char pCharAscendent, char pCharDescendent,string pMessage) :base(pMessage)
        {
            Word = pWord;
            CharAscendent = pCharAscendent;
            CharDescendent = pCharDescendent;
        }
    }
}
