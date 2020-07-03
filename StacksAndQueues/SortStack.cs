using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StacksAndQueues
{
    /* 3.5
     * Sort Stack: Write a program to sort a stack such that the smallest items are on the top. You can use
       an additional temporary stack, but you may not copy the elements into any other data structure
       (such as an array). The stack supports the following operations: push, pop, peek, and isEmpty.
     */
    public class SortStack<T> where T : IComparable<T>
    {
        public static Stack<T> SortStackAlgo(Stack<T> stackToBeSorted)
        {
            var tempStack = new Stack<T>();
            while(!stackToBeSorted.IsEmpty())
            {
                var popedItem = stackToBeSorted.Pop();
                while (!tempStack.IsEmpty() && (popedItem.CompareTo(tempStack.Peek()) < 0))
                {
                    stackToBeSorted.Push(tempStack.Pop());
                }
                tempStack.Push(popedItem);
            }

            while (!tempStack.IsEmpty())
            {
                stackToBeSorted.Push(tempStack.Pop());
            }
            return stackToBeSorted;
        }
    }
}
