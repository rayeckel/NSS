using System;
using System.Threading.Tasks;
using AdvancedFizzBuzz.Interfaces;

namespace AdvancedFizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public async Task DoFizzBuzzAsync(int lowVal, int highVal)
        {
            for (int i = 1; i <= 100; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }

                Console.WriteLine(str);
            }
        }
    }
}
