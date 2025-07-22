using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Four items are added 2 with the same priorities.  
    // Expected Result:   Enqueue adds to back of queue regardless of priority for all items.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        // list of items to be enqueued
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("firstItem", 1);
        priorityQueue.Enqueue("secondItem", 2);
        priorityQueue.Enqueue("thirdItem", 3);
        priorityQueue.Enqueue("fourthItem", 3);

        // test that all items are enqueued correctly

Assert.AreEqual("[firstItem (Pri:1), secondItem (Pri:2), thirdItem (Pri:3), fourthItem (Pri:3)]", priorityQueue.ToString());


    }



    [TestMethod]
    // Scenario: Same four items are added 2 with the same priorities.  
    // Expected Result:  Dequeue removes item with highest priority.  Matching priorities are removed FIFO. Error message for empty queue.
    // Defect(s) Found: Equal priority is returned LIFO instead of FIFO due to overgenerous dequeue loop boolean.  RemoveAt is not called on within Dequeue method.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("firstItem", 1);
        priorityQueue.Enqueue("secondItem", 2);
        priorityQueue.Enqueue("thirdItem", 3);
        priorityQueue.Enqueue("fourthItem", 3);


        // Tests that an empty queue throws  InvalidOperationException with message "The queue is empty."

        // Dequeue should return highest priority first (3), then FIFO for same priority
        Assert.AreEqual("thirdItem", priorityQueue.Dequeue());    // First item with priority 3
        Assert.AreEqual("fourthItem", priorityQueue.Dequeue());   // Second item with priority 3 (FIFO)
        Assert.AreEqual("secondItem", priorityQueue.Dequeue());   // Priority 2
        Assert.AreEqual("firstItem", priorityQueue.Dequeue());    // Priority 1
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty."); 
        
    }

    // Add more test cases as needed below.
}