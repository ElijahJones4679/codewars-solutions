//              Instructions
/*Create a function that takes an integer 
as an argument and returns "Even" for even 
numbers or "Odd" for odd numbers.*/

//              Solutions
using System;

namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return "Even"; // Code goes here ...
            }
            else
            {
            return "Odd";  
            }
        }
    }
}