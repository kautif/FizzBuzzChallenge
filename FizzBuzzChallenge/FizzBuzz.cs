using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public class FizzBuzz
    {
        public string checkFizzBuzz(int num) {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
                return "fizzbuzz";

            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("buzz");
                return "buzz";
            }
            else if (num % 3 == 0) {
                Console.WriteLine("fizz");
                return "fizz";
            }
            else
            {
                Console.WriteLine("nothin   ");
                return "";
            }
        }
    }
}
