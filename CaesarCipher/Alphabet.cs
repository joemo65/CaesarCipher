using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Alphabet
    {
        private string alphabetName;
        private List<char> alphabetLetters;
        private int alphabetCount;

        public Alphabet(string name = "English", string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            alphabetName = name;
            alphabetLetters = new List<char>();
            alphabetCount = 0;

            foreach (char letter in letters)
            {
                alphabetLetters.Add(letter);
                alphabetCount++;
            }
        }

        public string AlphabetName
        {
            get { return alphabetName; }
            set { alphabetName = value; }
        }

        public List<char> AlphabetLetters
        {
            get { return alphabetLetters; }
            set { alphabetLetters = value; }
        }

        public int AlphabetCount
        {
            get { return alphabetCount; }
            set { alphabetCount = value; }
        }
    }
}
