using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.DynamicProgramming
{
    public class Factorial
    {
        public static void Main(string[] args = null)
        {
            int N = 30;
            Console.WriteLine("Factorial(" + N + ") = " + Factoriial(N));
        }

        private static long[] knownFact = new long[200];
        public static long Factoriial(long n)
        {
            if (n <= 1)
                knownFact[n] = 1;
            else if (knownFact[n] == 0)
                knownFact[n] = n * Factoriial(n - 1);

            return knownFact[n];
        }
    }
}
