using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
    [TestClass]
    public class WordsTests : IDisposable
    {
        public void Dispose()
        {
            Words.ClearAll();
        }
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
            char [] result = Words.GetArray("test");
            CollectionAssert.AreEqual(result, testLetters);
        }
        [TestMethod]
        public void GetArray_CreatesArrayOfChars_Array()
        {
            char[] testLetters = {'h', 'e', 'l', 'l', 'o'};
            string word = "hello";
            char[] result = Words.GetArray(word);
            CollectionAssert.AreEqual(result, testLetters);
        }
        
    }
}
