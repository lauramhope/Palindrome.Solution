using System;
using System.Collections.Generic;

namespace Palindrome.Models
{
  public class PalindromeChecker
  {
    public bool IsPalindrome(string input)
    {
      char[] inputArray = input.ToCharArray();
      List<char> reversedList = new List<char> {};
      foreach (char element in inputArray)
      {
        reversedList.Insert(0, element);
      }
      //Array.Reverse(inputArray);
      string reversedInput = String.Join("", reversedList);      
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