using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mills.CodeKatas.FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "buzz";
            }

            return number.ToString();
        }
    }
}
