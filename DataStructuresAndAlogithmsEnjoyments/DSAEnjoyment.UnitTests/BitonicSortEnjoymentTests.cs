using DSAEnjoyments.ConsoleApp.BitonicSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class BitonicSortEnjoymentTests
    {
        [TestMethod]
        public void TestBitonicSort_Ascending_Order_Sorted_Array()
        {
            int[] input = { 5, 3, 8, 6, 2, 7, 4, 1 };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBitonicSort_Descending_Order_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Descending);

            Assert.IsTrue(IsSorted(input, descending: true));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestBitonicSort_Invalid_Length()
        {
            int[] input = { 1, 2, 3 };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length);
        }

        [TestMethod]
        public void TestBitonicSort_Large_Array_Ascending_Order()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBitonicSort_Large_Array_Descending_Order()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Descending);

            Assert.IsTrue(IsSorted(input, descending: true));
        }

        [TestMethod]
        public void TestBitonicSort_Already_Sorted_Array()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBitonicSort_Random_Large_Array_Descending_Order()
        {
            int[] input = new int[512];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Descending);

            Assert.IsTrue(IsSorted(input, descending: true));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestBitonicSort_Empty_Array()
        {
            int[] input = { };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);
        }

        [TestMethod]
        public void TestBitonicSort_Single_Element_Array()
        {
            int[] input = { 1 };
            BitonicSortEnjoyment.BitonicSort(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);

            Assert.AreEqual(1, input[0]);
        }

        [TestMethod]
        public void TestBitonicSort_CompareAndSwap()
        {
            int[] input = { 5, 10 };
            BitonicSortEnjoyment.CompareAndSwap(input, 0, 1, BitonicSortEnjoyment.Direction.Ascending);

            Assert.AreEqual(5, input[0]);
            Assert.AreEqual(10, input[1]);

            BitonicSortEnjoyment.CompareAndSwap(input, 0, 1, BitonicSortEnjoyment.Direction.Descending);

            Assert.AreEqual(10, input[0]);
            Assert.AreEqual(5, input[1]);
        }

        private bool IsSorted(int[] A, bool descending = false)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (descending)
                {
                    if (A[i] > A[i - 1])
                        return false;
                }
                else
                {
                    if (A[i] < A[i - 1])
                        return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void TestBitonicMerge_Ascending_Order()
        {
            int[] input = { 5, 3, 8, 6, 2, 7, 4, 1 };
            BitonicSortEnjoyment.BitonicMerge(input, 0, input.Length, BitonicSortEnjoyment.Direction.Ascending);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBitonicMerge_Descending_Order()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BitonicSortEnjoyment.BitonicMerge(input, 0, input.Length, BitonicSortEnjoyment.Direction.Descending);

            Assert.IsTrue(IsSorted(input, descending: true));
        }
    }
}
