using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Stack<T>
    {
        public LinkedList<T> items;

        public Stack()
        {
            items = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            if (items.Count == 0) return true;
            return false;
        }

        public void Push(T item)
        {
            items.AddLast(item);
        }

        public int? Pop()
        {
            if (items.Count > 0)
            {
                int value = Convert.ToInt32(items.Last.Value);
                items.RemoveLast();
                return value;
            }
            int? err = null;
            return err;            
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
