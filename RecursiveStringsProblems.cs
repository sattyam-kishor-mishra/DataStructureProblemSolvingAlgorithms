using System.Data;
using System.Runtime.CompilerServices;

namespace DataStructureAlgorithms
{
    public static class RecursiveStringsProblems
    {
        public static void FunctionReverseString(this string s)
        {
            Console.WriteLine($"Calling back the function");
            if (s.Length == 0)
            {
                Console.WriteLine($"Stop the recursion : {s}");
                return;
            }


            Console.WriteLine($"Main String : {s}");
            var ros = s.Substring(1);
            Console.WriteLine($"string from first character remove : {ros}");
            Console.WriteLine($"Before calling the Recusrively : {ros}");
            FunctionReverseString(ros);
            Console.WriteLine($"After calling the Recusrively : {ros}");
            Console.WriteLine($"After calling the Recusrively First character : {s[0]}");
            Console.WriteLine(s[0]);
        }

        public static void ReplaceCharacter(this string s)
        {
            if (string.IsNullOrEmpty(s))
            { return; }

            if (s[0] == 'p' && s[1] == 'i')
            {
                Console.WriteLine("3.14");
                ReplaceCharacter(s.Substring(2));
            }
            else
            {
                Console.WriteLine(s[0]);
                ReplaceCharacter(s.Substring(1));
            }
        }
        

    }
}
