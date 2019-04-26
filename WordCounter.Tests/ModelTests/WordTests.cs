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
            EnterWord testWord = new EnterWord("word");
            Assert.AreEqual(typeof(EnterWord), testWord.GetType());
        }

    }
}