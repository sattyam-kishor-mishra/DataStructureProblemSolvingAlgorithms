using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructureAlgorithms
{
    public static class MaxSumSubArray
    {
        public static int MaxSumSubArrayMethod(int[] arr, int k)
        {
            int windwsSum = 0;

            int maxSum = 0;

            //first find the first sliding windws sum 

            for (int i = 0; i < k; i++)
            {
                windwsSum += arr[i];
            }

            maxSum = windwsSum;

            // Now find teh sum of next windows by removing the first element and adding the next element in the array

            for (int i = 0; i< arr.Length - k; i++)
            {
                windwsSum = windwsSum - arr[i] + arr[i + k];
                maxSum = Math.Max(maxSum, windwsSum);
            }

            return maxSum;


        }
    }
}
