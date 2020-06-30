using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class StackWithCapacity<T>
    {
        private StackNode<T> top;
        private StackNode<T> bottom;
        private int occupied;
        private int capacity;

        public StackWithCapacity(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException($"{nameof(capacity)} should be greater than 0");
            this.capacity = capacity;
        }

        public T Pop()
        {
            if (top == null)
                throw new EmptyStackException();
            var item = top.Data;
            top = top.Below;
            if (top != null)
                top.Above = null;
            occupied--;
            if (occupied == 0)
                bottom = null;
            return item;
        }

        public void Push(T item)
        {
            if (isFull())
                throw new InvalidOperationException("The stack is Full already");
            var newTop = new StackNode<T>(item);
            if (top == null)
            {
                top = newTop;
                bottom = newTop;
            }
            else
            {
                newTop.Below = top;
                top.Above = newTop;
                top = newTop;
            }               
            occupied++;
        }

        public T RemoveBottom()
        {
            if (bottom == null)
                throw new InvalidOperationException("The stack is empty");
            var result = bottom.Data;
            bottom = bottom.Above;
            if (bottom != null)
                bottom.Below = null;
            else
                top = null; 
            occupied--;
            return result;
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

        public bool isFull()
        {
            return occupied == capacity;
        }

        private class StackNode<T>
        {
            public T Data;
            public StackNode<T> Below;
            public StackNode<T> Above;

            public StackNode(T data)
            {
                Data = data;
            }
        }
    }
}
