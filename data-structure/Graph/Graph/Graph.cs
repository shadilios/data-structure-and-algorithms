using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {
        public List<Vertex> vertices;
        public List<Edge> edges;



        public Graph()
        {
            
            vertices = new List<Vertex>();
        }

        public Vertex AddVertex(int data)
        {
            Vertex newVertex = new Vertex(data);

            vertices.Add(newVertex);

            return newVertex;
        }

        public void AddEdge(Vertex v1, Vertex v2)
        {
            //v1 always beginning, v2 always ending
            //both nodes should already be in the graph

            Edge newEdge = new Edge(v1, v2);

            edges.Add(newEdge);


        }

        public List<Vertex> GetNodes()
        {
            return vertices;
        }

        public List<Vertex> GetNeighbors(Vertex vertex)
        {
            //return a collection of edges connected to the given node

            return vertex.neighbours;
        }

        public int Size()
        {
            return vertices.Count;
        }


        #region CC36 Breadth first

        public LinkedList<Vertex> BreadthFirst(Vertex vertex)
        {
            LinkedList<Vertex> visitedOrder = new LinkedList<Vertex>();

            // Do I need to reset the is visited?
            // How can I set nodes to visited if I don't have a visit function?





            return visitedOrder;
        }


        #endregion
    }
}
