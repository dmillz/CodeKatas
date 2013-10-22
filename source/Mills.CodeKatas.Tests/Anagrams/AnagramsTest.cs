using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.Anagrams;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.Anagrams
{
    [TestFixture]
    public class AnagramsTest
    {
        [Test]
        public void AbAndBaAreAnagrams()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsTrue(anagramAnalyzer.AreAnagrams("ab", "ba"));
        }

        [Test]
        public void AbAndAcAreNotAnagrams()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsFalse(anagramAnalyzer.AreAnagrams("ab", "ac"));
        }

        [Test]
        public void CapitalizationIsIgnored()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsTrue(anagramAnalyzer.AreAnagrams("AB", "ba"));
        }

        [Test]
        public void SpacesAreIgnored()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsTrue(anagramAnalyzer.AreAnagrams("a b", "ba"));
        }

        [Test]
        public void AllWhitespaceIsIgnored()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsTrue(anagramAnalyzer.AreAnagrams("a    \n b", "ba"));
        }

        [Test]
        public void NullInputIsNeverAnAnagram()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsFalse(anagramAnalyzer.AreAnagrams(null, null));
            Assert.IsFalse(anagramAnalyzer.AreAnagrams(null, ""));
            Assert.IsFalse(anagramAnalyzer.AreAnagrams("", null));
        }

        [Test]
        public void EmptyStringsAreAnagrams()
        {
            AnagramAnalyzer anagramAnalyzer = new AnagramAnalyzer();
            Assert.IsTrue(anagramAnalyzer.AreAnagrams("", ""));
        }
    }
}
