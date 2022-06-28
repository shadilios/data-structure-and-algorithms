# Graphs
<!-- Short summary or background information -->
Graphs are a type of data structed that represent a non linear relationship between nodes, usually used in mapping applications.

## Challenge
<!-- Description of the challenge -->

Implement a graph datastructed with AddNode, AddEdge, GetNodes, GetNeighbors & Size functions.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

Approach: Created a Graph class containing a list of nodes, and implemented all the following functions:  


1. AddNode:  

		Loop over my nodes, if the one im trying to add doesn't exists, add it.
		Big(O):
		Time O(n), single loop
		Space O(1)		

2. AddEdge:  

		Add an edge between 2 nodes after you Check if the nodes im trying to add aren't null or the nodes aren't equal to neighbors.
		Big(O):
		Time: O(n), we loop over the neighbors of a node.
		Space: O(1)

3. GetNodes:  

		Retrieve the list of nodes inside the graph class.  
		Big(O):  
		Time: O(1)  
		Space: O(1)  
		
4. GetNeighbors:    

		Retireve list of neighors for specific node.  
		
		Big(O):  
		Time: O(n), we loop once using the Find function  
		Space: O(1)  

5. Size:  

		Retrieve the size of the list of nodes insids my graph class.
		Big(O):  
		Time: O(1)  
		Space: O(1)  




## API
<!-- Description of each method publicly available in your Graph -->

1. AddNode()
Arguments: value.  
Returns: The added node.  
Add a node to the graph .  

2. AddEdge()  
Arguments: 2 nodes to be connected by the edge, weight (optional).  
Returns: nothing.
Adds a new edge between two nodes in the graph.  
If specified, assign a weight to the edge.  
Both nodes should already be in the Graph.  

3. GetNodes()  
Arguments: none.  
Returns all of the nodes in the graph as a collection (set, list, or similar).  

4. GetNeighbors()  
Arguments: node.  
Returns a collection of edges connected to the given node.  
Include the weight of the connection in the returned collection.  

5. Size()  
Arguments: none.  
Returns the total number of nodes in the graph.