namespace DataStructureAlgorithms
{
    public static class RecursionExamples
    {
        public static int AddNumbers(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            var previousValue = n + AddNumbers(n - 1);
            return previousValue;
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            var previousValue = n * Factorial(n - 1);
            return previousValue;
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            var previousValue = Fibonacci(n - 1) + Fibonacci(n - 2);
            return previousValue;
        }

        public static int Power(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            var previousValue = x * Power(x, n - 1);
            return previousValue;
        }
    }
}
