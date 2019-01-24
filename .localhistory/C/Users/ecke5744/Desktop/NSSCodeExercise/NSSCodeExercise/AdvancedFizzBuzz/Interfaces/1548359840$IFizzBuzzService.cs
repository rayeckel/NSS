using System.Collections.Generic;

namespace AdvancedFizzBuzz.Interfaces
{
    public interface IFizzBuzzService
    {
        void DoFizzBuzz(
            IList<int> intVals,
            string token1 = "Fizz",
            string token2 = "Buzz");

        void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1 = "Fizz",
            string token2 = "Buzz");

        void DoFizzBuzz(IList<int> modValues, IDictionary<int, string> outputDict);
    }
}
