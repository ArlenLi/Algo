using System;
using System.Xml.XPath;

namespace TreesAndGraphs
{
    /*
     * Random Node: You are implementing a binary tree class from scratch which, in addition to
     * insert, find, and delete, has a method getRandomNode() which returns a random node
     * from the tree. All nodes should be equally likely to be chosen. Design and implement an algorithm
     * for getRandomNode, and explain how you would implement the rest of the methods.
     */
    public class RandomNode
    {
        public int Data { get; set; }

        public RandomNode Left { get; set; }

        public RandomNode Right { get; set; }

        public int Size { get; private set; }

        public RandomNode()
        {
            Size++;
        }

        public RandomNode(int data)
        {
            Data = data;
            Size++;
        }

        public void Insert(int data)
        {
            if (data < Data)
            {
                if (Left == null)
                    Left = new RandomNode(data);
                else
                    Left.Insert(data);
            }
            if (data >= Data)
            {
                if (Right == null)
                    Right = new RandomNode(data);
                else
                    Right.Insert(data);
            }
            Size++;
        }

        public RandomNode Find(int data)
        {
            if (Data == data)
                return this;
            if (data < Data)
            {
                if (Left != null)
                    return Left.Find(data);
            }
            if (data > Data)
            {
                if (Right != null)
                    return Right.Find(data);
            }
            return null;
        }

        public static DeleteResult Delete(RandomNode node, int data)
        {
            if (node == null)
                return new DeleteResult(null, false);
            else if (node.Data == data)
            {
                if (node.Left == null && node.Right == null)
                    return new DeleteResult(null, true);
                else if (node.Left != null && node.Right != null)
                {
                    var tempNode = node.Right;
                    while (tempNode != null && tempNode.Left != null)
                    {
                        tempNode = tempNode.Left;
                    }
                    node.Data = tempNode.Data;
                    node.Size--;
                    node.Right = Delete(node.Right, tempNode.Data).Node;
                    return new DeleteResult(node, true);
                }
                else if (node.Left != null)
                {
                    return new DeleteResult(node.Left, true);
                }
                else
                {
                    return new DeleteResult(node.Right, true);
                }
            }
            else if (data < node.Data)
            {
                var result = Delete(node.Left, data);
                node.Left = result.Node;
                if (result.Deleted)
                    node.Size--;
                return new DeleteResult(node, result.Deleted);
            }
            else
            {
                var result = Delete(node.Right, data);
                node.Right = result.Node;
                if (result.Deleted) 
                    node.Size--;
                return new DeleteResult(node, result.Deleted);
            }
        }



        public static RandomNode GetRandomNode(RandomNode node, int? randomNum)
        {
            if (randomNum == null)
            {
                var random = new Random();
                randomNum = random.Next(node.Size);
            }
            var leftSize = node.Left != null ? node.Left.Size : 0;
            var rightSize = node.Right != null ? node.Right.Size : 0;

            if (randomNum == leftSize)
                return node;
            else if (randomNum < leftSize)
                return GetRandomNode(node.Left, randomNum);
            else
                return GetRandomNode(node.Right, randomNum - leftSize - 1);
        }
    }

    public class DeleteResult
    {
        public RandomNode Node { get; set; }
        public bool Deleted { get; set; }

        public DeleteResult(RandomNode node, bool deleted)
        {
            Node = node;
            Deleted = deleted;
        }
    }
}
