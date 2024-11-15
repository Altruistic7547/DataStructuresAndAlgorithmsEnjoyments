using DSAEnjoyments.ConsoleApp.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class BubbleSortEnjoymentTests
    {
        [TestMethod]
        public void TestBubbleSort_Ascending_Order_Sorted_Array()
        {
            int[] input = { 5, 3, 8, 6, 2, 7, 4, 1 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Descending_Order_Sorted_Array()
        {
            int[] input = { 8, 7, 6, 5, 4, 3, 2, 1 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Empty_Array()
        {
            int[] input = { };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void TestBubbleSort_Single_Element_Array()
        {
            int[] input = { 1 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.AreEqual(1, input[0]);
        }

        [TestMethod]
        public void TestBubbleSort_Already_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Large_Random_Array()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Large_Descending_Array()
        {
            int[] input = { 1000, 999, 998, 997, 996, 995, 994, 993, 992, 991, 990 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Sort_Identical_Values()
        {
            int[] input = { 5, 5, 5, 5, 5 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Random_Array()
        {
            int[] input = { 9, 1, 7, 3, 5, 8, 6, 4, 2, 0 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Large_Identical_Values()
        {
            int[] input = new int[512];
            Array.Fill(input, 7);
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBubbleSort_Null_Array()
        {
            int[] input = null;
            BubbleSortEnjoyment.BubbleSort(input);
        }

        [TestMethod]
        public void TestBubbleSort_Multiple_Random_Test_Cases()
        {
            for (int t = 0; t < 100; t++)
            {
                int[] input = new int[128];
                Random rnd = new Random();
                for (int i = 0; i < input.Length; i++)
                    input[i] = rnd.Next(1, 1000);

                BubbleSortEnjoyment.BubbleSort(input);
                Assert.IsTrue(IsSorted(input));
            }
        }

        [TestMethod]
        public void TestBubbleSort_Alternating_High_Low()
        {
            int[] input = { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBubbleSort_Large_Test()
        {
            int[] input = new int[1024];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BubbleSortEnjoyment.BubbleSort(input);

            Assert.IsTrue(IsSorted(input));
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
