using System;
using System.IO;
using AdvancedFizzBuzz;
using AdvancedFizzBuzz.Interfaces;
using NUnit.Framework;

namespace AdvancedFizzBuzzTests
{
    public class FizzBuzzServiceTests
    {
        private IFizzBuzzService _fizzBuzzService;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        public void Requirement1Bullet1Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                _fizzBuzzService.DoFizzBuzz(-20, 10);

                string expected = string.Format("Ploeh{0}", Environment.NewLine);

                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}
