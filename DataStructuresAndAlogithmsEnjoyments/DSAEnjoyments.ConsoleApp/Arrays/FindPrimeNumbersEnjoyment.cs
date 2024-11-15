using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.Arrays
{
    public class FindPrimeNumbersEnjoyment
    {
        public static void Main(string[] args = null)
        {
            FindPrimeNumbers();
        }

        private static void FindPrimeNumbers()
        {
            // The goal of this program is to set A[i] to 1 if i is prime, and to 0 otherwise
            const int N = 1000;
            int[] A = new int[N];

            for (int i = 2; i < N; i++)
                A[i] = 1;

            for (int i = 2; i < N; i++)
            {
                if (A[i] == 1)
                {
                    for (int j = i; j * i < N; j++)
                        A[i * j] = 0;
                }
            }

            for (int i = 2; i < N; i++)
            {
                if (A[i] == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
