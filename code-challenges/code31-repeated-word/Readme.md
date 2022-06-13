# Challenge Summary
<!-- Description of the challenge -->
Write a function called repeated word that finds the first word to occur more than once in a string

<br><hr><br>
## Whiteboard Process
<!-- Embedded whiteboard image -->

![img](./imgs/whiteboard.png)

<br><hr><br>
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

##### Approach:

Created a hashtable and stored values in it,  
Then increase the key value by 1 each time the element exists.

##### Efficiency:
Time: O(N): For loop  
Space: O(1)


<br><hr><br>
## Solution
<!-- Show how to run your code, and examples of it in action -->

```
public static string MostRepeated(string s)
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            s = s.ToLower(); // Make all characters lower case

            // Remove non alphabetic characters
            s = s.Replace(",", "");
            s = s.Replace(".", "");
            s = s.Replace("!", "");
            s = s.Replace("?", "");
            s = s.Replace("/", "");
            s = s.Replace("&", "");

            string[] arr = s.Split(' ');

            foreach (string word in arr)
            {
                if (dictionary.ContainsKey(word)) // if it's in the dictionary
                {
                    dictionary[word] = dictionary[word] + 1; // Increment the count
                }
                else
                {
                    dictionary[word] = 1; // put it in the dictionary with a count 1
                }
            }

            KeyValuePair<string, int> mostRepeated = dictionary.First();

            foreach (KeyValuePair<string, int> x in dictionary)
            {
                if (x.Value > mostRepeated.Value)
                {
                    mostRepeated = x;
                }
            }

            return mostRepeated.Key;
        }
        
```