using System.Collections.Generic;
using System.Linq;

namespace TreesAndGraphs
{
    /*
     * BST Sequences: A binary search tree was created by traversing through an array from left to right
     * and inserting each element. Given a binary search tree with distinct elements, print all possible
     * arrays that could have led to this tree.
     */
    public class BSTSequences
    {
        public static List<List<int>> BSTSequencesAlog(BinaryTreeNode<int> node)
        {
            if(node == null)
                return new List<List<int>>();
            var prefixSequence = new List<int> { node.Data };
            var leftSequences = BSTSequencesAlog(node.Left);
            var rightSequences = BSTSequencesAlog(node.Right);

            var result = new List<List<int>>();
            if (leftSequences.Count == 0 && rightSequences.Count == 0)
                result.Add(prefixSequence);
            else if (leftSequences.Count == 0)
            {
                foreach (var rightSequence in rightSequences)
                        Weave(new List<int>(), rightSequence, prefixSequence, result);
            }
            else if (rightSequences.Count == 0)
            {
                foreach (var leftSequence in leftSequences)
                    Weave(leftSequence, new List<int>(), prefixSequence, result);
            }
            else
            {
                foreach (var leftSequence in leftSequences)
                    foreach (var rightSequence in rightSequences)
                        Weave(leftSequence, rightSequence, prefixSequence, result);
            }
            return result;
        }

        private static void Weave(List<int> leftSequence, List<int> rightSequence, List<int> prefixSequence, List<List<int>> result)
        {
            if (leftSequence.Count == 0 || rightSequence.Count == 0)
            {
                result.Add(prefixSequence.Concat(leftSequence).Concat(rightSequence).ToList());
                return;
            }

            var leftHead = leftSequence[0];
            leftSequence.RemoveAt(0);
            prefixSequence.Add(leftHead);
            Weave(leftSequence, rightSequence, prefixSequence, result);
            prefixSequence.RemoveAt(prefixSequence.Count - 1);
            leftSequence.Insert(0, leftHead);

            var rightHead = rightSequence[0];
            rightSequence.RemoveAt(0);
            prefixSequence.Add(rightHead);
            Weave(leftSequence, rightSequence, prefixSequence, result);
            prefixSequence.RemoveAt(prefixSequence.Count - 1);
            rightSequence.Insert(0, rightHead);
        }
    }
}
