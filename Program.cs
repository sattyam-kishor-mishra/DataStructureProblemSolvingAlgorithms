using DataStructureAlgorithms;

//int[] arr = { 1, 4, 8, 2, 6, 4, 9 };

//int k = 3;


//int result = MaxSumSubArray.MaxSumSubArrayMethod(arr, k);

//int result2 = LongestSubStringWithoutRepeatingCharacter.FunctionLongestSubStringWithoutRepeatingCharacter("abcadcrfg");
//int result3 = LongestSubStringWithoutRepeatingCharacter.FunctionLongestSubStringWithoutRepeatingCharacter("abcbcamnopqr");

//Console.WriteLine($"The length of the longest substring without repeating characters is: {result2} | {result3}");
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



/* Rate Limiter Example */
//var limiter = new RateLimiter(5, TimeSpan.FromSeconds(20));

//for (int i = 1; i <= 10; i++)
//{
//    bool allowed = limiter.AllowRequest("user1");
//    Console.WriteLine($"Request {i}: {(allowed ? "Allowed" : "Blocked")}\n");
//    System.Threading.Thread.Sleep(2000); // simulate delay
//}

//for (int i = 1; i <= 5; i++)
//{
//    bool allowed = limiter.AllowResponse("user1");
//    Console.WriteLine($"Request {i}: {(allowed ? "Allowed" : "Blocked")}");
//    System.Threading.Thread.Sleep(2000); // simulate delay
//}


/*Recusrion Examples*/




//var result = RecursionExamples.AddNumbers(input);
//var result2 = RecursionExamples.Factorial(input);
//var result3 = RecursionExamples.Fibonacci(input);

//Console.WriteLine($"The sum of numbers up to {input} is: {result}\n");
//Console.WriteLine($"The factorial of {input} is: {result2}\n");
//Console.WriteLine($"The {input}th Fibonacci number is: {result3} \n"); 

/*Reverse String Example*/

//Console.WriteLine("Enter the Number");
//var input = Console.ReadLine()!;

//var reversed = ReverseString.FunctionReverseString(input);
//Console.WriteLine($"Reversed string: {reversed}");

//var ispallindrom = ReverseString.FunctionPallindrom(input);
//Console.WriteLine($"Is palindrome: {ispallindrom}");


/*Recursive String Problems Example*/



//Console.WriteLine($"Enter the String");
//var input = Console.ReadLine()!;
//while(!string.IsNullOrEmpty(input))
//{
//    //input.FunctionReverseString();
//    input.ReplaceCharacter();
//    Console.WriteLine($"Enter the String");
//    input = Console.ReadLine()!;
//}



//Console.WriteLine($"Sorted Array: {string.Join(", ", MissingElement.SortArray(new int[] { 4, 5, 2, 6, 8, 9, 7 }))}");


//Console.WriteLine(LongestSubsequenceArrayLength.LongestSubsequence(new int[] { 5, 2, 8, 6, 3, 6, 9, 5 }));

//var listCube = new List<Cube>
//{
//    new Cube { Length = 4, Width = 5, Height = 3},
//    new Cube { Length = 2, Width = 3, Height = 2},
//    new Cube { Length = 3, Width = 6, Height = 2},
//    new Cube { Length = 1, Width = 5, Height = 4},
//    new Cube { Length = 2, Width = 4, Height = 1},
//    new Cube { Length = 1, Width = 2, Height = 2}
//};

//Console.WriteLine(MaxHeight.FindMaxHeightOfCubes(listCube));


//_25HorsesProblem.FindWinner();

//ArrayProblems.FunctionReverseArray(new int[] { 1, 2, 3, 4, 5, 6});

//ArrayProblems.MissingElement(new int[] {1, 2, 3});


//ArrayProblems.RemoveDuplicateInArray(new int[] { 1, 1, 2, 2, 2, 2, 3, 3, 4, 4, 5, 5, 5, 5, 5 });

//SmallestSubstringLength.FunctionSmallestSubstringLength("abdecbcbca", "abc");


ArrayProblems.MissingElementInAArray(new int[] { 1,2,3,5,6});
