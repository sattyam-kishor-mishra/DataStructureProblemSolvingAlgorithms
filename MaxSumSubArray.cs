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


        //sort the array by assending order by recursion 

        public static void SortArrayByRecursion(int[] arr, int n)
        {
            // Base case: If the array has 0 or 1 element, it's already sorted
            if (n <= 1)
                return;
            // Recursive case: Sort the first n-1 elements
            SortArrayByRecursion(arr, n - 1);
            // Insert the last element at its correct position in the sorted array
            int lastElement = arr[n - 1];
            int j = n - 2;
            // Move elements of arr[0..n-2], that are greater than lastElement, to one position ahead of their current position
            while (j >= 0 && arr[j] > lastElement)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = lastElement;
        }

        public static int MinSubArrayLengthWithTargetValue(int[] arr, int n)
        {
            //[1, 2 ,3 ,4 5], 9

            int ml = int.MaxValue;

            int l = 0;

            int s = 0;
            for (int r =0; r< arr.Length;r++)
            {
                s += arr[r]; //

                while (s >= n && l <= r)  
                {
                    ml = Math.Min(ml, r - l + 1); 
                    s -= arr[l];
                    l++;
                }
            }
            


            return ml;
        }
    }
}
