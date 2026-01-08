
// Build a console app that counts how many times a specific character
// appears in a string (case-insensitive) using Regex.


using System.Text.RegularExpressions;

string text = "programming";
char targetChar = 'M';




int count = Regex.Matches(text, Regex.Escape(targetChar.ToString()), RegexOptions.IgnoreCase).Count;

Console.WriteLine($"The character {targetChar} appears {count} times");