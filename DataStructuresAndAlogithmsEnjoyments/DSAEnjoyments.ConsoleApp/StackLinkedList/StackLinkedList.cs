using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAEnjoyments.ConsoleApp.StackLinkedList
{
    internal class StackLinkedList<T> : IEnumerable<T>
    {
        LinkedList<T> list = new LinkedList<T>();

        public void Push(T val)
        {
            list.AddFirst(val);
        }

        public T Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Empty Stack!");

            T val = list.First.Value;
            list.RemoveFirst();
            return val;
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Empty Stack!");

            return list.First.Value;
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
