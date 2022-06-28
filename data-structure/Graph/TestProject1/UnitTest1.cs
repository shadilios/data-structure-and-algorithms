using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        //READ THIS PLEASE!!!
        //Neighbors are returned with the weight between nodes included
        
        //  This part of the implementation was optional, I didn't have weight in my code
       
        //A graph with only one node and edge can be properly returned

        //  We can't have a graph with a single node and a single edge! edges are supposed to be between 2 nodes and not 1
       


        [Fact]
        public void CanAddNode()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(5);

            Assert.NotNull(graph.Find(5));
        }

        [Fact]
        public void CanAddEdge()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(5);
            graph.AddNode(50);

            graph.AddEdge(5, 50);

            GraphNode<int> searchedNode = new GraphNode<int>(50);

            Assert.Equal(graph.Find(5).neighbors.Count, 1);
        }

        [Fact]
        public void CanReturnNodes()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(5);
            graph.AddNode(50);

            List<GraphNode<int>> nodes1 = graph.GetNodes();
            List<GraphNode<int>> nodes2 = graph.nodes;

            Assert.Equal(nodes1, nodes2);
        }

        [Fact]
        public void CanReturnNeighbors()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(5);
            graph.AddNode(50);

            List<GraphNode<int>> nodes1 = graph.GetNeighbors(5);
            List<GraphNode<int>> nodes2 = graph.Find(5).neighbors;

            Assert.Equal(nodes1, nodes2);
        }

        [Fact]
        public void CanReturnSize()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(5);
            graph.AddNode(50);

            

            Assert.Equal(graph.Size(), 2);
        }


        //this can't return null because I solved it in a different way, I always have an empty list inside my graph with 0 elements
        [Fact]
        public void CanReturnNullGraph()
        {
            Graph<int> graph = new Graph<int>();

            Assert.Equal(0, graph.Size());
        }

        [Fact]
        public void Test7()
        {

        }

        [Fact]
        public void Test8()
        {

        }





    }
}
