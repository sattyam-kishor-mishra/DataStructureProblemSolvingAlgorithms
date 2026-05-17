using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class LongestSubsequenceArrayLength
    {

        public static int LongestSubsequence(int[] arr)
        {
            int n = arr.Length;

            int[] dp = new int[n];
            
            Array.Fill(dp, 1);


            for (int i = 1; i<n;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);

                    }
                }
            }

            return dp.Max();
        }
    }
}
