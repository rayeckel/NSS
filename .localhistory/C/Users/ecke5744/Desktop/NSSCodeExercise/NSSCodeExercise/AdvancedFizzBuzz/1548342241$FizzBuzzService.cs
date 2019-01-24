using System;
using AdvancedFizzBuzz.Interfaces;

namespace AdvancedFizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1 = "Fizz",
            string token2 = "Buzz")
        {
            for (int i = lowVal; i <= highVal; i++)
            {
                string str = i.ToString();
                var isThreeMultiple = i % 3 == 0;
                var isFiveMultiple = i % 5 == 0;

                if (isThreeMultiple && isFiveMultiple)
                {
                    str = "FizzBuzz";
                }
                else if (isThreeMultiple)
                {
                    str = token1;
                }
                else if (isFiveMultiple)
                {
                    str = "Buzz";
                }

                Console.WriteLine(str + Environment.NewLine);
            }
        }
    }
}
