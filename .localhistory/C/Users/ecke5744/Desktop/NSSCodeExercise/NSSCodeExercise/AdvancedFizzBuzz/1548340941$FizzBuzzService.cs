using System;
using AdvancedFizzBuzz.Interfaces;

namespace AdvancedFizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public void DoFizzBuzz(int lowVal, int highVal)
        {
            for (int i = 1; i <= 100; i++)
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
                    str += "Fizz";
                }
                else if (isFiveMultiple)
                {
                    str += "Buzz";
                }

                Console.WriteLine(str + "/n");
            }
        }
    }
}
