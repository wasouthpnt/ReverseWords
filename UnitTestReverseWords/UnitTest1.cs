using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestReverseWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMainSuccess()
        {

            using (var sw = new StringWriter())
            {
                string Expected = String.Format("Input your sentence:{0}b a", Environment.NewLine);
                Console.SetOut(sw);
                using (StringReader sr = new StringReader(string.Format("a b{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    ReverseWordsInSentence.Main(new string[] { });
                    var result = sw.ToString().Trim();
                    Assert.AreEqual(Expected, result);
                }
            }
        }

        [TestMethod]
        public void TestMainFail()
        {

            using (var sw = new StringWriter())
            {
                string Expected = String.Format("Input your sentence:{0}Invalid Entry", Environment.NewLine);
                Console.SetOut(sw);
                using (StringReader sr = new StringReader(string.Format("blah{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);
                    ReverseWordsInSentence.Main(new string[] { });
                    var result = sw.ToString().Trim();
                    Assert.AreEqual(Expected, result);
                }
            }
        }

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
