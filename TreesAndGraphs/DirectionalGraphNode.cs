using System.Collections.Generic;
using System.Data.Common;
using System.Net;

namespace TreesAndGraphs
{
    public class DirectionalGraphNode<T>
    {
        public T Data { get; set; }

        public List<DirectionalGraphNode<T>> IncomingEdges { get; set; } = new List<DirectionalGraphNode<T>>();

        public List<DirectionalGraphNode<T>> OutgoingEdges { get; set; } = new List<DirectionalGraphNode<T>>();

        public DirectionalGraphNode(T data) {
            Data = data;    
        }
    }
}
