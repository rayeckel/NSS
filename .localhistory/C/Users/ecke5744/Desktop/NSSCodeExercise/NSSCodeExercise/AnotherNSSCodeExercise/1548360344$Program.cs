using System;
using System.Collections.Generic;
using AdvancedFizzBuzz;
using AdvancedFizzBuzz.Interfaces;

namespace AnotherNSSCodeExercise
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Requirement #3");
            Console.ForegroundColor = ConsoleColor.Green;
            _fizzBuzzService
                .DoFizzBuzz(-18, 235, new Dictionary<int, string> { { 3, "Fizz" }, { 11, "Buzz" }, { 42, "Bang" } });
        }
    }
}
