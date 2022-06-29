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

            graph.AddNode(5);
            graph.AddNode(6);
            graph.AddNode(3);
            graph.AddNode(7);
            graph.AddNode(1);
            graph.AddNode(8);

            List<GraphNode<int>> x = graph.BreadthFirst(graph.nodes[0]);
            
        }

        [Fact]
        public void ExpectedFailure_Breadth()
        {

        }

    }
}
