using DSAEnjoyments.ConsoleApp.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void TestFactorial_0()
        {
            long result = Factorial.Factoriial(0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestFactorial_1()
        {
            long result = Factorial.Factoriial(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestFactorial_2()
        {
            long result = Factorial.Factoriial(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestFactorial_3()
        {
            long result = Factorial.Factoriial(3);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestFactorial_4()
        {
            long result = Factorial.Factoriial(4);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void TestFactorial_5()
        {
            long result = Factorial.Factoriial(5);

            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void TestFactorial_10()
        {
            long result = Factorial.Factoriial(10);

            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void TestFactorial_20()
        {
            long result = Factorial.Factoriial(20);

            Assert.AreEqual(2432902008176640000, result);
        }

        [TestMethod]
        public void TestFactorial_CacheMechanism()
        {
            // Test if the memoization cache is working correctly.
            long result1 = Factorial.Factoriial(5);
            long result2 = Factorial.Factoriial(5); // This should be retrieved from cache.

            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestFactorial_RecursiveEfficiency()
        {
            long result = Factorial.Factoriial(10);

            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void TestFactorial_SequenceConsistency()
        {
            long result1 = Factorial.Factoriial(6);
            long result2 = Factorial.Factoriial(7);

            Assert.AreEqual(result2, result1 * 7);
        }

        [TestMethod]
        public void TestFactorial_RecursiveBaseCase()
        {
            long result = Factorial.Factoriial(1);

            Assert.AreEqual(1, result);
        }
    }
}
