using DSAEnjoyments.ConsoleApp.CountingSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class CountingSortEnjoymentTests
    {
        [TestMethod]
        public void TestCountingSort_Ascending_Order_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Descending_Order_Sorted_Array()
        {
            int[] input = { 6, 5, 4, 3, 2, 1 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Single_Element_Array()
        {
            int[] input = { 5 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.AreEqual(5, result[0]);
        }

        [TestMethod]
        public void TestCountingSort_Already_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Large_Random_Array()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Small_Array()
        {
            int[] input = { 9, 1, 7, 3, 5 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Sort_Identical_Values()
        {
            int[] input = { 7, 7, 7, 7, 7 };
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Large_Range_Values()
        {
            int[] input = new int[512];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(0, 10000);

            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Sort_Large_Identical_Values()
        {
            int[] input = new int[512];
            Array.Fill(input, 7);
            int[] result = CountingSortEnjoyment.CountingSort(input);

            Assert.IsTrue(IsSorted(result));
        }

        [TestMethod]
        public void TestCountingSort_Multiple_Runs()
        {
            for (int t = 0; t < 50; t++)
            {
                int[] input = new int[128];
                Random rnd = new Random();
                for (int i = 0; i < input.Length; i++)
                    input[i] = rnd.Next(1, 1000);

                int[] result = CountingSortEnjoyment.CountingSort(input);
                Assert.IsTrue(IsSorted(result));
            }
        }

        private bool IsSorted(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i - 1])
                    return false;
            }
            return true;
        }
    }
}
