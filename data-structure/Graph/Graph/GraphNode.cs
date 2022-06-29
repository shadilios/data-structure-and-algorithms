using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    public class GraphNode<T>
    {
        public T value;

        public List<GraphNode<T>> neighbors;

        public GraphNode(T value)
        {
            this.value = value;
            this.neighbors = new List<GraphNode<T>>();
        }

        public bool AddNeighbors(GraphNode<T> neighbor)
        {
            if (neighbors.Contains(neighbor))
            {
                return false;
            }
            else
            {
                neighbors.Add(neighbor);
                return true;
            }
        }

        public bool RemoveNeighbor(GraphNode<T> neighbor)
        {
            return neighbors.Remove(neighbor);
        }

        public bool RemoveAllNeighbors()
        {
            for (int i = neighbors.Count; i >= 0; i--)
            {
                neighbors.RemoveAt(i);
            }
            return true;
        }
    }
}
