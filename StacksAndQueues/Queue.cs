using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<T>
    {
        private QueueNode<T> first;
        private QueueNode<T> last;

        public void Add(T item)
        {
            var newLast = new QueueNode<T>(item);

            if(last == null)
            {
                last = newLast;
                first = last;
            }
            else
            {
                last.Next = newLast;
                last = newLast;
            }
        }

        public T Remove()
        {
            if (first == null)
                throw new EmptyQueueException();

            var item = first.Data;
            first = first.Next;
            if(first == null)
            {
                last = null;
            }
            return item;
        }

        public T Peek()
        {
            if (first == null)
                throw new EmptyQueueException();

            return first.Data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        private class QueueNode<T>
        {
            public T Data;
            public QueueNode<T> Next;

            public QueueNode(T data)
            {
                Data = data;
            }
        } 
    }
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() : base("Queue is Empty")
        {

        }

        public EmptyQueueException(string message) : base(message)
        {

        }

        public EmptyQueueException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
