using DSAEnjoyments.ConsoleApp.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class EggDropProblemTests
    {
        [TestMethod]
        public void TestEggDrop_2Eggs_100Floors()
        {
            int result = EggDropProblem.EggDrop(100, 2);

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void TestEggDrop_1Egg_100Floors()
        {
            int result = EggDropProblem.EggDrop(100, 1);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestEggDrop_2Eggs_1Floor()
        {
            int result = EggDropProblem.EggDrop(1, 2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestEggDrop_1Egg_1Floor()
        {
            int result = EggDropProblem.EggDrop(1, 1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestEggDrop_2Eggs_3Floors()
        {
            int result = EggDropProblem.EggDrop(3, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestEggDrop_3Eggs_10Floors()
        {
            int result = EggDropProblem.EggDrop(10, 3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestEggDrop_3Eggs_100Floors()
        {
            int result = EggDropProblem.EggDrop(100, 3);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestEggDrop_5Eggs_10Floors()
        {
            int result = EggDropProblem.EggDrop(10, 5);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestEggDrop_3Eggs_5Floors()
        {
            int result = EggDropProblem.EggDrop(5, 3);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestEggDrop_4Eggs_6Floors()
        {
            int result = EggDropProblem.EggDrop(6, 4);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestEggDrop_4Eggs_10Floors()
        {
            int result = EggDropProblem.EggDrop(10, 4);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestEggDrop_2Eggs_5Floors()
        {
            int result = EggDropProblem.EggDrop(5, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestEggDrop_2Eggs_10Floors()
        {
            int result = EggDropProblem.EggDrop(10, 2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestEggDrop_1Egg_2Floors()
        {
            int result = EggDropProblem.EggDrop(2, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestEggDrop_ShowEggDropMatrix()
        {
            int result = EggDropProblem.EggDrop(5, 3, showEggDropMatrix: true);

            // The expected matrix is printed in the console
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestEggDrop_GetSelectedFloors()
        {
            int result = EggDropProblem.EggDrop(10, 2, getSelectedFloors: true);

            // Check that the selected floors are being printed
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestEggDrop_LargeNumberOfFloors()
        {
            int result = EggDropProblem.EggDrop(1000, 5);

            Assert.IsTrue(result > 0);
        }
    }
}
