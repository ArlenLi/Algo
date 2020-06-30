using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class StackOfPlates<T>
    {
        private List<StackWithCapacity<T>> stacks;
        private int currentStackIndex;
        private int capacity;

        public StackOfPlates(int capacity)
        {
            this.capacity = capacity;
            stacks = new List<StackWithCapacity<T>>();
            stacks.Add(new StackWithCapacity<T>(capacity));
            currentStackIndex = 0;
        }

        public void push(T item)
        {
            var currentStack = stacks[currentStackIndex];
            if (!currentStack.isFull())
                currentStack.Push(item);
            else
            {
                var newStack = new StackWithCapacity<T>(capacity);
                newStack.Push(item);
                stacks.Add(newStack);
                currentStackIndex++;
            }
        }

        public T Pop()
        {
            var currentStack = stacks[currentStackIndex];
            if (currentStackIndex == 0 && currentStack.isEmpty())
                throw new EmptyStackException();

            if (!currentStack.isEmpty())
                return currentStack.Pop();
            else
            {
                stacks.RemoveAt(currentStackIndex--);
                currentStack = stacks[currentStackIndex];
                return currentStack.Pop();
            }
        }

        public T PopAt(int index)
        {
            if (index > currentStackIndex)
                throw new InvalidOperationException("The specified stack does not exist");

            var selectedStack = stacks[index];
            if (selectedStack.isEmpty())
                throw new InvalidOperationException("The specified stack is empty");

            var result = selectedStack.Pop();

            // refill each stack
            for(var i = index; i < currentStackIndex; i++)
            {
                if(stacks[i+1].isEmpty())                
                    stacks.RemoveAt(currentStackIndex--);
                else
                {
                    var bottomOfNextStack = stacks[i + 1].RemoveBottom();
                    stacks[i].Push(bottomOfNextStack);
                }                
            }
            return result;
        }
    }
}
