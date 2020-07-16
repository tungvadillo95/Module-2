using NUnit.Framework;
using FizzBuzzService;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        private FizzBuzzTranslate _fizzBuzzTranslate;
        [SetUp]
        public void Setup()
        {
            _fizzBuzzTranslate = new FizzBuzzTranslate();
        }

        [Test]
        public void FizzBuzzTest1()
        {
            byte number = 15;
            string expected = "FizzBuzz-Buzz : Fifteen";
            string result = _fizzBuzzTranslate.Traslate(number);
            Assert.IsTrue(result==expected);
        }
        [Test]
        public void FizzBuzzTest2()
        {
            byte number = 33;
            string expected = "Fizz-Fizz-Fizz : Thirty three";
            string result = _fizzBuzzTranslate.Traslate(number);
            Assert.IsTrue(result == expected);
        }
        [Test]
        public void FizzBuzzTest3()
        {
            byte number = 7;
            string expected = "Number 7 : Seven";
            string result = _fizzBuzzTranslate.Traslate(number);
            Assert.IsTrue(result == expected);
        }
    }
}