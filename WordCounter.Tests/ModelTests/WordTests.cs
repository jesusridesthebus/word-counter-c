using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void SetProperty_StoresWord_True()
        {
            Word testWord = new Word("a");
            Assert.AreEqual(typeof(Word), testWord.GetType());
        }

        [TestMethod]
        public void CountWord_CountsWordInShortSentence_Int()
        {
            Array[] testArray = {"a"};
            Word testWord = new Word("a");
            CollectionAssert.AreEqual(testArray, testWord.CountWord());
        }

    }
}