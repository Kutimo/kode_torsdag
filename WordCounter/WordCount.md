## Character Counter – Quick Start

**Task:** Build a console app that counts how many times a specific character
appears in a string (case-insensitive) using Regex.

### Essential C# Syntax

```csharp
# Import Regex:
using System.Text.RegularExpressions;
```

## Python → C#

| Python                      | C#                                      |
|-----------------------------|-----------------------------------------|
| `import re`                 | `using System.Text.RegularExpressions;` |
| `re.findall(pattern, text)` | `Regex.Matches(text, pattern)`          |
| `len(matches)`              | `matches.Count`                         |
| `text.lower()`              | `text.ToLower()`                        |
| `char.lower()`              | `char.ToLower()`                        |



```csharp
# Declare Variables:
string text = "programming";
char targetChar = 'M';
```

```csharp
# Count with Regex (Case-Insensitive):
int count = Regex.Matches(text, Regex.Escape(targetChar.ToString()), RegexOptions.IgnoreCase).Count;
```

```csharp
# Alternative - Manual ToLower:
int count = Regex.Matches(text.ToLower(), Regex.Escape(targetChar.ToString().ToLower())).Count;
```

```csharp
# Output Result:
Console.WriteLine($"The character '{targetChar}' appears {count} times");
```

```csharp
# With User Input:
Console.WriteLine("Enter text:");
string? text = Console.ReadLine();
Console.WriteLine("Enter character:");
char targetChar = Console.ReadLine()?[0] ?? ' ';
```

## Build Order

1. Import `System.Text.RegularExpressions`
2. Declare text and target character
3. Use `Regex.Matches()` with `RegexOptions.IgnoreCase`
4. Use `Regex.Escape()` to handle special characters
5. Get `.Count` property for total matches
6. Display result with string interpolation