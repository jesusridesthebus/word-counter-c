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
            Word testWord = new Word("word");
            Assert.AreEqual(typeof(Word), testWord.GetType());
        }

    }
}