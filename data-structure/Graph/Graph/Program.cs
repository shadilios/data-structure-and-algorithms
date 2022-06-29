using System;
using System.Collections.Generic;

namespace GraphImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = new Graph<int>();

            GraphNode<int> x = graph.AddNode(1);
            graph.AddNode(3);
            graph.AddNode(9);
            graph.AddNode(6);
            graph.AddNode(99);

            graph.AddEdge(1, 3);
            graph.AddEdge(3, 9);
            graph.AddEdge(3, 6);
            graph.AddEdge(6, 9);
            graph.AddEdge(9, 99);

            List<GraphNode<int>> y = graph.BreadthFirst(1);

            foreach (var node in y)
            {
                Console.WriteLine(node.value);
            }

        }
    }


}
