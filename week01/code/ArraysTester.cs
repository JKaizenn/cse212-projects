public static class ArraysTester
{
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run()
    {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }

    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Define the function signature: The function takes two parameters - number (the starting number) and length (the number of multiples).
        // 2. Initialize the array: Create an array of doubles with the size specified by the length parameter.
        // 3. Fill the array with multiples: Use a loop to calculate each multiple and store it in the array.
        // 4. Return the array: After the loop completes, return the array.

        // Step 2: Initialize the array
        double[] multiples = new double[length];

        // Step 3: Fill the array with multiples
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    /// and an amount is 3, then the list returned should be <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will
    /// be in the range of 1 and data.Count.
    /// </summary>
    /// <param name="data">The list to be rotated</param>
    /// <param name="amount">The amount by which to rotate the list</param>
    private static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Define the function signature: The function takes two parameters - data (the list of data) and amount (the amount to rotate).
        // 2. Handle edge cases: If the amount is 0 or equal to the length of the list, return the list as is.
        // 3. Calculate the split point: Determine where to split the list based on the amount.
        // 4. Create the new rotated list: Use list slicing to create the rotated list.
        // 5. Clear the original list and copy the rotated list into it: Update the original list with the new order.

        // Step 2: Handle edge cases
        if (amount == 0 || amount == data.Count)
        {
            return; // No rotation needed
        }

        // Step 3: Calculate the split point
        int splitPoint = data.Count - amount;

        // Step 4: Create the new rotated list
        List<int> rotatedList = new List<int>();
        rotatedList.AddRange(data.GetRange(splitPoint, amount));
        rotatedList.AddRange(data.GetRange(0, splitPoint));

        // Step 5: Clear the original list and copy the rotated list into it
        data.Clear();
        data.AddRange(rotatedList);
    }
}