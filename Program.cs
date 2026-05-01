using DataStructureAlgorithms;

//int[] arr = { 1, 4, 8, 2, 6, 4, 9 };

//int k = 3;


//int result = MaxSumSubArray.MaxSumSubArrayMethod(arr, k);

//int result2 = LongestSubStringWithoutRepeatingCharacter.FunctionLongestSubStringWithoutRepeatingCharacter("abcabcdebb");


//var frequencyMap = FrequencyMap.FunctionFrequencyMap("banana");

//Console.WriteLine($"The maximum sum of a subarray of size {k} is: {result}");
//Console.WriteLine($"The length of the longest substring without repeating characters is: {result2}");
//Console.WriteLine("Frequency Map for 'banana':");
//foreach (var kvp in frequencyMap)
//{
//    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//}


//LRUCacheImplementation lRUCacheImplementation = new LRUCacheImplementation(2);

//lRUCacheImplementation.Put(1, 1);
//lRUCacheImplementation.Put(2, 2);
//lRUCacheImplementation.Get(1);
//lRUCacheImplementation.Get(2);
//lRUCacheImplementation.Put(3, 3);
//lRUCacheImplementation.Get(1);
//lRUCacheImplementation.Get(3);



var limiter = new RateLimiter(3, TimeSpan.FromSeconds(10));

for (int i = 1; i <= 5; i++)
{
    bool allowed = limiter.AllowResponse("user1");
    Console.WriteLine($"Request {i}: {(allowed ? "Allowed" : "Blocked")}");
    System.Threading.Thread.Sleep(2000); // simulate delay
}

