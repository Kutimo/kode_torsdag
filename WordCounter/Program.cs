using System.Text.RegularExpressions;

namespace WordCounter;

class Program
{
    static void Main(string[] args)
    {
        string text = "programming";
        char targetChar = 'M';

        // Use Regex.Matches to find all occurrences
        // Regex.Escape ensures special characters are treated literally
        // int count = Regex.Matches(text.ToLower(), Regex.Escape(targetChar.ToString().ToLower())).Count;
       // Add to lower method twice or ad ignoreCase for regex
        int count = Regex.Matches(text, Regex.Escape(targetChar.ToString()), RegexOptions.IgnoreCase).Count;
        Console.WriteLine($"The character '{targetChar}' appears {count} times");
    }
}