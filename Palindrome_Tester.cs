using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        string reversedWord = Reverse(word);

        if (word == reversedWord)
        {
            Console.WriteLine("The word is a palindrome.");
        }
        else
        {
            Console.WriteLine("The word is not a palindrome.");
        }
    }

    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}