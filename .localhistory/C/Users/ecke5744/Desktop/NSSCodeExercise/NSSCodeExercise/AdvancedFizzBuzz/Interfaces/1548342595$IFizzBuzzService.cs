namespace AdvancedFizzBuzz.Interfaces
{
    public interface IFizzBuzzService
    {
        void DoFizzBuzz(
            IList<int> intVals,
            string token1,
            string token2);

        void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1 = "Fizz",
            string token2 = "Buzz");
    }
}
