using System;
using System.Collections.Generic;
using System.Linq;
using AdvancedFizzBuzz.Interfaces;

namespace AdvancedFizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public void DoFizzBuzz(IList<int> modValues, IDictionary<int, string> outputDict)
        {
            var outputMax = outputDict.Keys.Max();

            foreach (var modValue in modValues)
            {
                var outPutDictString = String.Empty;

                foreach (var kvp in outputDict)
                {
                    if (modValue % Math.Abs(kvp.Key) == 0)
                    {
                        outPutDictString += kvp.Value;
                    }
                }

                if (!String.IsNullOrEmpty(outPutDictString))
                {
                    Console.WriteLine(outPutDictString);
                    continue;
                }

                Console.WriteLine(modValue.ToString());
            }
        }

        public void DoFizzBuzz(
            int lowVal,
            int highVal,
            IDictionary<int, string> outputDict)
        {
            var outputMax = outputDict.Keys.Max();

            for (int modValue = lowVal; modValue <= highVal; modValue++)
            {
                var outPutDictString = String.Empty;

                foreach (var kvp in outputDict)
                {
                    if (modValue % Math.Abs(kvp.Key) == 0)
                    {
                        outPutDictString += kvp.Value;
                    }
                }

                if (!String.IsNullOrEmpty(outPutDictString))
                {
                    Console.WriteLine(outPutDictString);
                    continue;
                }

                Console.WriteLine(modValue.ToString());
            }
        }

        public void DoFizzBuzz(
            IList<int> intVals,
            string token1,
            string token2)
        {
            foreach (var modValue in intVals)
            {
                OutPutMods(modValue, token1, token2);
            }
        }

        public void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1,
            string token2)
        {
            for (int modValue = lowVal; modValue <= highVal; modValue++)
            {
                OutPutMods(modValue, token1, token2);
            }
        }

        private void OutPutMods(int modValue, string token1, string token2)
        {
            string str = modValue.ToString();
            var isThreeMultiple = Math.Abs(modValue) % 3 == 0;
            var isFiveMultiple = Math.Abs(modValue) % 5 == 0;

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

            Console.WriteLine(str);
        }
    }
}
