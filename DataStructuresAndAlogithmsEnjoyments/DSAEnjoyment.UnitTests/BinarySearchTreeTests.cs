using DSAEnjoyments.ConsoleApp.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        private BST<string, int> _bst;

        [TestInitialize]
        public void SetUp()
        {
            _bst = new BST<string, int>();
            _bst.Add("S", 1);
            _bst.Add("E", 2);
            _bst.Add("A", 3);
            _bst.Add("R", 4);
            _bst.Add("C", 5);
            _bst.Add("H", 6);
        }

        [TestMethod]
        public void Add_ShouldIncreaseCount()
        {
            int initialCount = _bst.Count;
            _bst.Add("M", 7);
            Assert.AreEqual(initialCount + 1, _bst.Count);
        }

        [TestMethod]
        public void GetValue_ShouldReturnCorrectValue()
        {
            int value = _bst.GetValue("A");
            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueForExistingKey()
        {
            bool contains = _bst.Contains("E");
            Assert.IsTrue(contains);
        }

        [TestMethod]
        public void GetKeys_InOrder_ShouldReturnKeysInCorrectOrder()
        {
            var keys = _bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            var keyList = keys.ToList();
            Assert.AreEqual("A", keyList[0]);
            Assert.AreEqual("C", keyList[1]);
            Assert.AreEqual("E", keyList[2]);
            Assert.AreEqual("H", keyList[3]);
            Assert.AreEqual("R", keyList[4]);
            Assert.AreEqual("S", keyList[5]);
        }

        [TestMethod]
        public void Delete_ShouldDecreaseCount()
        {
            int initialCount = _bst.Count;
            _bst.Delete("R");
            Assert.AreEqual(initialCount - 1, _bst.Count);
        }

        [TestMethod]
        public void Min_ShouldReturnMinKey()
        {
            string min = _bst.Min();
            Assert.AreEqual("A", min);
        }

        [TestMethod]
        public void Max_ShouldReturnMaxKey()
        {
            string max = _bst.Max();
            Assert.AreEqual("S", max);
        }

        [TestMethod]
        public void Rank_ShouldReturnCorrectRank()
        {
            int rank = _bst.Rank("R");
            Assert.AreEqual(4, rank);
        }

        [TestMethod]
        public void Select_ShouldReturnCorrectKeyForRank()
        {
            string key = _bst.Select(2);
            Assert.AreEqual("E", key);
        }

        [TestMethod]
        public void GetKeys_ShouldReturnCorrectKeysInRange()
        {
            var keys = _bst.GetKeys("C", "R");
            var keyList = keys.ToList();
            Assert.AreEqual("C", keyList[0]);
            Assert.AreEqual("E", keyList[1]);
            Assert.AreEqual("H", keyList[2]);
        }

        [TestMethod]
        public void TreeDepth_ShouldReturnCorrectDepth()
        {
            int depth = _bst.GetTreeDepth();
            Assert.AreEqual(3, depth);  // Example: based on the tree structure
        }
    }
}

