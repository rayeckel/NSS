namespace AdvancedFizzBuzz.Interfaces
{
    public interface IFizzBuzzService
    {
        void DoFizzBuzz(
            int lowVal,
            int highVal,
            string token1 = "Fizz",
            string token2 = "Buzz");
    }
}
