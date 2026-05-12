using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class LongestSubStringWithoutRepeatingCharacter
    {

        public static int FunctionLongestSubStringWithoutRepeatingCharacter(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            int result = 0;
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();

            int l = 0;

            for (int r = 0; r < s.Length; r++)
            {
                char c = s[r];                
                if (lastSeen.ContainsKey(c))
                {
                    l = r;
                }                
                lastSeen[c] = r;                
                result = Math.Max(result, r - l + 1);
            }
            return result;        }
    }
}
