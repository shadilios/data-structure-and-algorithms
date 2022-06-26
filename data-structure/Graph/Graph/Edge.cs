using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Edge
    {
        public Vertex beginning;
        public Vertex ending;

        public Edge(Vertex beginning, Vertex ending)
        {
            this.beginning = beginning;
            this.ending = ending;
        }
    }
}
