

What would be the best data structure to model the behavior of the supply basket? Justify your answer and explain how it would be used.

Stack model uses the most recent seeds that are picked up because the stack model (like pancakes) dispenses LIFO .  A queue model would plant seeds in the order obtained (FIFO)

What is the time complexity of adding new seeds to the supply basket?
Adding to a stack is a push operation which is contant time, O(1)


What is the time complexity of removing seeds from the supply basket?
Since we are only removing seeds at the top of the stack, Pop() uses 0(1) in constant time.

What is the time complexity of checking to see if the supply basket is empty? We are using stack so checking for an empty basket is not complex and doesn't require searching through elements or modifying structure.  A simple count operation should do the trick again O(1) should do the trick.