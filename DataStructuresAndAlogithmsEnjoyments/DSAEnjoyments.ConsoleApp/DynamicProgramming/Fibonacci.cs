using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.DynamicProgramming
{
    public class Fibonacci
    {
        public static void Main(string[] args = null)
        {
            ExampleCalculateFibonacci();
        }

        // Dynamic programming reduces the running time of a recursive function
        // to be at most the time required to evaluate the function for all 
        // arguments less than or equal to the given argument, treating the cost
        // of a recursive call as constant
        private static long[] knownF = new long[200];
        private static long MakeFibonacci(long n)
        {
            // Time complexity O(n) as O(2n) as the leftmost recursion path is taking O(n) and then all other calls are O(n)
            // Space complexity is O(n) as the maximum stack depth is n + 1 and knownF array take O(n) space => Space complexity is O(n + n) = O(n)
            if (n <= 1)
                knownF[n] = 1;
            else if (knownF[n] == 0)
                knownF[n] = MakeFibonacci(n - 1) + MakeFibonacci(n - 2);

            return knownF[n];
        }

        private static void ExampleCalculateFibonacci()
        {
            Console.Write("Enter a number: ");
            long N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Fibonacci(" + N + ") = " + MakeFibonacci(N));
        }
    }
}
