
// Initialize array with numbers
int[] numbers = [12, 4, 45, 7, 5, 34];

// Start with the first number as the largest
int largest = numbers[0];

// Loop through all numbers in the array
foreach (int number in numbers)
{
    // If current number is larger than largest, update largest
    if (number > largest)
    {
        largest = number;
    }
}

// Display the result
Console.WriteLine($"The largest number is {largest}");