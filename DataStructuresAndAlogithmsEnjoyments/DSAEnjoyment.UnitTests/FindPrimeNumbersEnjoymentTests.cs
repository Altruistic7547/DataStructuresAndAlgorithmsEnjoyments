using DSAEnjoyments.ConsoleApp.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class FindPrimeNumbersEnjoymentTests
    {
        // Redirects console output for testing.
        private StringWriter _consoleOutput;

        [TestInitialize]
        public void SetUp()
        {
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        [TestCleanup]
        public void TearDown()
        {
            _consoleOutput.Dispose();
        }

        [TestMethod]
        public void FindPrimeNumbers_ShouldPrintCorrectPrimes_Upto1000()
        {
            // Act
            FindPrimeNumbersEnjoyment.Main(null);

            // Assert
            var output = _consoleOutput.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Validate known prime numbers
            Assert.IsTrue(Array.Exists(output, p => p == "2"));
            Assert.IsTrue(Array.Exists(output, p => p == "3"));
            Assert.IsTrue(Array.Exists(output, p => p == "997"));

            // Validate known non-prime numbers (not appearing)
            Assert.IsFalse(Array.Exists(output, p => p == "4"));
            Assert.IsFalse(Array.Exists(output, p => p == "1000"));
        }

        [TestMethod]
        public void FindPrimeNumbers_NoPrimesBelowTwo()
        {
            // Act
            FindPrimeNumbersEnjoyment.Main(null);

            // Assert
            var output = _consoleOutput.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Assert.IsFalse(Array.Exists(output, p => int.Parse(p) < 2));
        }

        [TestMethod]
        public void FindPrimeNumbers_ShouldHandleLargeRange_PerformanceTest()
        {
            // This test ensures the performance does not degrade significantly.
            // Note: MSTest may not be ideal for performance tests, but a simple timing check is possible.
            var startTime = DateTime.Now;

            // Act
            FindPrimeNumbersEnjoyment.Main(null);

            var endTime = DateTime.Now;
            var duration = endTime - startTime;

            // Assert (Ensure execution is within 1 second)
            Assert.IsTrue(duration.TotalSeconds < 1, "Execution time exceeded the limit.");
        }
    }
}
