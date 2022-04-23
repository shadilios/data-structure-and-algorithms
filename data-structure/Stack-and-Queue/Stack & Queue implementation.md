# Stack and Queue

![img](https://miro.medium.com/max/1000/0*-y92CX3NIm9SkYSx.png)

# Stacks and Queues
<!-- Short summary or background information -->

In this Challenge, we had to implement 2 collections, which are:  

* Stack: Just like a stack of books, this collection holds data in a FILO pattern, each book representing a Node where our data will be.
* Queue: This collection follows the FIFO pattern, imagine inserting objects in a pipe, you won't be able to retrieve those objects unless you go to the other end of the pipe and collect the first object you pushed into.



<br><hr><br>
## Challenge
<!-- Description of the challenge -->
1. Node Class: we were asked to implement a class that holds our data, with a reference to our next node.
2. Stack Class: Implement a stack class with a top property, and the following functions:
    * Push: Adds a new node with a passed value to the top of the stack with an O(1) Time performance.
    * Pop: Removes the value from node from the top of the stack & returns it.
    * Peek: Returns the value of the node located at the top of the stack.
    * IsEmpty: Returns true or false whether the stack is empty.


4. Queue Class: Implement a queue class with rear and front properties, and the following functions:
    * Enqueue: Adds a new node with a passed value to the back of the queue with an O(1) Time performance.
    * Dequeue: Removes the node from the front of the queue & returns it.
    * Peek: Returns the value of the node located at the front of the queue.
    * IsEmpty: Returns true or false whether the queue is empty.


    


<br><hr><br>
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

Time complexity: O(1) for all functions since we don't deal with any loop & access a single value.  
Space: O(1) because we retrieve a single value in all functions.


<br><hr><br>
## API
<!-- Description of each method publicly available to your Stack and Queue-->

* Stack Class Functions:
    * Push: Adds a new node with a passed value to the top of the stack with an O(1) Time performance.
    * Pop: Removes the value from node from the top of the stack & returns it.
    * Peek: Returns the value of the node located at the top of the stack.
    * IsEmpty: Returns true or false whether the stack is empty.


* Queue Class Functions: 
    * Enqueue: Adds a new node with a passed value to the back of the queue with an O(1) Time performance.
    * Dequeue: Removes the node from the front of the queue & returns it.
    * Peek: Returns the value of the node located at the front of the queue.
    * IsEmpty: Returns true or false whether the queue is empty.

