namespace DG002_Week3_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Singlylindedlist 
            SinglyLinkedList<int> list = new SinglyLinkedList<int> ();

            Console.WriteLine("Single linked list Operations:");
            list.Add (10);
            list.Add (12);
            list.Add (14);
            list.Add (19);
            list.Add (33);

            Console.Write("List after adding data: ");
            list.Print();

            Console.WriteLine($"Remove 33: {list.Remove(33)}");
            Console.Write("List after removing 33: ");
            list.Print ();

            Console.WriteLine($"Check for 12: {list.Check(12)}");
            Console.WriteLine($"Check for 18: {list.Check(18)}");

            Console.WriteLine($"Index of 12: {list.Index(14)}");
            Console.WriteLine($"Index of 22: {list.Index(22)}");
            Console.WriteLine();


            // Stack 
            Stack<int> stack = new Stack<int> ();

            Console.WriteLine("Stack Operations:");

            Console.WriteLine($"Is the stack empty? {stack.IsEmpty()}");

            stack.Push (10);
            stack.Push (12);
            stack.Push (14);
            stack.Push (15);
            stack.Push (17);

            Console.WriteLine($"Is the stack still empty? {stack.IsEmpty()}");
            Console.WriteLine($"How many items are in the stack: {stack.Size()}");
            Console.WriteLine($"What item was removed from the stack: {stack.Pop()}");
            Console.WriteLine($"What is the item at the last index: {stack.Peek()}");
            Console.WriteLine($"How many items are in the stack now: {stack.Size()}");            
            Console.WriteLine();


            // Queue 
            Queue<int> queue = new Queue<int> ();

            Console.WriteLine("Queue Operations:");

            Console.WriteLine($"Is queue empty? {queue.IsEmpty()}");

            queue.Enqueue (10);
            queue.Enqueue (23);
            queue.Enqueue (34);
            queue.Enqueue (45);
            queue.Enqueue (56);
            queue.Enqueue (78);

            Console.WriteLine($"Is queue still Empty? {queue.IsEmpty()}");
            Console.WriteLine($"What is the size of queue: {queue.Size()}");
            Console.WriteLine($"What item was removed from the queue: {queue.Dequeue()}");
            Console.WriteLine($"What is the size after removing item: {queue.Size()}");

            

        }
    }
}
