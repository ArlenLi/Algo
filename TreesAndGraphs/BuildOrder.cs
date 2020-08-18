using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TreesAndGraphs
{
    /*
     * Build Order: You are given a list of projects and a list of dependencies (which is a list of pairs of
     * projects, where the second project is dependent on the first project). All of a project's dependencies
     * must be built before the project is. Find a build order that will allow the projects to be built. If there
     * is no valid build order, return an error.
     * EXAMPLE
     * Input:
     * projects: a, b, c, d, e, f
     * dependencies: (a, d), (f, b), (b, d), (f, a), (d, c)
     * Output: f, e, a, b, d, c
     */
    public class BuildOrder
    {
        public static string[] BuildOderAlgo(string[] projects, List<Tuple<string, string>> dependencies)
        {
            var graphNodes = CreateGraphNodes(projects, dependencies);
            var buildOrder = new List<DirectionalGraphNode<string>>(new DirectionalGraphNode<string>[projects.Length]);
            var index = 0;
            index = AddBuildableProjectsToBuildOrder(graphNodes, buildOrder, index);

            for(var toBeProcessed = 0; toBeProcessed < graphNodes.Count - 1; toBeProcessed++)
            {
                var toBeProcessedGraphNode = buildOrder[toBeProcessed];
                if (buildOrder[toBeProcessed] == null)
                    return null;
                foreach(var graphNode in graphNodes)
                {
                    if (graphNode.IncomingEdges.Contains(toBeProcessedGraphNode))
                        graphNode.IncomingEdges.Remove(toBeProcessedGraphNode);
                }
                index = AddBuildableProjectsToBuildOrder(graphNodes, buildOrder, index);
                if (index == graphNodes.Count)
                    break;
            }
            return buildOrder.Cast<DirectionalGraphNode<string>>().Select(p => p.Data).ToArray<string>();
        }

        private static int AddBuildableProjectsToBuildOrder(List<DirectionalGraphNode<string>> graphNodes, List<DirectionalGraphNode<string>> buildOrder, int index)
        {
            foreach(var graphNode in graphNodes)
            {
                if(graphNode.IncomingEdges.Count == 0)
                {
                    if (!buildOrder.Contains(graphNode))
                    {
                        buildOrder[index] = graphNode;
                        index++;
                    }   
                }
            }
            return index;
        }

        private static List<DirectionalGraphNode<string>> CreateGraphNodes(string[] projects, List<Tuple<string, string>> dependencies)
        {
            var graphNodes = new List<DirectionalGraphNode<string>>();
            var map = new Hashtable();
            foreach(var proj in projects)
            {
                var graphNode = new DirectionalGraphNode<string>(proj);
                map.Add(proj, graphNode);
                graphNodes.Add(graphNode);
            }

            foreach(var dependency in dependencies)
            {
                var project = dependency.Item2;
                var dependentProject = dependency.Item1;
                var graphNode = (DirectionalGraphNode<string>)map[project];
                var dependentGraphNode = (DirectionalGraphNode<string>)map[dependentProject];
                graphNode.IncomingEdges.Add(dependentGraphNode);
                dependentGraphNode.OutgoingEdges.Add(graphNode);
            }
            return graphNodes;
        }


    }
}
