using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class SmallestSubstringLength
    {
        public static void FunctionSmallestSubstringLength(string s, string i)
        {

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(i))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            // Build frequency map of required characters
            var need = new Dictionary<char, int>();
            foreach (char c in i)
            {
                if (!need.ContainsKey(c)) need[c] = 0;
                need[c]++;
            }

            var window = new Dictionary<char, int>();
            int haveCount = 0, needCount = need.Count;
            int left = 0, minLen = int.MaxValue, start = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];
                if (need.ContainsKey(c))
                {
                    if (!window.ContainsKey(c)) 
                        window[c] = 0;
                    window[c]++;

                    if (window[c] == need[c]) 
                        haveCount++;
                }

                // Shrink window when all required chars are present
                while (haveCount == needCount)
                {
                    if (right - left + 1 < minLen)
                    {
                        minLen = right - left + 1;
                        start = left;
                    }

                    char leftChar = s[left];
                    if (need.ContainsKey(leftChar))
                    {
                        window[leftChar]--;
                        if (window[leftChar] < need[leftChar])
                            haveCount--;
                    }
                    left++;
                }
            }

            if (minLen == int.MaxValue)
                Console.WriteLine("No valid substring found");
            else
                Console.WriteLine($"Minimum Length : {minLen}, Substring: {s.Substring(start, minLen)}");
        }

        private static void FillTheDic( ref Dictionary<char, int> dic, string i)
        {
            for (int n = 0; n < i.Length; n++)
            {
                dic[i[n]] = 1;
            }
        }
    }
}
