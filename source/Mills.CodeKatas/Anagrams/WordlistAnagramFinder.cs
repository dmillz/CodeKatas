using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mills.CodeKatas.Anagrams
{
    class Word
    {
        public string Original { get; set; }    
        public string SanitizedAndSorted { get; set; }
    }

    class WordComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Word word1 = (Word) x;
            Word word2 = (Word) y;

            return word1.SanitizedAndSorted.CompareTo(word2.SanitizedAndSorted);
        }
    }

    public class WordlistAnagramFinder
    {
        private Stream _stream;
        private IList<Word> _wordlist = new List<Word>();

        public WordlistAnagramFinder(Stream stream)
        {
            _stream = stream;

            using (StreamReader reader = new StreamReader(_stream))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    if (!String.IsNullOrWhiteSpace(word))
                    {
                        _wordlist.Add(new Word
                            {
                                Original = word,
                                SanitizedAndSorted = SortLetters(SanitizeInput(word))
                            });
                    }
                }

                ArrayList.Adapter((IList)_wordlist).Sort(new WordComparer());
            }
        }

        public int GetWordlistCount()
        {
            return _wordlist.Count;
        }

        public IEnumerable<IList<string>> FindAnagrams()
        {   
            IList<string> anagrams = new List<string>();

            Word prev = _wordlist[0];
            for (int i = 1; i < _wordlist.Count; i++)
            {
                Word current = _wordlist[i];

                if (anagrams.Count == 0)
                {
                    anagrams.Add(current.Original);
                    prev = current;
                    continue;
                }
                
                if (current.SanitizedAndSorted == prev.SanitizedAndSorted)
                {
                    anagrams.Add(current.Original);
                    continue;
                }
                
                if (anagrams.Count > 1)
                {
                    yield return anagrams;
                }

                anagrams = new List<string>();
            }
        }

        private static string SanitizeInput(string s)
        {
            // Lowercase
            s = s.ToLower();

            // Remove whitespace 
            s = Regex.Replace(s, @"\s+", "");

            return s;
        }

        private static string SortLetters(string s)
        {
            return String.Concat(s.OrderBy(c => c));
        }
    }
}
