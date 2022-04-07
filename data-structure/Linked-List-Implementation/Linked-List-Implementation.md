# Singly Linked List

Implementing a singly linked list by creating 2 classes:
- Node Class: Holds the node
- LinkedList Class: holds the headNode and all the functions

<br><hr><br>
## Challenge

We are to add 3 functions inside our Linked list class:
- Insert: Inserts a node with a specific value at the beginning of the list.
- Includes: Checks if a specific value is within the list.
- ToString (Named ConvertToString in my project): Returns a string that shows the list in the following form: [x]->[y]->[z]->null

<br><hr><br>
## Approach & Efficiency


1. list creation : O(1)  space/time complexity.
2. Insert : O(1)  space/time complexity.
3. Includes: O(1)/O(n) space/time complexity.  
  reason: O(1) because we search for 1 value, O(n) because we iterate through n elements in list.

5. ConvertToString: O(n)/O(1) space/time complexity.
  reason: O(n) because we iterate through n elements of the list to save them in string.  
          O(1) because single string is output.



<br><hr><br>
## API

1. Insert: A method that takes an integer as a value and add it to the beginning of the list (headNode).

2. Includes: A method that returns true if the passed int exists within the list.  

3. ConvertToString: A method that returns a string that consists of nodes in our elements in this form: [x]->[y]->[z]->null.  


<br><hr><br>
