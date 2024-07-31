using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Queue<T>
    {
        private LinkedList<T> items;

        public Queue()
        {
            items = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T value = items.First.Value;
            items.RemoveFirst();
            return value;
        }

        public int Size()
        {
            return items.Count;
        }
    }
}
