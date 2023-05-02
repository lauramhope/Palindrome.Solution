using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeCheckerTests 
  {
    PalindromeChecker newPalindrome = new PalindromeChecker();
    [TestMethod]
    public void PalindromeConstructor_CreatesInstanceOfPalindrome_Palindrome()
      {
        Assert.AreEqual(typeof(PalindromeChecker), newPalindrome.GetType());
      }
  }
}