using DSAEnjoyments.ConsoleApp.DevideAndConquer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class FindMaxValueTests
    {
        [TestMethod]
        public void TestMax_Ascending_Order()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMax_Descending_Order()
        {
            int[] input = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMax_All_Equal_Values()
        {
            int[] input = { 5, 5, 5, 5, 5, 5, 5 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMax_Mixed_Values()
        {
            int[] input = { 1, 3, 5, 7, 6, 2, 4, 8 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMax_Single_Element_Array()
        {
            int[] input = { 10 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMax_Large_Array()
        {
            int[] input = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 10000);

            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.IsTrue(result >= 1 && result <= 10000);
        }

        [TestMethod]
        public void TestMax_Negative_Values()
        {
            int[] input = { -5, -10, -3, -7, -1, -8 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMax_Large_Numbers()
        {
            int[] input = { 1000000, 5000000, 2000000, 7000000, 3000000 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(7000000, result);
        }

        [TestMethod]
        public void TestMax_Zero_and_Negative_Values()
        {
            int[] input = { 0, -5, -10, -3, -1 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMax_Multiple_Occurrences_Of_Max()
        {
            int[] input = { 1, 3, 7, 7, 5, 4, 7, 2 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMax_Very_Large_Array()
        {
            int[] input = new int[10000];
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
                input[i] = rnd.Next(1, 100000);

            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.IsTrue(result >= 1 && result <= 100000);
        }

        [TestMethod]
        public void TestMax_With_Repeat_Max_At_The_End()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            int result = FindMaxValue.Max(input, 0, input.Length - 1);

            Assert.AreEqual(9, result);
        }
    }

}
