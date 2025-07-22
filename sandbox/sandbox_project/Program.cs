using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        //note: You did an activity where you pushed and popped items from a stack declared as var stack = new Stack<int>();
        // it showed as stack [Stack] = [xyz]

        //push(value) - Adds an element to the top of the stack 
        //pop() - Removes the top element from the stack and returns it
        //size() - Returns the number of elements in the stack
        //empty() - Returns true if the stack is empty, false otherwise
        //top()/peek() - Returns the top element of the stack without removing it
        // clear() - Removes all elements from the stack
        // contains(value) - Returns true if the stack contains the specified value, false otherwise
        // isReadOnly - Returns true if the stack is read-only, false otherwise
        // toArray() - Returns an array containing all elements in the stack
        // copyTo(array, index) - Copies the elements of the stack to an array starting at the specified index

        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Dequeue();
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        queue.Enqueue(9);
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(10);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(11);
        queue.Enqueue(12);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(13);
        queue.Enqueue(14);
        queue.Enqueue(15);
        queue.Enqueue(16);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(17);
        queue.Enqueue(18);
        queue.Dequeue();
        queue.Enqueue(19);
        queue.Enqueue(20);
        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        Console.WriteLine("Hello Sandbox World!");
    }
}