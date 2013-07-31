using System;
using System.Globalization;
using NUnit.Framework;

namespace Anagrams.Test.Unit
{
    [TestFixture]
    public class Anagrams
    {
        [Test]
        public void AnagramOfAIsA()
        {
            var result = new Word().Anagram("a");

            Assert.AreEqual("a", result);
        }

        [Test]
        public void AnagramOfABIsABBA()
        {
            var result = new Word().Anagram("ab");

            Assert.AreEqual("abba", result);
        }

        public class Word
        {
            public string Anagram(string word, int startIndex)
            {
                if (word.Length == 1)
                    return word;

                foreach (var chars in word)
                {
                    
                }
               
                
            }
        }
    }
}