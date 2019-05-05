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
        public void GetWord_GetASingleWord_String()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "hey");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void GetWord_GetWordRegardlessOfCase_String()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "HeY");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void GetWord_GetWordWithPunctuation_String()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "hey!");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void Count_CountsWordsInPhrase_Int()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "They said hey");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(1, actualCount);
        }

        [TestMethod]
        public void Count_CountsMultipleMatches_Int()
        {
            RepeatCounter myCounter = new RepeatCounter("hey", "They said hey hey");
            int actualCount = myCounter.Counter();
            Assert.AreEqual(2, actualCount); 
        }
 
    }
}