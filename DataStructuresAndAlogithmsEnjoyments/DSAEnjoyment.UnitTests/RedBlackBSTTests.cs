using DSAEnjoyments.ConsoleApp.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class RedBlackBSTTests
    {
        private RedBlackBST<string, int> redBlackBST;

        [TestInitialize]
        public void Setup()
        {
            redBlackBST = new RedBlackBST<string, int>();
        }

        [TestMethod]
        public void Add_ShouldIncreaseCount()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            Assert.AreEqual(2, redBlackBST.Count);
        }

        [TestMethod]
        public void Add_ShouldThrowArgumentNullException_WhenKeyIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => redBlackBST.Add(null, 1));
        }

        [TestMethod]
        public void Contains_ShouldReturnTrue_WhenKeyExists()
        {
            redBlackBST.Add("A", 1);
            Assert.IsTrue(redBlackBST.Contains("A"));
        }

        [TestMethod]
        public void GetValue_ShouldReturnCorrectValue_WhenKeyExists()
        {
            redBlackBST.Add("A", 1);
            Assert.AreEqual(1, redBlackBST.GetValue("A"));
        }

        [TestMethod]
        public void GetValue_ShouldReturnDefault_WhenKeyDoesNotExist()
        {
            Assert.AreEqual(0, redBlackBST.GetValue("A"));
        }

        [TestMethod]
        public void Delete_ShouldThrowArgumentNullException_WhenKeyIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => redBlackBST.Delete(null));
        }

        [TestMethod]
        public void DeleteMin_ShouldDecreaseCount()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            redBlackBST.DeleteMin();
            Assert.AreEqual(1, redBlackBST.Count);
        }

        [TestMethod]
        public void DeleteMax_ShouldDecreaseCount()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            redBlackBST.DeleteMax();
            Assert.AreEqual(1, redBlackBST.Count);
        }

        [TestMethod]
        public void Min_ShouldReturnSmallestKey()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            Assert.AreEqual("A", redBlackBST.Min());
        }

        [TestMethod]
        public void Max_ShouldReturnLargestKey()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            Assert.AreEqual("B", redBlackBST.Max());
        }

        [TestMethod]
        public void GetTreeDepth_ShouldReturnCorrectDepth()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            redBlackBST.Add("C", 3);
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnTrue_WhenTreeIsEmpty()
        {
            Assert.IsTrue(redBlackBST.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnFalse_WhenTreeIsNotEmpty()
        {
            redBlackBST.Add("A", 1);
            Assert.IsFalse(redBlackBST.IsEmpty());
        }

        [TestMethod]
        public void GetKeys_ShouldReturnKeysInInOrderTraversal()
        {
            redBlackBST.Add("A", 1);
            redBlackBST.Add("B", 2);
            redBlackBST.Add("C", 3);

            var keys = redBlackBST.GetKeys(RedBlackBST<string, int>.TraversalMethod.InOrder);

            CollectionAssert.AreEqual(new List<string> { "A", "B", "C" }, new List<string>(keys));
        }

        [TestMethod]
        public void Delete_ShouldThrowInvalidOperationException_WhenTreeIsEmpty()
        {
            Assert.ThrowsException<InvalidOperationException>(() => redBlackBST.DeleteMin());
        }
    }
}

