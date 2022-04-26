# Brackets Validation


# Challenge Summary
<!-- Description of the challenge -->
Write a function that takes a string as an argument & returns true if the brackets inside the string represent a closed statement.

## Whiteboard Process
<!-- Embedded whiteboard image -->
No whiteboard for this challenge

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Time: O(n), because I loop over all the characters inside my string.
Space: O(n), I use a list to add the characters I want inside.

## Solution
<!-- Show how to run your code, and examples of it in action -->

1. First I remove everything from my string except brackets.
2. I replace all the brackets in this form:
    * {}
    * ()
    * []

3. If my string length after removing the brackets becomes Zero, return true.
4. If After removing all the full brackets the string's length isn't zero, return False.
