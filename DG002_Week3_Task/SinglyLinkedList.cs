using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private int Count;

        public SinglyLinkedList()
        {
            head = null;
            Count = 0;
        }

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;

                while (current.Next != null)
                {
                    current = current.Next;                    
                }
                current.Next = newNode;
            }
            Count++;
            return Count;
        }

        public bool Remove(T item)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous == null)
                    {
                        previous.Next = current;
                    }
                   
                    previous.Next = current.Next;
                    return true;                                      
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            Node<T> current = head;
            int Index = 0;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return Index;
                }
                else
                {
                    Index++;
                }
                current = current.Next;   
            }
            return -1;
        }



        public void Print()
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write($"{current.Data}->");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
    }
}

