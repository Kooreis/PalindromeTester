# Python Documentation

# Palindrome Checker

This Python script checks if a word entered by the user is a palindrome. A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, ignoring spaces, punctuation, and capitalization.

## Script Description

The script continuously prompts the user to enter a word to check if it's a palindrome. If the user wants to quit the program, they can simply enter 'q'.

The script uses a function `is_palindrome(input_string)` to check if the entered word is a palindrome. This function takes a string as an input and returns a boolean value indicating whether the input string is a palindrome.

The function works by comparing the input string with its reverse. If they are the same, the function returns `True`, indicating the word is a palindrome. If they are not the same, the function returns `False`, indicating the word is not a palindrome.

## Libraries

This script does not import any libraries. It uses only built-in Python functions and methods.

## Usage

To use this script, run it in a Python environment. When prompted, enter a word to check if it's a palindrome. The script will print "It's a palindrome!" if the word is a palindrome, and "It's not a palindrome." if it's not. To quit the program, enter 'q'.

## Example

```
Enter a word to check if it's a palindrome or 'q' to quit: radar
It's a palindrome!
Enter a word to check if it's a palindrome or 'q' to quit: python
It's not a palindrome.
Enter a word to check if it's a palindrome or 'q' to quit: q
```

In this example, the script correctly identifies "radar" as a palindrome and "python" as not a palindrome.

---

# C# Documentation

# Palindrome Checker in C#

This repository contains a simple C# script that checks if a user-inputted word is a palindrome. A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, ignoring spaces, punctuation, and capitalization.

## Script Description

The script prompts the user to enter a word. It then reverses the word and checks if the reversed word is the same as the original word. If it is, the script outputs "The word is a palindrome." If it's not, the script outputs "The word is not a palindrome."

## Code Breakdown

The script is divided into two main parts:

1. The `Main` method: This is the entry point of the script. It prompts the user to enter a word, reverses the word using the `Reverse` method, and checks if the reversed word is the same as the original word.

2. The `Reverse` method: This method takes a string as an argument, converts it into a character array, reverses the array, and returns the reversed array as a new string.

## Imported Libraries

The script uses the following libraries:

1. `System`: This is a built-in C# library that provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for standard input/output operations via `Console.ReadLine()`, `Console.Write()`, and `Console.WriteLine()`.

## Usage

To run the script, you need a C# compiler. If you have the .NET SDK installed, you can use the `dotnet run` command in the terminal from the directory containing the script.

```bash
dotnet run
```

You will then be prompted to enter a word. After entering a word, the script will tell you whether or not the word is a palindrome.

## Conclusion

This script is a simple demonstration of string manipulation and user interaction in C#. It can be expanded to check for palindromic phrases or sentences, or to ignore case and special characters.

---

# Java Documentation

# Palindrome Tester in Java

This Java program checks if a given string is a palindrome. A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, ignoring spaces, punctuation, and capitalization.

## How it works

The program takes a string input from the user and reverses it using the StringBuilder class. It then compares the reversed string with the original string. If they are equal, it prints "Palindrome", otherwise it prints "Not Palindrome".

## Imported Libraries

### java.util.Scanner

The Scanner class is a class in java.util package used for obtaining the input of the primitive types like int, double, etc. and strings. It is the easiest way to read input in a Java program, though not very efficient if you want an input method for scenarios where time is a constraint, like in competitive programming.

In this program, the Scanner class is used to get the user's input.

## Code

```java
import java.util.Scanner;

public class PalindromeTester {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        String reversed = new StringBuilder(input).reverse().toString();
        if(input.equals(reversed)) {
            System.out.println("Palindrome");
        } else {
            System.out.println("Not Palindrome");
        }
    }
}
```

To run the program, simply compile and run it in a Java environment, then input the string you want to check when prompted.

---
