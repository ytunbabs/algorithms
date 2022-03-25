using System;
using System.Collections.Generic;
using Abstractions.Graph.Models;
using System.Linq;

namespace Abstractions.Graph
{
    public class Graph<T>
    {
        private LinkedList<GraphNode<T>>[] _adjList;
        //public int[] Degrees;
        private int _numVertices;
        //public int NumEdges;
        public bool IsDirected;


        public Graph(bool isDirected, int maxVertices)
        {
            _adjList = new LinkedList<GraphNode<T>>[maxVertices];
            IsDirected = isDirected;

            for (int i = 0; i < maxVertices; i++)
            {
                _adjList[i] = new LinkedList<GraphNode<T>>();
            }

            _numVertices = maxVertices;
        }

        public void InsertEdge(int x, int y)
        {
            GraphNode<T> currentEdge = new GraphNode<T>();

            currentEdge.Weight = default(T);
            currentEdge.X = x;
            currentEdge.Y = y;

            _adjList[x].AddLast(currentEdge);

        }

        public void Print()
        {

            for (int i = 0; i <= _numVertices; i++)
            {
                Console.WriteLine("  :" + i);
                var current = _adjList[i].First;
                while (current != null)
                {
                    Console.WriteLine(" " + current.Value.X);
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        public IEnumerable<GraphNode<T>> PrintPath(Graph<T> g, GraphNode<T> source, GraphNode<T> destination)
        {
            var defaultOutput = new GraphNode<T>();
            if (source == destination)
            {
                yield return defaultOutput;
            }

            var adjNode = g._adjList[source.X];
            if (adjNode == null)
            {
                yield return defaultOutput;
            }

            GraphNode<T> current = destination;
            while (g._adjList[current.X] != null)
            {
                var predecessor = g._adjList[current.X].First.Previous;
                Console.WriteLine(predecessor.Value.X);
                current = predecessor.Value;
            }

        }

        public void BFS(int vertex)
        {
            //Initialize the vertices in the graph

            var graphNodes = new Queue<int>();

            //item.Distance = queueItem.Distance + 1;
            graphNodes.Enqueue(vertex);
            var startNode = _adjList[vertex];

            foreach (var node in startNode)
            {
                node.IsVisited = true;
                Console.WriteLine(node.Y);
            }

            while (graphNodes.Any())
            {
                var queueList = _adjList[graphNodes.Dequeue()];
                foreach (var node in queueList)
                {
                    if (!node.IsVisited)
                    {
                        Console.WriteLine(node.Y);

                        node.IsVisited = true;
                        //item.Distance = queueItem.Distance + 1;
                        graphNodes.Enqueue(node.X);
                    }

                }
            }
        }

        public void DFS(int vertex)
        {
            int time = 0;
            //1: Initialize the list
            for (int i = 0; i < vertex; i++)
            {
                var nodeList = _adjList[i];

                foreach (var node in nodeList)
                {
                    node.IsVisited = false;
                    node.Distance = 0;
                }
            }
            //2: DFS Visit each unvisited node in the 
            
            var currentNodeList = _adjList[vertex];

            foreach (var node in currentNodeList)
            {
                if (!node.IsVisited)
                {
                    DfsVisit(node, ref time);
                }
            }
        }

        public void DfsVisit(GraphNode<T> node, ref int time)
        {
            //1: Increment the time, distance and color
            time += 1;
            node.Distance = time;
            node.IsVisited = true;

            //2: Print the edge value
            Console.WriteLine(node.Y);

            //3: Iterate over each node in the current edge
            //   and visit any unvisited node

            foreach (var listNode in _adjList[node.X])
            {
                if(listNode == _adjList[node.X].First.Value)
                {
                    continue;
                }
                else
                {
                    if (!listNode.IsVisited)
                    {
                        listNode.Previous = _adjList[node.X].First.Value;
                        DfsVisit(listNode, ref time);
                    }
                }
            }
            //4: Increment time and distance
            node.Distance = time + 1;
            time += 1;
            

        }

    }
}
