using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    /*
     * Stack Min: How would you design a stack which, in addition to push and pop, has a function min
       which returns the minimum element? Push, pop and min should all operate in 0(1) time.
     */
    public class MinStack <T> where T: IComparable<T>
    {
        private StackNode<T> top;

        public T Pop()
        {
            if (top == null)
                throw new EmptyStackException();
            var item = top.Data;
            top = top.Next;
            return item;
        }

        public void Push(T item)
        {
            var newTop = new StackNode<T>(item);
            if (top == null)
            {
                top = newTop;
                top.Minimum = item;
            }   
            else
            {
                newTop.Next = top;
                newTop.Minimum = item.CompareTo(top.Minimum) < 0 ? item : top.Minimum;
                top = newTop;
            }
        }

        public T Min()
        {
            if (top == null)
                throw new EmptyStackException();
            else
                return top.Minimum;
        }

        public T Peek()
        {
            if (top == null)
                throw new EmptyStackException();
            else
                return top.Data;
        }

        public bool isEmpty()
        {
            return top == null;
        }
        private class StackNode<T> where T: IComparable<T>
        {
            public T Data;
            public StackNode<T> Next;

            // Minimum element for Nodes beneath this Node including itself
            public T Minimum;

            public StackNode(T data)
            {
                Data = data;
            }
        }        
    }
}
