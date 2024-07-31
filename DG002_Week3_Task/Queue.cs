using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class Queue<T>
    {
        public LinkedList<T> items;

        public Queue()
        {
            items = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            if (items.Count == 0) return true;
            return false;
        }

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public int? Dequeue()
        {
            
            if (items.Count > 0)
            {
                int value = Convert.ToInt32(items.First.Value);
                items.RemoveFirst();
                return value;
            }
            int? err = null;
            return err;
            
        }

        public int Size()
        {
            return items.Count;
        }
    }
}
