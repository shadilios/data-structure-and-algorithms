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
    }
}
