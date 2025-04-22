using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Demonstrating List
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        // Adding an element to the List
        list.Add(6);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("List after adding 6:");
        Console.WriteLine(string.Join(", ", list));

        Console.WriteLine();

        // Removing an element from the List (removes by value)
        list.Remove(3);
        Console.WriteLine("List after removing element 3:");
       

        foreach ( var i in list)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();

        Console.WriteLine();

        // Removing an element by index
        list.RemoveAt(0);
       
        Console.WriteLine("List after removing element at index 0:");
        Console.WriteLine(string.Join(", ", list));

        Console.ResetColor();
        // --------------------------------------------

        // Demonstrating Queue
        Queue<int> queue = new Queue<int>();

        Console.WriteLine();

        // Enqueue elements to the Queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Queue after enqueuing 10, 20, 30:");
        Console.WriteLine(string.Join(", ", queue));

        Console.WriteLine();

        // Dequeue an element from the Queue (FIFO)
        queue.Dequeue();
        Console.WriteLine("Queue after dequeuing one element (First-In-First-Out):");
        Console.WriteLine(string.Join(", ", queue));

        Console.ResetColor();
        Console.WriteLine();



        // --------------------------------------------

        // Demonstrating Stack
        Stack<int> stack = new Stack<int>();

        Console.ForegroundColor= ConsoleColor.DarkCyan;

        // Pushing elements onto the Stack
        stack.Push(100);
        stack.Push(200);
        stack.Push(300);
        Console.WriteLine("Stack after pushing 100, 200, 300:");
        Console.WriteLine(string.Join(", ", stack));

        Console.WriteLine();

        // Popping an element from the Stack (LIFO)
        stack.Pop();
        Console.WriteLine("Stack after popping one element (Last-In-First-Out):");
        Console.WriteLine(string.Join(", ", stack));

        Console.WriteLine();

        // Peeking the top element of the Stack
        Console.WriteLine("Peeking the top element of the Stack:");
        Console.WriteLine(stack.Peek());

        Console.ResetColor();
        Console.WriteLine();
    }
    
}
