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

        public Vertex(int value, List<Vertex> neighbours)
        {
            this.value = value;
            isVisited = false;
            this.neighbours = neighbours;
        }

        

        
    }
}
