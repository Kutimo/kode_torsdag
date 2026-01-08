## Find Largest Number - Quick Start

**Task:** Build a console app that finds the largest number in an array of
integers.

### Essential C# Syntax

```csharp
# Declare Array:
int[] numbers = [12, 4, 45, 7, 5, 34];
```

## Python → C#

| Python                | C#                             |
|-----------------------|--------------------------------|
| `numbers = [1, 2, 3]` | `int[] numbers = [1, 2, 3];`   |
| `max(numbers)`        | `numbers.Max()` (LINQ)         |
| `for num in numbers:` | `foreach (int num in numbers)` |
| `len(numbers)`        | `numbers.Length`               |
| `numbers[i]`          | `numbers[i]`                   |





```csharp
# Initialize Largest Variable:
int largest = numbers[0];  // Start with first element
```

```csharp
# Loop Through Array (foreach):
foreach (int number in numbers)
{
    if (number > largest)
        largest = number;
}
```

```csharp
# Output Result:
Console.WriteLine($"The largest number is {largest}");
```

```csharp
# LINQ Alternative (Advanced):
int largest = numbers.Max();
```



## Build Order

1. Declare an array of integers
2. Initialize `largest` variable with first element
3. Loop through array using `foreach`
4. Compare each number with current `largest`
5. Update `largest` if current number is bigger
6. Display result with string interpolation