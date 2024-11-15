using DSAEnjoyments.ConsoleApp.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.Search
{
    internal class SequentialSearch
    {
        public static void Main(string[] args = null)
        {
            StackKV<string, int> stackKV = new StackKV<string, int>();
            stackKV.Add("S", 1);
            stackKV.Add("E", 2);
            stackKV.Add("A", 3);
            stackKV.Add("R", 4);
            stackKV.Add("C", 5);
            stackKV.Add("H", 6);

            Console.WriteLine("Keys: ");
            foreach (var k in stackKV.GetKeys())
                Console.Write(k + " ");
            Console.WriteLine("\nValues: ");
            foreach (var v in stackKV.GetValues())
                Console.Write(v + " ");

            string key = "A";
            Console.WriteLine("\nValue of key " + key + ": " + stackKV.GetValue(key));
        }
    }
}
