using DSAEnjoyments.ConsoleApp.BucketSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class BucketSortEnjoymentTests
    {
        [TestMethod]
        public void TestBucketSort_Empty_Array()
        {
            int[] input = { };
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 3);

            Assert.AreEqual(0, input.Length);
        }

        [TestMethod]
        public void TestBucketSort_Single_Element_Array()
        {
            int[] input = { 1 };
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 2);

            Assert.AreEqual(1, input[0]);
        }

        [TestMethod]
        public void TestBucketSort_Large_Random_Array()
        {
            int[] input = new int[256];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 8);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Small_Bucket_Count()
        {
            int[] input = { 9, 1, 7, 3, 5, 8, 6, 4, 2, 0 };
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 2);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Large_Bucket_Count()
        {
            int[] input = { 9, 1, 7, 3, 5, 8, 6, 4, 2, 0 };
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 10);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Sort_Identical_Values()
        {
            int[] input = { 5, 5, 5, 5, 5 };
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 3);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Large_Random_Values()
        {
            int[] input = new int[512];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 1000);

            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 12);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Sort_Large_Identical_Values()
        {
            int[] input = new int[512];
            Array.Fill(input, 7);
            BucketSortEnjoyment.BucketSort(input, 0, input.Length, 10);

            Assert.IsTrue(IsSorted(input));
        }

        [TestMethod]
        public void TestBucketSort_Large_Test_Multiple_Runs()
        {
            for (int t = 0; t < 50; t++)
            {
                int[] input = new int[128];
                Random rnd = new Random();
                for (int i = 0; i < input.Length; i++)
                    input[i] = rnd.Next(1, 1000);

                BucketSortEnjoyment.BucketSort(input, 0, input.Length, 8);
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
