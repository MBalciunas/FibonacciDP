using System;
using System.Collections.Generic;
namespace FibonacciDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for fibonacci sequence");
            var n = Convert.ToUInt64(Console.ReadLine());
            ulong[] memo = new ulong[n];
            Console.WriteLine(Fibonacci(n, memo));
        }

        static ulong Fibonacci(ulong n, ulong[] memo)
        {
            if (n <= 0)
                return 0;
            else if (n <= 2)
                return 1;

            else if (memo[n - 1] == 0)
                memo[n - 1] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);

            return memo[n - 1];
        }
    }
}
