//              Instructions
//What if we need the length of the words 
//separated by a space to be added at the 
//end of that same word and have it returned as an array?
// codewars: link - https://www.codewars.com/kata/559d2284b5bb6799e9000047/csharp
//              Solution

using System.Linq;
public class Kata
{
  public static string[] AddLength(string str)
  {
    string[] words = str.Split(' ');
    return words.Select(word => $"{word} {word.Length}").ToArray();
  }
}