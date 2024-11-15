using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.HashTable
{
    internal class HashTableSepChaining
    {
        public static void Main(string[] args = null)
        {
            HashTableSepChaining<string, int> hashTable = new HashTableSepChaining<string, int>();
            hashTable.Add("S", 1);
            hashTable.Add("E", 2);
            hashTable.Add("A", 3);
            hashTable.Add("R", 4);
            hashTable.Add("C", 5);
            hashTable.Add("H", 6);

            Console.WriteLine("Count: " + hashTable.Count);
            Console.WriteLine("\nKeys: ");
            foreach (var k in hashTable.GetKeys())
                Console.Write(k + " ");
            Console.WriteLine("\nValues: ");
            foreach (var k in hashTable.GetKeys())
                Console.Write(hashTable.GetValue(k) + " ");

            Console.WriteLine();
            string key = "M";
            Console.WriteLine("\nContain key " + key + "? " + hashTable.Contains(key));
            key = "S";
            Console.WriteLine("\nContain key " + key + "? " + hashTable.Contains(key));
        }
    }

    /// <summary>
    /// A separate chaining Hash table
    /// </summary>
    class HashTableSepChaining<TKey, TValue>
    {
        private static readonly int INIT_CAPACITY = 3;
        private StackKV<TKey, TValue>[] KVStacks;
        /// <summary>
        /// Number of key-value pairs
        /// </summary>
        public int Count { get; protected set; }
        private int Size { get; set; } // HashTable size

        public HashTableSepChaining() : this(INIT_CAPACITY) { }

        public HashTableSepChaining(int size)
        {
            Size = size;
            KVStacks = new StackKV<TKey, TValue>[Size];
            for (int i = 0; i < Size; i++)
            {
                KVStacks[i] = new StackKV<TKey, TValue>();
            }
        }

        private int Hash(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % Size;
        }

        public bool Contains(TKey key)
        {
            if (key == null) throw new ArgumentNullException();

            try
            {
                GetValue(key);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public TValue GetValue(TKey key)
        {
            if (key == null) throw new ArgumentNullException();
            int index = Hash(key);
            return KVStacks[index].GetValue(key);
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null) throw new ArgumentNullException();
            if (value == null) return; // HANDLE MORE HERE: DELETE NODE With the key = key

            // Double the size of HashTable if avg length of list >= 10
            if (Count >= 10 * Size) Resize(2 * Size);

            int index = Hash(key);
            if (!KVStacks[index].Contains(key)) Count++;
            KVStacks[index].Add(key, value);
        }

        public void Remove(TKey key)
        {
            if (key == null) throw new ArgumentNullException();
            int index = Hash(key);
            if (!KVStacks[index].Contains(key)) Count--;
            KVStacks[index].Remove(key);

            if (Size > INIT_CAPACITY && Count <= 2 * Size) Resize(Size / 2);
        }

        /// <summary>
        /// Returns all keys in the HashTable
        /// </summary>
        public IEnumerable<TKey> GetKeys()
        {
            Queue<TKey> keys = new Queue<TKey>();

            for (int i = 0; i < Size; i++)
            {
                foreach (var key in KVStacks[i].GetKeys())
                    keys.Enqueue(key);
            }

            return keys;
        }

        private void Resize(int newSize)
        {
            HashTableSepChaining<TKey, TValue> temp = new HashTableSepChaining<TKey, TValue>(newSize);

            for (int i = 0; i < Size; i++)
            {
                foreach (var key in KVStacks[i].GetKeys())
                    temp.Add(key, GetValue(key));
            }

            Count = temp.Count;
            Size = temp.Size;
            KVStacks = temp.KVStacks;
        }
    }
}
