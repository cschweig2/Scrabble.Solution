using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
    [TestClass]
    public class WordsTests
    {
        [TestMethod]
        public void WordsConstructor_CreatesInstancesOfWords_Words()
        {
            Words newWords = new Words();
            Assert.AreEqual(typeof(Words), newWords.GetType());
        }
        [TestMethod]
        public void GetArray_CreatesEmptyArrayOfChars_EmptyArray()
        {
            char [] testLetters = { };
            Words newWords = new Words();
            char [] result = Words.GetArray("");
            CollectionAssert.AreEqual(result, testLetters);
        }
        [TestMethod]
        public void GetArray_CreatesArrayOfChars_Array()
        {
            char[] testLetters2 = {'h', 'e', 'l', 'l', 'o'};
            string word = "hello";
            char[] result = Words.GetArray(word);
            CollectionAssert.AreEqual(result, testLetters2);
        }
        [TestMethod]
        public void GetPoints_ReturnsUsersPoints_Int()
        {
            char[] testLetters3 = {'H', 'E', 'L', 'L', 'O'};
            int testScore = 8;
            int score = 0;
            int result = Words.GetPoints(testLetters3, score);
            Assert.AreEqual(result, testScore);
        }
    }
}
