using System;
using System.Collections.Generic;

namespace TreesAndGraphs
{
    /* 4.1
     * Route Between Nodes: Given a directed graph, design an algorithm to find out whether there is a
       route between two nodes.
     */
    public class RouteBetweenNodes<T>
    {
        public static bool BidirectionalSearch(Node<T> source, Node<T> target)
        {
            if (Object.ReferenceEquals(source, target))
                return true;

            var sourceQueue = new Queue<Node<T>>();
            var targetQueue = new Queue<Node<T>>();
            var sourceVisitedSet = new HashSet<Node<T>>();
            var targetVisitedSet = new HashSet<Node<T>>();
            sourceQueue.Enqueue(source);
            targetQueue.Enqueue(target);
            sourceVisitedSet.Add(source);
            targetVisitedSet.Add(target);

            while(sourceQueue.Count != 0|| targetQueue.Count != 0)
            {
                if (NodeCollidedCheck(sourceQueue, sourceVisitedSet, targetVisitedSet))
                    return true;
                if (NodeCollidedCheck(targetQueue, targetVisitedSet, sourceVisitedSet))
                    return true;
            }
            return false;
        }

        private static bool NodeCollidedCheck(Queue<Node<T>> queue, HashSet<Node<T>> visitedByThis, HashSet<Node<T>> visitedByTheOther)
        {
            if (queue.Count == 0)
                return false;
            var node = queue.Dequeue();
            foreach (var child in node.children)
            {
                if (visitedByTheOther.Contains(child))
                    return true;
                if (visitedByThis.Add(child))
                {
                    queue.Enqueue(child);
                }
            }
            return false;
        }
    }
}
