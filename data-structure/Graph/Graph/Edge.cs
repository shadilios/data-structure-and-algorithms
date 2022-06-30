using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    public class Edge<T>
    {
        public GraphNode<T> node1;
        public GraphNode<T> node2;
        public T weight;

        //this takes nodes directly
        public Edge(GraphNode<T> node1, GraphNode<T> node2, T weight)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.weight = weight;
        }

        //this takes values and add them as node
        public Edge(T value1, T value2, T weight)
        {
            GraphNode<T> firstNode = new GraphNode<T>(value1);
            GraphNode<T> secondNode = new GraphNode<T>(value2);

            this.node1 = firstNode;
            this.node2 = secondNode;
            this.weight = weight;

        }


    }
}
