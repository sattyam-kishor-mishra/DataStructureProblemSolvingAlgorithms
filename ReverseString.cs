using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class ReverseString
    {
        public static string FunctionReverseString(string s)
        {
            var l = s.Length;
            Span<char> tempchar = stackalloc char[l];
            for (int i =0; i< l; i++)
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

        public static bool FunctionPallindrom(string s)
        {
            var l = s.Length;
            var isPallindrome = false;
            for (int i = 0; i < l; i++)
            {                
                if(i != (l - 1 - i))
                {
                    var firstChar = s[i];
                    var lastChar = s[l - 1 - i];

                    isPallindrome = (firstChar == lastChar);
                }

            }
            return isPallindrome;

        }
    }
}
