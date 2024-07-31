using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG002_Week3_Task
{
    public class SinglyLinkedList<T>
    {
        public Node<T> HeadNode { get; set; }
        public int Count { get; set; }

        public SinglyLinkedList()
        {
            HeadNode = null;
            Count = 0;
        }

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (HeadNode == null)
            {
                HeadNode = newNode;
            }
            else
            {
                Node<T> currentNode = HeadNode;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;                    
                }
                currentNode.Next = newNode;
            }
            Count++;
            return Count;
        }

        public bool Remove(T item)
        {
            Node<T> currentNode = HeadNode;
            Node<T> previous = null;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item))
                {
                    if (previous == null)
                    {
                        previous.Next = currentNode;
                    }
                   
                    previous.Next = currentNode.Next;
                    return true;                                      
                }
                previous = currentNode;
                currentNode = currentNode.Next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T> currentNode = HeadNode;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            Node<T> currentNode = HeadNode;
            int IndexPosition = 0;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item))
                {
                    return IndexPosition;
                }
                else
                {
                    IndexPosition++;
                }
                currentNode = currentNode.Next;   
            }
            return -1;
        }



        public void Print()
            {
                Node<T> currentNode = HeadNode;
                while (currentNode != null)
                {
                    Console.Write($"{currentNode.Data}->");
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("null");
            }
    }
}

