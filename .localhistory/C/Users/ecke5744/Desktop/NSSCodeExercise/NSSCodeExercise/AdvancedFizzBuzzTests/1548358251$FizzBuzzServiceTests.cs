using System;
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

                _fizzBuzzService.DoFizzBuzz(-20, 10);

                Assert.Equal(resultString1.Length, sw.ToString().Length);
            }
        }


        private string resultString1 = "Buzz" + Environment.NewLine +
                                            "-19" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "-17" + Environment.NewLine +
                                            "-16" + Environment.NewLine +
                                            "FizzBuzz" + Environment.NewLine +
                                            "-14" + Environment.NewLine +
                                            "-13" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "-11" + Environment.NewLine +
                                            "Buzz" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "-8" + Environment.NewLine +
                                            "-7" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "Buzz" + Environment.NewLine +
                                            "-4" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "-2" + Environment.NewLine +
                                            "-1" + Environment.NewLine +
                                            "FizzBuzz" + Environment.NewLine +
                                            "1" + Environment.NewLine +
                                            "2" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "4" + Environment.NewLine +
                                            "Buzz" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "7" + Environment.NewLine +
                                            "8" + Environment.NewLine +
                                            "Fizz" + Environment.NewLine +
                                            "Buzz  ";
    }
}
