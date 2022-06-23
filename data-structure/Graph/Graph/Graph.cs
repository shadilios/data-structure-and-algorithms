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

        public int size;

        public Graph(int size)
        {
            this.size = size;
            vertices = new List<Vertex>(size);
        }

        public Vertex AddVertex(Vertex vertexToAdd)
        {
            vertices.Add(vertexToAdd);

            return vertexToAdd;
        }



        #region CC36 Breadth first

        public LinkedList<Vertex> BreadthFirst(Vertex vertex)
        {
            // Do I need to reset the is visited?


            LinkedList<Vertex> visitedList = new LinkedList<Vertex>();

            // I need to set the node where to traverse from to isVisited
        }


        #endregion
    }
}
