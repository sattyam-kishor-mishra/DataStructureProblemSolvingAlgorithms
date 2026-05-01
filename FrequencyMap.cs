using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class FrequencyMap
    {

        public static Dictionary<char, int> FunctionFrequencyMap(string s)
        {
            
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if(frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c] += 1;
                }
                else
                {
                    frequencyMap[c] = 1;
                }
            }

            return frequencyMap;
        }
    }
}
