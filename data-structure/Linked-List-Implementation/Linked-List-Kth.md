# Linked-List-Kth

### Summary

Create a function that find the value of a specific index inside a list but in reverse.  
<br><hr><br>

### Whiteboard

![linked-list-kth](https://user-images.githubusercontent.com/70282602/163105130-ff892279-6105-4e80-9a97-83924e2752d2.png)

<br><hr><br>

### Effeciency

Performance: O(n) because I use a while loop.

Space: O(1) because I return a single value.

<br><hr><br>

### Code solution

```

public int Kth(int y)
        {
            //First i have to find how many elements i have [use counter]
            //if the user inputs 0, I have to get back the last element
            //if the user inputs 1, i have to get back the element before the last...and so on
            //so length - input!

            int key = y;
            int firstCounter = 0;
            int secondCounter = 0;
            Node temp = headNode;
            int result = 0;

            //loop through list to find length
            while (temp != null)
            {
                //check
                firstCounter++;
                temp = temp.next;
            }

            //reset
            temp = headNode;

            //loop again to specific element to get data
            while (temp != null)
            {
                if (key > firstCounter -1)
                {
                    Console.WriteLine("Error, your key is bigger than the number of elements in the list, returning zero");
                    break;
                }

                if (key < 0)
                {
                    Console.WriteLine("Error, your key can't be less than 0, returning zero");
                    break;
                }

                secondCounter++;
                if (secondCounter == (firstCounter - key))
                {
                    result = temp.data;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return result;
        }


```
