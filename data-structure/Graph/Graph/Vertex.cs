using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Vertex
    {
        public int value;
        public bool isVisited;
        public List<Vertex> neighbours;
        public List<Edge> edges;

        public Vertex(int value)
        {
            this.value = value;
            isVisited = false;
            this.edges = new List<Edge>();
            this.neighbours = new List<Vertex>();
        }

        

        
    }
}
