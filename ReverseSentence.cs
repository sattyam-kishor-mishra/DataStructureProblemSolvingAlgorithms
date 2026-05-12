using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class ReverseSentence
    {
        public static string GetCompleteSentence(string s)
        {
            var arrayOfSentence = s.Split(' ');
            var continateString = new StringBuilder();

            foreach (var word in arrayOfSentence)
            {
                continateString.Append($"{GetReverse(word)} ");
            }

            return continateString.ToString();
        }


        private static string GetReverse(string s)
        {
            var l = s.Length;
            Span<char> tempchar = stackalloc char[l];
            for (int i = 0; i < l; i++)
            {
                if (i == (l - 1 - i))
                {
                    tempchar[i] = s[i];
                }
                else
                {
                    var firstChar = s[i];
                    var lastChar = s[l - 1 - i];

                    tempchar[i] = lastChar;
                    tempchar[l - 1 - i] = firstChar;
                }

            }
            return new string(tempchar);
        }

    }
}
