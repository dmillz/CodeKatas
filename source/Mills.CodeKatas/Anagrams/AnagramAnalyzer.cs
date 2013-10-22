using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mills.CodeKatas.Anagrams
{
    public class AnagramAnalyzer
    {
        public bool AreAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
            {
                return false;
            }

            IDictionary<char, int> counts1 = CountChars(s1);
            IDictionary<char, int> counts2 = CountChars(s2);

            return counts1.Keys.All(c => counts2.ContainsKey(c) && counts1[c] == counts2[c]);
        }

        private IDictionary<char, int> CountChars(string s)
        {
            s = SanitizeInput(s);

            IDictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!counts.ContainsKey(c))
                {
                    counts[c] = 0;
                }
                counts[c]++;
            }

            return counts;
        }

        private static string SanitizeInput(string s)
        {
            // Lowercase
            s = s.ToLower();

            // Remove whitespace 
            s = Regex.Replace(s, @"\s+", "");

            return s;
        }
    }
}
