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
    }
}
