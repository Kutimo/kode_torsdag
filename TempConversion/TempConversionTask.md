## Temperature Converter – Quick Start

**Task:** Build a console app that converts temperatures. Show menu → get
input → convert → repeat until quit.
### Essential C# Syntax

```csharp
# Input/Output: 
Console.WriteLine("Text");
string input = Console.ReadLine();`
```

```csharp
# Safe Number Conversion:
if (double.TryParse(input, out double num)) { /* use num */ }```

# String Compare:
if (choice.ToLower() == "c")
```

```csharp
# Loop: 
while (true) { if (shouldQuit) break; }
```

```csharp
# Method:
private static double Convert(double celsius) { return (celsius * 9/5) + 32; }
```

```csharp
# Format: 
Console.WriteLine($"{temp:F2}°F");
```
## Python → C#
| Python        | C#                    |
|---------------|-----------------------|
| `input()`     | `Console.ReadLine()`  |
| `print()`     | `Console.WriteLine()` |
| Indentation   | `{}`                  |
| No semicolons | Add `;`               |
| `x = "hello"` | `string x = "hello";` |

## Build Order

1. Menu + loop 
2. One conversion (C→F)  
3. Validation (`TryParse`)  
4. Second conversion (F→C)  
5. Quit option