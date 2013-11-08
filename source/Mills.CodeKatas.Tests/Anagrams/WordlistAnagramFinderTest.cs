using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Mills.CodeKatas.Anagrams;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.Anagrams
{
    [TestFixture]
    public class WordlistAnagramFinderTest
    {
        private Stream GetWordlistStream()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(WordlistAnagramFinder));
            return assembly.GetManifestResourceStream("Mills.CodeKatas.Anagrams.wordlist.txt");
        }

        [Test]
        public void AnagramFinderLoadsWordlist()
        {
            using (Stream stream = GetWordlistStream())
            {
                WordlistAnagramFinder anagramFinder = new WordlistAnagramFinder(stream);
                Assert.AreEqual(45425, anagramFinder.GetWordlistCount());
            }
        }

        [Test]
        public void FindsAtLeastOneAnagram()
        {
            using (Stream stream = GetWordlistStream())
            {
                WordlistAnagramFinder anagramFinder = new WordlistAnagramFinder(stream);
                Assert.That(anagramFinder.FindAnagrams().Any());
            }
        }

        [Test]
        public void FindsCorrectNumberOfAnagrams()
        {
            using (Stream stream = GetWordlistStream())
            {
                WordlistAnagramFinder anagramFinder = new WordlistAnagramFinder(stream);
                IEnumerable<IList<string>> anagrams = anagramFinder.FindAnagrams();
                Assert.That(anagrams.Count(), Is.EqualTo(1359));
            }
        }
    }
}
