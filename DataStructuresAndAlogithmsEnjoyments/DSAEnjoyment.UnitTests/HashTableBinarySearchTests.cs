using DSAEnjoyments.ConsoleApp.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class HashTableBinarySearchTests
    {
        [TestMethod]
        public void TestAdd_NewKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            Assert.AreEqual(1, hashTable.Count);
            Assert.AreEqual(1, hashTable.GetValue("A"));
        }

        [TestMethod]
        public void TestAdd_UpdateExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("A", 2);

            Assert.AreEqual(1, hashTable.Count);
            Assert.AreEqual(2, hashTable.GetValue("A"));
        }

        [TestMethod]
        public void TestContains_ExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            bool result = hashTable.Contains("A");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestContains_NonExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            bool result = hashTable.Contains("B");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestGetValue_ExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            var result = hashTable.GetValue("A");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestGetValue_NonExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            var result = hashTable.GetValue("B");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestRemove_ExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Remove("A");

            Assert.AreEqual(0, hashTable.Count);
            Assert.IsFalse(hashTable.Contains("A"));
        }

        [TestMethod]
        public void TestRemove_NonExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            hashTable.Remove("B");

            Assert.AreEqual(1, hashTable.Count);
            Assert.IsTrue(hashTable.Contains("A"));
        }

        [TestMethod]
        public void TestFloor_ExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            var result = hashTable.Floor("B");

            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void TestFloor_KeyNotFound()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("C", 3);

            var result = hashTable.Floor("B");

            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestCeiling_ExistingKey()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            var result = hashTable.Ceilling("B");

            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void TestCeiling_KeyNotFound()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("C", 3);

            var result = hashTable.Ceilling("B");

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void TestSelect_ValidRank()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            var result = hashTable.Select(1);

            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void TestSelect_InvalidRank()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);

            Assert.ThrowsException<InvalidOperationException>(() => hashTable.Select(2));
        }

        [TestMethod]
        public void TestMin()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);

            var result = hashTable.Min();

            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void TestMax()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);

            var result = hashTable.Max();

            Assert.AreEqual("B", result);
        }

        [TestMethod]
        public void TestResize_Expansion()
        {
            var hashTable = new HashTableBinarySearch<string, int>(2);
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            Assert.AreEqual(3, hashTable.Count);
            Assert.AreEqual(3, hashTable.GetValue("C"));
        }

        [TestMethod]
        public void TestResize_Shrinking()
        {
            var hashTable = new HashTableBinarySearch<string, int>(8);
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Remove("A");

            Assert.AreEqual(1, hashTable.Count);
        }

        [TestMethod]
        public void TestGetKeys_Range()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);
            hashTable.Add("D", 4);

            var keys = hashTable.GetKeys("B", "C").ToList();

            CollectionAssert.AreEqual(new List<string> { "B", "C" }, keys);
        }

        [TestMethod]
        public void TestGetKeys_AllKeys()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            var keys = hashTable.GetKeys().ToList();

            CollectionAssert.AreEqual(new List<string> { "A", "B", "C" }, keys);
        }

        [TestMethod]
        public void TestRank()
        {
            var hashTable = new HashTableBinarySearch<string, int>();
            hashTable.Add("A", 1);
            hashTable.Add("B", 2);
            hashTable.Add("C", 3);

            int rank = hashTable.Rank("B");

            Assert.AreEqual(1, rank);
        }
    }
}
