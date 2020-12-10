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
        
    }
}
