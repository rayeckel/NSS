using System.Collections.Generic;
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

        public void DoFizzBuzz()
        {
            //_fizzBuzzService.DoFizzBuzz(1, 100);
            //_fizzBuzzService.DoFizzBuzz(-2147, 100);
            //_fizzBuzzService.DoFizzBuzz(new List<int> { 5, 33, 9, 254, 635, 88, 42, 3 });
            _fizzBuzzService
                .DoFizzBuzz(new List<int> { 5, 33, 9, 254, 635, 88, 42, 3 }, new Dictionary<int, string> { { 1, "Cat" }, { 45, "Duck" } });
        }
    }
}
