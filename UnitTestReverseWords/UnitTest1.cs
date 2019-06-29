using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestReverseWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReverseMultiWord()
        {
            string Expected = "string test my is This";
            string result = ReverseWordsInSentence.ReverseString("This is my test string");
            Assert.AreEqual(Expected, result);
        }

        
        [TestMethod]
        public void TestReverseSingleChars()
        {
            string Expected = "b a";
            string result = ReverseWordsInSentence.ReverseString("a b");
            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void TestReverseOneChar()
        {
            string Expected = " a";
            string result = ReverseWordsInSentence.ReverseString("a ");
            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void TestReverseSingleWord()
        {
            string Expected = "Hello";
            string result = ReverseWordsInSentence.ReverseString("Hello");
            Assert.AreEqual(Expected, result);
        }
    }
}
