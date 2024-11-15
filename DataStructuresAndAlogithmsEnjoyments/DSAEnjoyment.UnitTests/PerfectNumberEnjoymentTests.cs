using DSAEnjoyments.ConsoleApp.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyment.UnitTests
{
    [TestClass]
    public class PerfectNumberEnjoymentTests
    {
        [TestMethod]
        public void Test_PerfectBalance_With_KeyValuePair_List()
        {
            // Arrange
            var keyValuePairs = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("B", 2),
            new KeyValuePair<string, int>("A", 1),
            new KeyValuePair<string, int>("C", 3)
        };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keyValuePairs);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(3, keys.Count());
            Assert.AreEqual("A", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Single_Element_KeyValuePair_List()
        {
            // Arrange
            var keyValuePairs = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("X", 1)
        };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keyValuePairs);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(1, keys.Count());
            Assert.AreEqual("X", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Array_Of_Strings()
        {
            // Arrange
            string[] keysArr = new string[] { "B", "A", "C" };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keysArr);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(3, keys.Count());
            Assert.AreEqual("A", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Single_Element_String_Array()
        {
            // Arrange
            string[] keysArr = new string[] { "X" };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keysArr);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(1, keys.Count());
            Assert.AreEqual("X", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Large_Number_Of_Elements()
        {
            // Arrange
            var keyValuePairs = new List<KeyValuePair<string, int>>();
            for (int i = 1; i <= 1000; i++)
            {
                keyValuePairs.Add(new KeyValuePair<string, int>(i.ToString(), i));
            }
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keyValuePairs);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(1000, keys.Count());
            Assert.AreEqual("1", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Reverse_Sorted_KeyValuePairs()
        {
            // Arrange
            var keyValuePairs = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("D", 4),
            new KeyValuePair<string, int>("C", 3),
            new KeyValuePair<string, int>("B", 2),
            new KeyValuePair<string, int>("A", 1)
        };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keyValuePairs);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(4, keys.Count());
            Assert.AreEqual("A", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Already_Sorted_String_Array()
        {
            // Arrange
            string[] keysArr = new string[] { "A", "B", "C" };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keysArr);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(3, keys.Count());
            Assert.AreEqual("A", keys.First());
        }

        [TestMethod]
        public void Test_PerfectBalance_With_Duplicate_Values()
        {
            // Arrange
            var keyValuePairs = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("A", 1),
            new KeyValuePair<string, int>("B", 2),
            new KeyValuePair<string, int>("A", 1)
        };
            BST<string, int> bst = new BST<string, int>();

            // Act
            PerfectNumberEnjoyment.PerfectBalance(bst, keyValuePairs);

            // Assert
            var keys = bst.GetKeys(BST<string, int>.TraversalMethod.InOrder);
            Assert.AreEqual(2, keys.Count());
            Assert.AreEqual("A", keys.First());
        }
    }
}

