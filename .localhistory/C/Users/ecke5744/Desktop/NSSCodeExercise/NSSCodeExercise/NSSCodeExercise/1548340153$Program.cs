using AdvancedFizzBuzz;
using AdvancedFizzBuzz.Interfaces;

namespace NSSCodeExercise
{
    public class Program
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public Program(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        static void Main(string[] args)
        {
            var program = new Program(new FizzBuzzService());
            program.DoFizzBuzz();
        }

        public async void DoFizzBuzz()
        {
            await _fizzBuzzService.DoFizzBuzzAsync(1, 100);
        }
    }
}
