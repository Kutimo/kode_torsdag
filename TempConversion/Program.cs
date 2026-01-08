namespace kode_Torsdag;

class Program
{
    // Main method - the entry point of the program where execution begins
    static void Main(string[] args)
    {
        // Display the menu to the user at program start
        ShowMenu();

        // Infinite loop that keeps the program running until the user chooses to quit
        while (true)
        {
            // Read the user's menu choice from the console
            // The '?' makes it nullable, meaning it can be null if ReadLine returns null
            string? choice = Console.ReadLine();

            // Check if the user chose 'c' for Celsius to Fahrenheit conversion
            // '?.' is the null-conditional operator - it safely calls ToLower even if choice is null
            // ToLower() converts the input to lowercase so 'C' and 'c' both work
            if (choice?.ToLower() == "c")
            {
                // Prompt the user to enter a temperature value
                Console.WriteLine("Please enter a number to convert from Celsius to Fahrenheit:");

                // Read the temperature input as a string
                string? numInput = Console.ReadLine();

                // Try to parse the string input into a double (decimal number)
                // TryParse returns true if successful and stores the result in 'num'
                // The 'out' keyword means 'num' gets assigned inside TryParse
                if (double.TryParse(numInput, out double num))
                {
                    // Call the conversion method and store the result
                    double fahrenheit = ConvertCelsiusToFahrenheit(num);

                    // Display the result with 2 decimal places using F2 format
                    // {num} inserts the Celsius value, {fahrenheit.ToString("F2")} formats Fahrenheit to 2 decimals
                    Console.WriteLine($"{num}°C = {fahrenheit.ToString("F2")}°F");

                    // get a 2-second freeze of the thread to see the actual conversion data
                    Thread.Sleep(2000);
                    // Show the menu again so the user can make another choice
                    ShowMenu();
                }
                else
                {
                    // If parsing failed (user entered text instead of a number), show error message
                    Console.WriteLine("Invalid number, please try again.");
                }
            }
            // Check if the user chose 'f' for Fahrenheit to Celsius conversion
            else if (choice?.ToLower() == "f")
            {
                // Prompt the user to enter a temperature value
                Console.WriteLine("Please enter a number to convert from Fahrenheit to Celsius:");

                // Read the temperature input as a string
                string? numInput = Console.ReadLine();

                // Try to parse the string input into a double
                if (double.TryParse(numInput, out double num))
                {
                    // Call the conversion method and store the result
                    double celsius = ConvertFahrenheitToCelsius(num);

                    // Display the result with 2 decimal places
                    Console.WriteLine($"{num}°F = {celsius.ToString("F2")}°C");
                    
                    // get a 2-second freeze of the thread to see the actual conversion data
                    Thread.Sleep(2000);
                    // Show the menu again for another conversion
                    ShowMenu();
                }
                else
                {
                    // If parsing failed, show error message
                    Console.WriteLine("Invalid number, please try again.");
                }
            }
            // Check if the user chose 'q' to quit the program
            else if (choice?.ToLower() == "q")
            {
                // Display exit message
                Console.WriteLine("Exiting program...");

                // Break out of the while loop, which ends the program
                break;
            }
            // If the user entered something other than c, f, or q
            else
            {
                // Inform the user their choice was invalid
                Console.WriteLine("Invalid Choice, please try again");

                // Show the menu again to remind them of valid options
                ShowMenu();
            }
        }
    }

    // Method to display the menu options to the user
    // 'static' means it belongs to the class, not an instance
    // 'void' means it doesn't return any value
    private static void ShowMenu()
    {
        // Print welcome message
        Console.WriteLine("Welcome to the temperature converter:");

        // Display each menu option on a separate line
        Console.WriteLine("c: Celsius to Fahrenheit");
        Console.WriteLine("f: Fahrenheit to Celsius");
        Console.WriteLine("q: To quit the program");

        // Prompt the user to make a selection
        Console.WriteLine("Please make a choice: c, f or q . ");
    }

    // Method to convert Fahrenheit to Celsius
    // Takes a double parameter 'result' (the Fahrenheit temperature)
    // Returns a double (the Celsius temperature)
    private static double ConvertFahrenheitToCelsius(double result)
    {
        // Apply the conversion formula: (F - 32) × 5/9
        // Subtract 32, multiply by 5, then divide by 9
        return ((result - 32) * 5 / 9);
    }

    // Method to convert Celsius to Fahrenheit
    // Takes a double parameter 'result' (the Celsius temperature)
    // Returns a double (the Fahrenheit temperature)
    private static double ConvertCelsiusToFahrenheit(double result)
    {
        // Apply the conversion formula: (C × 9/5) + 32
        // Multiply by 9, divide by 5, then add 32
        return (result * 9 / 5) + 32;
    }
}