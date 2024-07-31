using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Stack<T>
    {
        LinkedList<T> items;

        public Stack()
        {
            items = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Push(T item)
        {
            items.AddLast(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T value = items.Last.Value;
            items.RemoveLast();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items.Last.Value;
        }

        public int Size()
        {
            return items.Count;
        }


    }
}
