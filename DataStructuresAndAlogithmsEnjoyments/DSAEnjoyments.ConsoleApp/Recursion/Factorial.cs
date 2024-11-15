using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.Recursion
{
    internal class Factorial
    {
        public static void Main(string[] args = null)
        {
            int N = 20;
            int res = DoFactorial(N);
            Console.WriteLine(N + "! = " + res);
        }

        private static int DoFactorial(int N)
        {
            if (N == 0)
                return 1;

            return N * DoFactorial(N - 1);
        }

    }
}
