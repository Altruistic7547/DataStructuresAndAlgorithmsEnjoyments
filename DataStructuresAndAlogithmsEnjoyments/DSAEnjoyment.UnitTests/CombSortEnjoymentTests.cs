using DSAEnjoyments.ConsoleApp.CombSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class CombSortEnjoymentTests
    {
        [TestMethod]
        public void TestCombSort_Ascending_Order_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Descending_Order_Sorted_Array()
        {
            int[] input = { 6, 5, 4, 3, 2, 1 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Empty_Array()
        {
            int[] input = { };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void TestCombSort_Single_Element_Array()
        {
            int[] input = { 5 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.AreEqual(5, input[0]);
        }

        [TestMethod]
        public void TestCombSort_Already_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Large_Random_Array()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Small_Array()
        {
            int[] input = { 9, 1, 7, 3, 5 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Sort_Identical_Values()
        {
            int[] input = { 7, 7, 7, 7, 7 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Negative_Values()
        {
            int[] input = { -5, -3, -8, -6, -2, -7, -4, -1 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Large_Random_Values()
        {
            int[] input = new int[512];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Sort_Large_Identical_Values()
        {
            int[] input = new int[512];
            Array.Fill(input, 7);
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Large_Test()
        {
            int[] input = new int[1024];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Sort_Alternate_Values()
        {
            int[] input = { 1, 6, 2, 5, 3, 4 };
            CombSortEnjoyment.CombSort(input, 0, input.Length);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestCombSort_Multiple_Runs()
        {
            for (int t = 0; t < 50; t++)
            {
                int[] input = new int[128];
                Random rnd = new Random();
                for (int i = 0; i < input.Length; i++)
                    input[i] = rnd.Next(1, 1000);

                CombSortEnjoyment.CombSort(input, 0, input.Length);
                Assert.IsTrue(IsSorted(input));
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
