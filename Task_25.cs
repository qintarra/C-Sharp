using System;
using System.Collections.Generic;

namespace Algorithms
{
    // In order to determine if a linked list has a cycle, we need to use the next pointers of the linked list
    // A given next pointer cannot point to a node we've already seen in the list
    class CustomLinkedList
    {
        Node head;
        
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        // Implement 'HasCycle' method.
        // It should return 'true' if there is a cycle in a list. Otherwise should return 'false'.
        public Boolean HasCycle()
        {
            // Store nodes that we have already see in the list
            HashSet<Node> nodes = new HashSet<Node>();

            // Keep track of where we are on a list as we iterate through.
            Node current = head;

            // For each node -> check if it is in the HashSet
            while (current != null)
            {
                // If it is in a set -> list must have a cycle               
                if (nodes.Contains(current))
                {                    
                    return true;
                }
                // If it is not on the set -> add it to the set
                else
                {                    
                    nodes.Add(current);
                }
                // increment the current
                current = current.next;
            }
            return false;
        }

        static void Main(string[] args)
        {
            CustomLinkedList noCycleLinkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            noCycleLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine(noCycleLinkedList.HasCycle());

            CustomLinkedList cycleLinkedList = new CustomLinkedList();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine(cycleLinkedList.HasCycle());
        }
    }
}