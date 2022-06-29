using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    public class Graph<T>
    {
        public List<GraphNode<T>> nodes = new List<GraphNode<T>>();

        public Graph()
        {

        }

        public GraphNode<T> AddNode(T value)
        {


            if ((Find(value) != null))
            {
                return null;
            }
            else
            {
                nodes.Add(new GraphNode<T>(value));
                GraphNode<T> node = new GraphNode<T>(value);
                return node;
            }
        }

        public void AddEdge(T value1, T value2)
        {
            GraphNode<T> node1 = Find(value1);
            GraphNode<T> node2 = Find(value2);

            if (node1 == null || node2 == null)
            {
                return;
            }
            else if (node1.neighbors.Contains(node2))
            {
                return;
            }
            else
            {
                //Directed
                node1.AddNeighbors(node2);

                //Undirected
                node2.AddNeighbors(node1);

                return;
            }
        }

        public GraphNode<T> Find(T value)
        {
            // I need this function to search for a node in the list of nodes
            foreach (GraphNode<T> node in nodes)
            {
                if (node.value.Equals(value))
                {
                    return node;
                }
            }
            return null;
        }

        public List<GraphNode<T>> GetNodes()
        {
            return nodes;
        }

        public List<GraphNode<T>> GetNeighbors(T value)
        {
            GraphNode<T> node = Find(value);

            if (node is null)
            {
                return null;
            }
            else
            {
                return node.neighbors;
            }
        }

        public int Size()
        {
            return nodes.Count;
        }


        public List<GraphNode<T>> BreadthFirst(GraphNode<T> node)
        {
            List<GraphNode<T>> nodes = new List<GraphNode<T>>();
            Queue<GraphNode<T>> breadth = new Queue<GraphNode<T>>();
            List<GraphNode<T>> visited = new List<GraphNode<T>>();

            breadth.Enqueue(node);
            visited.Add(node);

            while (breadth.Count > 0)
            {
                GraphNode<T> front = breadth.Dequeue();
                nodes.Add(front);

                foreach (GraphNode<T> neighbor in GetNeighbors(front.value))
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        breadth.Enqueue(neighbor);
                    }
                }
            }
            return nodes;
        }
        

        public Queue<GraphNode<T>> BreadthFirst(T value)
        {
            //NOTE:
            // in the requirements, it just asks us to implement a function that returns a list of visited nodes
            // no specific order was specified
            // the stretch goal is to implement something that checks for edges
            // and i will do that once we're done with ecommerce, but for now
            // it's not a requirement

            Queue<GraphNode<T>> visited = new Queue<GraphNode<T>>();

            while (nodes.Count > 0)
            {
                foreach (var item in nodes)
                {
                    visited.Enqueue(item);
                }
            }
            return visited;
        }

        //
        //
        //
        //
        //
        //


        #region extra implementation I studied

        public bool RemoveNode(T value)
        {
            GraphNode<T> removedNode = Find(value);

            if (removedNode == null)
            {
                return false;
            }
            else
            {
                nodes.Remove(removedNode);
                // we also have to remove our nodes
                foreach (GraphNode<T> node in nodes)
                {
                    node.RemoveNeighbor(removedNode);
                }
                return true;
            }
        }

        public bool RemoveEdge(T value1, T value2)
        {
            GraphNode<T> node1 = Find(value1);
            GraphNode<T> node2 = Find(value2);

            if (node1 == null || node2 == null)
            {
                return false;
            }
            else if (!node1.neighbors.Contains(node2))
            {
                return false;
            }
            else
            {
                //directed
                node1.RemoveNeighbor(node2);

                //undirected
                node2.RemoveNeighbor(node1);

                return true;
            }
        }

        public void Clear()
        {
            foreach (GraphNode<T> node in nodes)
            {
                node.RemoveAllNeighbors();
            }
            for (int i = (nodes.Count - 1); i >= 0; i++)
            {
                nodes.RemoveAt(i);
            }
        }

        #endregion

    }
}
