using System;
using System.Collections.Generic;
namespace Collections_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty LinkedList.
            LinkedList<int> aLinkedList = new LinkedList<int>();
            // Add elements at the start.
            aLinkedList.AddFirst(2);
            aLinkedList.AddFirst(3);
            Console.WriteLine("The current state of the list №1");
            foreach (int i in aLinkedList)
            {
                Console.WriteLine($"{i}");
            }
            // Add another element at the start, and hold a reference to the node.
            LinkedListNode<int> node1 = aLinkedList.AddFirst(1);
            Console.WriteLine("The current state of the list №2");
            foreach (int i in aLinkedList)
            {
                Console.WriteLine($"{i}");
            }
            // Add nodes before and after node1.
            aLinkedList.AddBefore(node1, 5);
            aLinkedList.AddAfter(node1, 6);
            Console.WriteLine("The current state of the list №3");
            foreach (int i in aLinkedList)
            {
                Console.WriteLine($"{i}");
            }
            // Remove items.
            aLinkedList.Remove(5);
            aLinkedList.RemoveLast();
            // Iterate through all of the items.
            Console.WriteLine("The current state of the list №4");
            foreach (int i in aLinkedList)
            {
                Console.WriteLine($"{i}");
            }
            // Find an item by performing a linear search from the start.
            LinkedListNode<int> foundNode = aLinkedList.Find(6);
            if (foundNode != null)
            {
                Console.WriteLine($"Found: {foundNode.Value}");
                // Get next node.
                LinkedListNode<int> nextNode = foundNode.Next;
                if (nextNode != null)
                {
                    Console.WriteLine($"Next: {nextNode.Value}");
                }
                // Get previous node.
                LinkedListNode<int> previousNode = foundNode.Previous;
                if (previousNode != null)
                {
                    Console.WriteLine($"Previous: {previousNode.Value}");
                }
            }
        }
    }
}