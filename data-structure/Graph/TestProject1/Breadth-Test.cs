using System;
using Xunit;
using GraphImplementation;
using System.Collections.Generic;


namespace TestProject1
{
    public class Breadth_Test
    {
        [Fact]
        public void ExpectedOutcome_Breadth()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(1);
            graph.AddNode(3);
            graph.AddNode(9);
            graph.AddNode(6);
            graph.AddNode(99);

            graph.AddEdge(1, 3);
            graph.AddEdge(3, 9);
            graph.AddEdge(3, 6);
            graph.AddEdge(6, 9);
            graph.AddEdge(9, 99);

            List<GraphNode<int>> actual = graph.BreadthFirst(1);

            List<GraphNode<int>> expected = new List<GraphNode<int>>();

            GraphNode<int> node1 = new GraphNode<int>(1);
            GraphNode<int> node2 = new GraphNode<int>(3);
            GraphNode<int> node3 = new GraphNode<int>(9);
            GraphNode<int> node4 = new GraphNode<int>(6);
            GraphNode<int> node5 = new GraphNode<int>(99);




            Assert.Contains<GraphNode<int>>(node1, actual);
            
        }

        [Fact]
        public void ExpectedFailure_Breadth()
        {

        }

    }
}
