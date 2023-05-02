using System;
using Palindrome.Models;

namespace Palindrome
{
  class Program
  {
    static void Main() 
    {
      Console.WriteLine("Enter a word or phrase to check if it is a palindrome:");
      string input = Console.ReadLine();
      PalindromeChecker newPalindrome = new PalindromeChecker();
      bool result = newPalindrome.IsPalindrome(input);
      if (result == true)
      {
        Console.WriteLine("This is a palindrome!");
      }
      else
      {
        Console.WriteLine("This is NOT a palindrome!");
      }

    }
  }
}