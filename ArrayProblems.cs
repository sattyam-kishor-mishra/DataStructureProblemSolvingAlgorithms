using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{

    public static class ArrayProblems
    {

        public static void FunctionReverseArray(int[] arr)
        {
            int r = arr.Length;
            for (int l = 0; l < r -1 - l; l++)
            {
                
                    int n = arr[l];
                    int m = arr[r - 1 - l];

                    arr[r - 1 - l] = n;
                    arr[l] = m;
                
                
            }
        }


        public static void MissingElement(int[] arr)           
        {           

            var ua = arr.Distinct().ToArray();

            int mv = ua.Min();
            int mxv = ua.Max();

            int sum = mxv * (mxv + 1) / 2;

            int arraySum = 0;

            for (int i = 0; i < ua.Length; i++)
            {
                arraySum += ua[i];
            }

            if (sum - arraySum > 0)
                Console.WriteLine(sum - arraySum);
            else if(sum - arraySum == 0)
                Console.WriteLine(mxv + 1);

        }

        public static void RemoveDuplicateInArray(int[] arr)
        {
            HashSet<int> result = new();

            for (int i = 0; i< arr.Length; i++)
            {
                if (!result.Contains(arr[i]))
                {
                    result.Add(arr[i]);
                }
            }


            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }

        public static void MinAndMaxElement(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
            

        }

        public static void MissingElementInAArray(int[] arr)
        {
            int r = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int val = Math.Abs(arr[i]); 
                if (val - 1 < n && arr[val - 1] > 0)
                {
                    arr[val - 1] = -arr[val - 1]; 
                }
            }

            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                    r = arr[i];
            }
        }



    }
}
