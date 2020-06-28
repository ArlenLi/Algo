using System;

namespace StacksAndQueues
{
    public class Stack<T>
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
                top = newTop;
            else
            {
                newTop.Next = top;
                top = newTop;
            }
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
        private class StackNode<T>
        {
            public T Data;
            public StackNode<T> Next;

            public StackNode(T data) {
                Data = data;
            }
        }
    }

    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is Empty")
        {
        }

        public EmptyStackException(string message) : base(message)
        {

        }

        public EmptyStackException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
