using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    /*3.4
     * Queue via Stacks: Implement a MyQueue class which implements a queue using two stacks.
     */
    public class QueueViaStacks<T>
    {
        private Stack<T> stackForPush;
        private Stack<T> stackForPop;
        private bool isLastOperationPush;

        public QueueViaStacks()
        {
            stackForPush = new Stack<T>();
            stackForPop = new Stack<T>();
            isLastOperationPush = true;
        }

        public void Push(T item)
        {
            if(!isLastOperationPush)
            {
                while(!stackForPop.isEmpty())
                {
                    var data = stackForPop.Pop();
                    stackForPush.Push(data);
                }
            }
            isLastOperationPush = true;
            stackForPush.Push(item);
        }

        public T Pop()
        {
            if(isLastOperationPush)
            {
                while (!stackForPush.isEmpty())
                {
                    var data = stackForPush.Pop();
                    stackForPop.Push(data);
                }
            }

            isLastOperationPush = false;
            if (stackForPop.isEmpty())
                throw new EmptyQueueException();
            return stackForPop.Pop();
        }

        public T Peek()
        {
            if (isLastOperationPush)
            {
                while (!stackForPush.isEmpty())
                {
                    var item = stackForPush.Pop();
                    stackForPop.Push(item);
                }
            }

            isLastOperationPush = false;
            if (stackForPop.isEmpty())
                throw new EmptyQueueException();
            return stackForPop.Peek();
        }

        public bool isEmpty() 
        {
            return stackForPop.isEmpty() && stackForPush.isEmpty();
        }
    }
}
