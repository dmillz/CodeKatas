using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.FizzBuzz;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void FizzBuzz_NonFizzBuzzers()
        {
            FizzBuzzer fizzbuzzer = new FizzBuzzer();
            Assert.AreEqual("1", fizzbuzzer.FizzBuzz(1));
            Assert.AreEqual("2", fizzbuzzer.FizzBuzz(2));
            Assert.AreEqual("4", fizzbuzzer.FizzBuzz(4));
            Assert.AreEqual("7", fizzbuzzer.FizzBuzz(7));
            Assert.AreEqual("8", fizzbuzzer.FizzBuzz(8));
            Assert.AreEqual("11", fizzbuzzer.FizzBuzz(11));
            Assert.AreEqual("14", fizzbuzzer.FizzBuzz(14));
            Assert.AreEqual("98", fizzbuzzer.FizzBuzz(98));
            Assert.AreEqual("101", fizzbuzzer.FizzBuzz(101));
        }

        [Test]
        public void FizzBuzz_FizzOn3()
        {
            FizzBuzzer fizzbuzzer = new FizzBuzzer();
            Assert.AreEqual("fizz", fizzbuzzer.FizzBuzz(3));
        }

        [Test]
        public void FizzBuzz_BuzzOn5()
        {
            FizzBuzzer fizzbuzzer = new FizzBuzzer();
            Assert.AreEqual("buzz", fizzbuzzer.FizzBuzz(5));
        }


        [Test]
        public void FizzBuzz_FizzBuzzOn15()
        {
            FizzBuzzer fizzbuzzer = new FizzBuzzer();
            Assert.AreEqual("fizzbuzz", fizzbuzzer.FizzBuzz(15));
        }
    }
}
