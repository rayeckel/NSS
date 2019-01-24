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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Requirement #1 Bullet #1");
            Console.ForegroundColor = ConsoleColor.Blue;
            _fizzBuzzService.DoFizzBuzz(-20, 10);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Requirement #1 Bullet #2");
            Console.ForegroundColor = ConsoleColor.Blue;
            _fizzBuzzService.DoFizzBuzz(new List<int> { 5, 33, 9, 254, 635, 88, 42, 3 });

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Requirement #1 Bullet #3");
            Console.ForegroundColor = ConsoleColor.Blue;
            _fizzBuzzService
                .DoFizzBuzz(new List<int> { 65, 30, 390 },
                            new Dictionary<int, string> { { 5, "Cat" }, { 13, "Chicken" }, { 6, "Duck" } });

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Requirement #2 - Basic FizzBuzz");
            Console.ForegroundColor = ConsoleColor.Blue;
            _fizzBuzzService.DoFizzBuzz(1, 50);
        }
    }
}
