using System;

namespace StringMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original string for demonstration
            string text = "  Hello, C# Programming!  ";

            // 1. Trim() - Removes leading and trailing whitespace
            Console.WriteLine("1. Trim() Example:"); // Output: 1. Trim() Example:
            string trimmed = text.Trim();
            Console.WriteLine($"Original: '{text}'"); // Output: Original: '  Hello, C# Programming!  '
            Console.WriteLine($"Trimmed: '{trimmed}'"); // Output: Trimmed: 'Hello, C# Programming!'
            Console.WriteLine(); // Output: (empty line)

            // 2. ToUpper() and ToLower() - Case conversion
            Console.WriteLine("2. ToUpper() and ToLower() Example:"); // Output: 2. ToUpper() and ToLower() Example:
            Console.WriteLine($"ToUpper: {text.ToUpper()}"); // Output: ToUpper:   HELLO, C# PROGRAMMING!  
            Console.WriteLine($"ToLower: {text.ToLower()}"); // Output: ToLower:   hello, c# programming!  
            Console.WriteLine(); // Output: (empty line)

            // 3. Substring() - Extracts a portion of the string
            Console.WriteLine("3. Substring() Example:"); // Output: 3. Substring() Example:
            string substring = text.Substring(7, 2); // Start at index 7, take 2 characters
            Console.WriteLine($"Substring(7,2): '{substring}'"); // Output: Substring(7,2): 'C#'
            Console.WriteLine(); // Output: (empty line)

            // 4. Replace() - Replaces all occurrences of a string
            Console.WriteLine("4. Replace() Example:"); // Output: 4. Replace() Example:
            string replaced = text.Replace("C#", "World");
            Console.WriteLine($"Original: '{text}'"); // Output: Original: '  Hello, C# Programming!  '
            Console.WriteLine($"Replaced: '{replaced}'"); // Output: Replaced: '  Hello, World Programming!  '
            Console.WriteLine(); // Output: (empty line)

            // 5. Contains() - Checks if a string contains a substring
            Console.WriteLine("5. Contains() Example:"); // Output: 5. Contains() Example:
            bool contains = text.Contains("C#");
            Console.WriteLine($"Contains 'C#': {contains}"); // Output: Contains 'C#': True
            Console.WriteLine(); // Output: (empty line)

            // 6. StartsWith() and EndsWith() - Check string start/end
            Console.WriteLine("6. StartsWith() and EndsWith() Example:"); // Output: 6. StartsWith() and EndsWith() Example:
            Console.WriteLine($"Starts with '  Hello': {text.StartsWith("  Hello")}"); // Output: Starts with '  Hello': True
            Console.WriteLine($"Ends with '!  ': {text.EndsWith("!  ")}"); // Output: Ends with '!  ': True
            Console.WriteLine(); // Output: (empty line)

            // 7. Split() - Splits string into an array
            Console.WriteLine("7. Split() Example:"); // Output: 7. Split() Example:
            string[] words = text.Trim().Split(' ');
            Console.WriteLine("Words in string:"); // Output: Words in string:
            foreach (string word in words)
            {
                Console.WriteLine($"- {word}"); // Output: - Hello,  (then) - C#  (then) - Programming!
            }
            Console.WriteLine(); // Output: (empty line)

            // 8. IndexOf() - Finds first occurrence of a substring
            Console.WriteLine("8. IndexOf() Example:"); // Output: 8. IndexOf() Example:
            int index = text.IndexOf("C#");
            Console.WriteLine($"Index of 'C#': {index}"); // Output: Index of 'C#': 9
            Console.WriteLine(); // Output: (empty line)

            // 9. Length - Gets the string length
            Console.WriteLine("9. Length Example:"); // Output: 9. Length Example:
            Console.WriteLine($"Length of text: {text.Length}"); // Output: Length of text: 26
            Console.WriteLine(); // Output: (empty line)

            // 10. String.IsNullOrEmpty() - Checks if string is null or empty
            Console.WriteLine("10. IsNullOrEmpty() Example:"); // Output: 10. IsNullOrEmpty() Example:
            string emptyString = "";
            Console.WriteLine($"Is text null or empty: {string.IsNullOrEmpty(text)}"); // Output: Is text null or empty: False
            Console.WriteLine($"Is emptyString null or empty: {string.IsNullOrEmpty(emptyString)}"); // Output: Is emptyString null or empty: True
            Console.WriteLine(); // Output: (empty line)

            // 11. String.Join() - Combines array elements into a single string
            Console.WriteLine("11. Join() Example:"); // Output: 11. Join() Example:
            string joined = string.Join(" | ", words);
            Console.WriteLine($"Joined string: '{joined}'"); // Output: Joined string: 'Hello, | C# | Programming!'
            Console.WriteLine(); // Output: (empty line)

            // 12. String.Format() - Formats a string with placeholders
            Console.WriteLine("12. Format() Example:"); // Output: 12. Format() Example:
            string formatted = string.Format("Language: {0}, Topic: {1}", "C#", "Strings");
            Console.WriteLine($"Formatted string: '{formatted}'"); // Output: Formatted string: 'Language: C#, Topic: Strings'
            Console.WriteLine(); // Output: (empty line)

            // 13. String.Concat() - Concatenates multiple strings
            Console.WriteLine("13. Concat() Example:"); // Output: 13. Concat() Example:
            string concat = string.Concat("Hello", ", ", "World!");
            Console.WriteLine($"Concatenated string: '{concat}'"); // Output: Concatenated string: 'Hello, World!'
            Console.WriteLine(); // Output: (empty line)

            // 14. String.IsNullOrWhiteSpace() - Checks if string is null, empty, or whitespace
            Console.WriteLine("14. IsNullOrWhiteSpace() Example:"); // Output: 14. IsNullOrWhiteSpace() Example:
            string whitespaceString = "   ";
            Console.WriteLine($"Is text null or whitespace: {string.IsNullOrWhiteSpace(text)}"); // Output: Is text null or whitespace: False
            Console.WriteLine($"Is whitespaceString null or whitespace: {string.IsNullOrWhiteSpace(whitespaceString)}"); // Output: Is whitespaceString null or whitespace: True
            Console.WriteLine(); // Output: (empty line)

            // 15. PadLeft() and PadRight() - Adds padding to reach a specified length
            Console.WriteLine("15. PadLeft() and PadRight() Example:"); // Output: 15. PadLeft() and PadRight() Example:
            string paddedLeft = "C#".PadLeft(5, '*'); // Pad left with '*' to total length 5
            Console.WriteLine($"PadLeft: '{paddedLeft}'"); // Output: PadLeft: '***C#'
            string paddedRight = "C#".PadRight(5, '*'); // Pad right with '*' to total length 5
            Console.WriteLine($"PadRight: '{paddedRight}'"); // Output: PadRight: 'C#***'
        }
    }
}