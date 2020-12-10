using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
    public class Words
    {
        public string word;
        private int _score = 0;
        private static char[] _charArray = { };

        private static Dictionary<char, int> letters = new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, 
		{'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
		{'D', 2}, {'G', 2},
		{'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
		{'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
		{'K', 5},
		{'J', 8}, {'X', 8},
		{'Q',10}, {'Z',10}};

        public static char[] GetArray(string word, char[] array)
        {
            array = word.ToCharArray();
            return array;
        }
        public static void ClearAll()
        {
            _charArray.Clear();
        }

    }
}


// user input will be in the form of a string 
// that string needs to be separated into char array (.toChar)
// we'll loop through that character array
// if char matches key add matching value to total score





    