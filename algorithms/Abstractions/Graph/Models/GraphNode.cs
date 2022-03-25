using System;
namespace Abstractions.Graph.Models
{
    public class GraphNode<T>
    {
        public T Weight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; set; } = 0;
        public bool IsVisited { get; set; } = false;
        public GraphNode<T> Previous { get; set; }
    }
}
