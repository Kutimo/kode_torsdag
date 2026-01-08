namespace FindLargestNumber2;

class Program
{
    static void Main(string[] args)
    {
        // Build a console app that finds the largest number in an array of integers.
        int[] numbers = [12, 4, 45, 7, 5, 34];

        // Initialize largest variable
        // int largest = start with a element of Array
        int largest = numbers[0];
        
        // for loop
        foreach (int number in numbers)
        {
            // if ( compare number > largest)
            // Set the variable largest
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        // String interpolation
        // Console.WriteLine($"{members}");
    }
}