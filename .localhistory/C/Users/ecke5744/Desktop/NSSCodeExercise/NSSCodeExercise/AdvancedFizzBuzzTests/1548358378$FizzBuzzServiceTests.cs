using System;
using System.Collections.Generic;
using System.IO;
using AdvancedFizzBuzz;
using AdvancedFizzBuzz.Interfaces;
using Xunit;

namespace AdvancedFizzBuzzTests
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void Requirement1Bullet1Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                _fizzBuzzService.DoFizzBuzz(-20, 10);

                Assert.Equal(163, sw.ToString().Length);
            }
        }

        [Fact]
        public void Requirement1Bullet2Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                _fizzBuzzService.DoFizzBuzz(new List<int> { 5, 33, 9, 254, 635, 88, 42, 3 });

                Assert.Equal(45, sw.ToString().Length);
            }
        }

        [Fact]
        public void Requirement1Bullet3Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                _fizzBuzzService
                    .DoFizzBuzz(new List<int> { 65, 30, 390 },
                                new Dictionary<int, string> { { 5, "Cat" }, { 13, "Chicken" }, { 6, "Duck" } });

                Assert.Equal(45, sw.ToString().Length);
            }
        }
    }
}
