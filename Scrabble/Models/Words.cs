using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Scrabble.Models
{
    public class Words
    {
        private string scoreOne = "[aeioulnrst]";
        private string scoreTwo = "[dg]";
        private string scoreThree = "[bcmp]";
        private string scoreFour = "[fhvwy]";
        private string scoreFive = "[k]";
        private string scoreEight = "[jx]";
        private string scoreTen = "[qz]";


    }
}


// user input will be in the form of a string
// that string needs to be separated into char's 
// the value of each char will need to be added together to deliver a score
