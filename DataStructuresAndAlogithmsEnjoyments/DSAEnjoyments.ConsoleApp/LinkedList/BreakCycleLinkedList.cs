using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.LinkedList
{
    internal class BreakCycleLinkedList
    {
        public static void Main(string[] args = null)
        {
            ExampleBreakCycleLinkedList1();
            Console.WriteLine();
            ExampleBreakCycleLinkedList2();
            Console.WriteLine();
            ExampleBreakCycleLinkedList3();
        }

        private static bool ContainCycle(SingleLinkedList singleLinkedListA)
        {
            Node slowPointer = singleLinkedListA.head;
            Node fastPointer = singleLinkedListA.head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                    return true;
            }

            return false;
        }

        private static SingleLinkedList BreakCycleLinkdList(SingleLinkedList singleLinkedListA)
        {
            if (!ContainCycle(singleLinkedListA))
                return singleLinkedListA;

            Node slowPointer = singleLinkedListA.head;
            Node fastPointer = singleLinkedListA.head;

            while (fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                    break;
            }

            // The distance from the first Node to the Node where the cycle starts = the distance from
            // where the 2 pointers met to the Node where the cycle starts

            // If linked list is a circle
            if (slowPointer == singleLinkedListA.head)
            {
                while (fastPointer.next != slowPointer)
                    fastPointer = fastPointer.next;
            }
            else
            {
                slowPointer = singleLinkedListA.head;
                while (slowPointer.next != fastPointer.next)
                {
                    slowPointer = slowPointer.next;
                    fastPointer = fastPointer.next;
                }
            }

            fastPointer.next = null;

            return singleLinkedListA;
        }

        private static void ExampleBreakCycleLinkedList3()
        {
            Console.WriteLine("0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -----");
            Console.WriteLine("                                   ^     /");
            Console.WriteLine("                                   ------");

            const int N = 8;
            SingleLinkedList linkedList = new SingleLinkedList
            {
                head = new Node(0)
            };

            Node temp = linkedList.head;
            for (int i = 1; i < N; i++)
                temp = (temp.next = new Node(i));

            Node t = linkedList.head;
            while (t.next != null)
                t = t.next;
            t.next = t;

            // UNCOMMENT the following line will fall into an infinite loop !!!
            //TraverseSingleLinkedList(linkedList);

            linkedList = BreakCycleLinkdList(linkedList);

            TraverseSingleLinkedList(linkedList);
        }

        private static void ExampleBreakCycleLinkedList2()
        {
            const int N = 8;
            SingleLinkedList linkedList = new SingleLinkedList
            {
                head = new Node(0)
            };

            Console.WriteLine(" 0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7");
            Console.WriteLine("           ^                       /");
            Console.WriteLine("           \\                      /");
            Console.WriteLine("            \\---------------------");
            Node temp = linkedList.head;
            for (int i = 1; i < N; i++)
                temp = (temp.next = new Node(i));

            Node t = linkedList.head;
            while (t.next != null)
                t = t.next;
            t.next = linkedList.head.next.next;

            // UNCOMMENT the following line will fall into an infinite loop !!!
            //TraverseSingleLinkedList(linkedList);

            linkedList = BreakCycleLinkdList(linkedList);

            TraverseSingleLinkedList(linkedList);
        }

        private static void ExampleBreakCycleLinkedList1()
        {
            const int N = 8;
            SingleLinkedList linkedList = new SingleLinkedList
            {
                head = new Node(0)
            };

            Console.WriteLine("0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7");
            Console.WriteLine("^                                  /");
            Console.WriteLine("\\                                 /");
            Console.WriteLine(" \\--------------------------------");
            Node temp = linkedList.head;
            for (int i = 1; i < N; i++)
                temp = (temp.next = new Node(i));

            Node t = linkedList.head;
            while (t.next != null)
                t = t.next;
            t.next = linkedList.head;

            // UNCOMMENT the following line will fall into an infinite loop !!!
            //TraverseSingleLinkedList(linkedList);

            linkedList = BreakCycleLinkdList(linkedList);

            TraverseSingleLinkedList(linkedList);
        }

        public static void TraverseSingleLinkedList(SingleLinkedList singleLinkedList)
        {
            Node temp = singleLinkedList.head;

            Console.Write(temp.data + " -> ");

            while (temp.next != null)
            {
                temp = temp.next;
                Console.Write(temp.data + " -> ");
            }

            Console.WriteLine("null");
        }
    }

}
