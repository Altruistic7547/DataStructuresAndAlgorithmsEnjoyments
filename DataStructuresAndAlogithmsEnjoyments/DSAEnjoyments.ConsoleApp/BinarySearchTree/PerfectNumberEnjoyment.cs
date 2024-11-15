using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.BinarySearchTree
{
    public class PerfectNumberEnjoyment
    {
        public static void Main(string[] args = null)
        {
            ExamplePerfectBalance();
        }

        private static void ExamplePerfectBalance()
        {
            Console.WriteLine("***ExamplePerfectBalanceKeyValuePairsList***");
            List<KeyValuePair<string, int>> keyValuePairs = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("H", 6),
                new KeyValuePair<string, int>("C", 3),
                new KeyValuePair<string, int>("A", 2),
                new KeyValuePair<string, int>("E", 1),
                new KeyValuePair<string, int>("S", 9),
                new KeyValuePair<string, int>("R", 8),
                new KeyValuePair<string, int>("X", 7)
            };

            Console.WriteLine("Input:");
            foreach (var item in keyValuePairs)
                Console.WriteLine("(" + item.Key + ", " + item.Value + ")");

            BST<string, int> bst = new BST<string, int>();
            PerfectBalance(bst, keyValuePairs);

            Console.WriteLine("\nIn Order Traversal: ");
            foreach (var item in bst.GetKeys(BST<string, int>.TraversalMethod.InOrder))
                Console.WriteLine("(" + item + ", " + bst.GetValue(item) + ")");

            string[] keysArr = new string[] { "H", "C", "A", "E", "S", "R", "X" };

            Console.WriteLine("\n***ExamplePerfectBalanceKeysArray***");
            Console.WriteLine("Input:");
            foreach (var item in keysArr)
                Console.WriteLine(item);

            BST<string, int> bst2 = new BST<string, int>();
            PerfectBalance(bst2, keysArr);

            Console.WriteLine("\nIn Order Traversal: ");
            foreach (var item in bst2.GetKeys(BST<string, int>.TraversalMethod.InOrder))
                Console.WriteLine("(" + item + ", " + bst2.GetValue(item) + ")");
        }

        /// <summary>
        ///  Inserts a set of key-value pairs into an initially empty BST such that the tree produced is equivalent to binary search, 
        ///  (The sequence of compares done in the search for any key in the BST is the same as the sequence of compares used by binary search for the same set of key-value pairs)
        /// </summary>
        public static void PerfectBalance(BST<string, int> bst, List<KeyValuePair<string, int>> input)
        {
            if (input.Count == 0) return;

            input.Sort((x, y) => x.Key.CompareTo(y.Key));
            AddToBSTPerfect(bst, input, 0, input.Count);
        }

        public static void AddToBSTPerfect(BST<string, int> bst, List<KeyValuePair<string, int>> input, int l, int r)
        {
            if (r - l < 1) return;
            else if (r - l == 1)
            {
                bst.Add(input[l].Key, input[l].Value);
                return;
            }

            int mid = (l + r) / 2;
            bst.Add(input[mid].Key, input[mid].Value);

            AddToBSTPerfect(bst, input, l, mid);
            AddToBSTPerfect(bst, input, mid + 1, r);
        }

        /// <summary>
        ///  Inserts a set of keys into an initially empty BST such that the tree produced is equivalent to binary search, 
        ///  (The sequence of compares done in the search for any key in the BST is the same as the sequence of compares used by binary search for the same set of keys)
        /// </summary>
        public static void PerfectBalance(BST<string, int> bst, string[] input)
        {
            if (input.Length == 0) return;

            Array.Sort(input);
            AddToBSTPerfect(bst, input, 0, input.Length);
        }

        public static void AddToBSTPerfect(BST<string, int> bst, string[] input, int l, int r)
        {
            if (r - l < 1) return;
            else if (r - l == 1)
            {
                bst.Add(input[l], l);
                return;
            }

            int mid = (l + r) / 2;
            bst.Add(input[mid], mid);

            AddToBSTPerfect(bst, input, l, mid);
            AddToBSTPerfect(bst, input, mid + 1, r);
        }
    }

}
