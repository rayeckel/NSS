using System;
using AdvancedFizzBuzz.Interfaces;

namespace AdvancedFizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1,
            string token2)
        {
            for (int i = lowVal; i <= highVal; i++)
            {
                string str = i.ToString();
                var isThreeMultiple = i % 3 == 0;
                var isFiveMultiple = i % 5 == 0;

                if (isThreeMultiple && isFiveMultiple)
                {
                    str = token1+token2;
                }
                else if (isThreeMultiple)
                {
                    str = token1;
                }
                else if (isFiveMultiple)
                {
                    str = token2;
                }

                Console.WriteLine(str + Environment.NewLine);
            }
        }
    }
}
