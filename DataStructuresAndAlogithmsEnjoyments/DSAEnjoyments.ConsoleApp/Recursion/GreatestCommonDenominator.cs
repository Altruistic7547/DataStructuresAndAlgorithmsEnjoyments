using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.Recursion
{
    internal class GreatestCommonDenominator
    {
        public static void Main(string[] args = null)
        {
            int N = 20;
            int M = 28;
            int res = GCD(M, N);
            Console.WriteLine("GCD(" + M + ", " + N + ") = " + res);
        }

        private static int GCD(int m, int n)
        {
            // Find the greatest common divisors of 2 ints
            if (n == 0)
                return m;

            return GCD(n, m % n);
        }

    }
}
