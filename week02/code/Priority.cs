public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue of items with different priorities. Apple(1), Banana(4), Cherry(2), Orange(5), Pear(3). Checks order and makes sure that errors are flagged and displayed.
        // Expected Result: Orange, Banana, Pear, Cherry, Apple.
        Console.WriteLine("Test 1");
        var fruits = new PriorityQueue();
        fruits.Enqueue("Apple", 1);
        fruits.Enqueue("Banana", 4);
        fruits.Enqueue("Cherry", 2);
        fruits.Enqueue("Orange", 5);
        fruits.Enqueue("Pear", 3);
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(fruits.Dequeue());
        }

        // Defect(s) Found: The highest priority item was repeated in the queue because items were not being removed from Dequeue.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Get all items out of queue in order when more than 1 item(s) have the same priority. Oxygen(6), Carbon(3), Hydrogen(3), Nitrogen(6), Sulfur(3), Phosphorus(3).
        // Expected Result: Test 2
            // Oxygen
            // Nitrogen
            // Carbon
            // Hydrogen
            // Sulfur
            // Phosphorus

        Console.WriteLine("Test 2");
        var elements = new PriorityQueue();
        elements.Enqueue("Oxygen", 6);
        elements.Enqueue("Carbon", 3);
        elements.Enqueue("Hydrogen", 3);
        elements.Enqueue("Nitrogen", 6);
        elements.Enqueue("Sulfur", 3);
        elements.Enqueue("Phosphorus", 3);
        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine(elements.Dequeue());
        }

     // Defect(s) Found: 
// - The highest priority item was not correctly identified.
// - Items with the same priority were not dequeued in FIFO order.


        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}