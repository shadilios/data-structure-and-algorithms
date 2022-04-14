# Psuedo Queue

### Summary

Write a Queue class that implements 2 Stacks with Enqueue & Dequeue Functions.


<br><hr><br>
### Whiteboard:

![2022-04-14 04_50_40-Window](https://user-images.githubusercontent.com/70282602/163298079-272c155e-b79d-49e1-a971-a95856ebeb14.png)

<br><hr><br>
### Code: 

```

public class Queue
    {

        public Stack addingStack;
        public Stack removingStack;

        public int Size
        {
            get { return addingStack.size + removingStack.size; }
        }

        public Queue()
        {

            addingStack = new Stack();
            removingStack = new Stack();

        }


        public void Enqueue(int data)
        {
            addingStack.Push(data);
        }

        public int Dequeue()
        {
            MoveToRemoveStack();

            return removingStack.Pop();
        }

        public void MoveToRemoveStack()
        {
            if (removingStack.Size() == 0)
            {
                while (addingStack.Size() != 0)
                {
                    removingStack.Push(addingStack.Pop());
                }
            }
        }
    }

```
