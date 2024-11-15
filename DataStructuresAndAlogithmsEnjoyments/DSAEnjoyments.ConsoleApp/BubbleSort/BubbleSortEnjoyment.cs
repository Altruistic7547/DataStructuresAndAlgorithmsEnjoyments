using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.BubbleSort
{
    public class BubbleSortEnjoyment
    {
        public static void Main(string[] args = null)
        {
            ExampleBubbleSort();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void BubbleSort(int[] A)
        {
            int l = 0, r = A.Length - 1;

            for (int i = l; i < r; i++)
            {
                for (int j = r; j > i; j--)
                {
                    if (A[j - 1] > A[j])
                        Swap(ref A[j - 1], ref A[j]);
                }
            }
        }

        private static void ExampleBubbleSort()
        {
            const int N = 100;
            Random rnd = new Random();
            int[] A = new int[N];
            for (int i = 0; i < A.Length; i++)
                A[i] = rnd.Next(1, N);

            foreach (var item in A)
                Console.Write(item + " ");

            BubbleSort(A);

            Console.WriteLine("\nSorted:");
            foreach (var item in A)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }

}
