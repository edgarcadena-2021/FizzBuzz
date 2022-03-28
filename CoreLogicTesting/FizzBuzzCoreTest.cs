using CoreLogic;
using NUnit.Framework;
using System;

namespace CoreLogicTesting
{
    [TestFixture]
    public class FizzBuzzCoreTest
    {
        private FizzBuzzCore _fizzBuzz;
        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzzCore();
        }
        [Test]
        public void FizzBuzz_InputIs1_and_5_EqualsToResult()
        {
            var result = _fizzBuzz.FizzBuzz(new int[] {1, 5 });

            Assert.AreEqual(result, new string[] {  "Divided 1 by 3 / Divided 1 by 5", "Buzz" });
        }

        [Test]
        public void FizzBuzz_InputIs15_EqualsToFizzBuzz()
        {
            var result = _fizzBuzz.performValidation(15);

            Assert.AreEqual(result, "FizzBuzz");
        }

        [Test]
        public void FizzBuzz_InputIsString_NotEqualToInt()
        {
            var result = _fizzBuzz.isValidInput(TypeCode.String);

            Assert.AreNotEqual(result, TypeCode.Int32);
        }

        [Test]
        public void FizzBuzz_InputIs27_IsDivisibleBy3True()
        {
            var result = _fizzBuzz.isDivisibleBy3(27);

            Assert.IsTrue(result);
        }

        [Test]
        public void FizzBuzz_InputIs15_IsDivisibleBy5True()
        {
            var result = _fizzBuzz.isDivisibleBy5(15);

            Assert.IsTrue(result);
        }

        [Test]
        public void FizzBuzz_InputIs15_IsDivisibleByBoth()
        {
            var result = _fizzBuzz.isDivisibleByBoth(15);

            Assert.IsTrue(result);
        }

    }
}
