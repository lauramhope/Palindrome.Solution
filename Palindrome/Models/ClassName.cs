using System;

namespace Palindrome.Models
{
  public class PalindromeChecker
  {
    public bool IsPalindrome(string input)
    {
      char[] inputArray = input.ToCharArray();      
      Array.Reverse(inputArray);
      string reversedInput = String.Join("", inputArray);      
      if (input == reversedInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}