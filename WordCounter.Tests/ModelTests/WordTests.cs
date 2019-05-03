using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordTest
    {
        // [TestMethod]
        // public void SetProperty_StoresWord_True()
        // {
        //     Word testWord = new Word("a");
        //     Assert.AreEqual(typeof(Word), testWord.GetType());
        // }

        [TestMethod]
        public void GetWord_GetAWord_String()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "hey there");
            string testWord = "hey";
            string actualWord = myCounter.Word;
            Assert.AreEqual(testWord, actualWord);
        }

        [TestMethod]
        public void Count_CountsWordsInPhrase_Int()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "I said hey");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(1, actualCount);
        }

    }
}