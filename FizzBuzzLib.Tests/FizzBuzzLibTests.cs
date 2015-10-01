using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzLib.Tests
{
    [TestFixture]
    public class FizzBuzzLibTests
    {
        [Test]
        [Description(("This test will enumerate through values 1 to 15."))]
        public void ValidateInputs_1_To_15()
        {
            int i = 0;
            List<string> results = new List<string> { "1", "2", "Fizz", "4", "Buzz", 
                                                      "Fizz", "7", "8", "Fizz", "Buzz", 
                                                      "11", "Fizz", "13", "14", "FizzBuzz" };

            FizzBuzz fb = new FizzBuzz(1, 15);

            foreach (string s in fb.GetResults())
                Assert.AreEqual(results[i++], s);
        }

        [Test]
        [Description(("This test will enumerate through values 1 to 100 and validate values that should be divisible by 3."))]
        public void ValidateInputs_DivisibleBy3()
        {
            int i = 1;

            FizzBuzz fb = new FizzBuzz(1, 100);

            foreach (string s in fb.GetResults())
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Assert.AreEqual("Fizz", s);

                i++;
            }
        }

        [Test]
        [Description(("This test will enumerate through values 1 to 100 and validate values that should be divisible by 5."))]
        public void ValidateInputs_DivisibleBy5()
        {
            int i = 1;

            FizzBuzz fb = new FizzBuzz(1, 100);

            foreach (string s in fb.GetResults())
            {
                if (i % 5 == 0 && i % 3 != 0)
                    Assert.AreEqual("Buzz", s);

                i++;
            }
        }

        [Test]
        [Description(("This test will enumerate through values 1 to 100 and validate values that should be divisible by 3 and 5."))]
        public void ValidateInputs_DivisibleBy3And5()
        {
            int i = 1;

            FizzBuzz fb = new FizzBuzz(1, 100);

            foreach (string s in fb.GetResults())
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Assert.AreEqual("FizzBuzz", s);

                i++;
            }
        }

        [Test]
        [Description(("This test will enumerate through values 1 to 100 and validate values that should not be divisible by 3 and 5."))]
        public void ValidateInputs_NotDivisibleBy3Or5()
        {
            int i = 1;

            FizzBuzz fb = new FizzBuzz(1, 100);

            foreach (string s in fb.GetResults())
            {
                if (i % 5 != 0 && i % 3 != 0)
                    Assert.AreEqual(i.ToString(), s);

                i++;
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        [Description(("This will test the construction with invalid startIndex and endIndex input parameters."))]
        public void ValidateInvalidInputs()
        {
            FizzBuzz fb = new FizzBuzz(100, 1);
        }

        [Test]
        [Category("LongTests")]
        [Description(("This test will enumerate through all values for Int32 and will take 8-10mins to complete."))]
        public void ValidateInputs_MaxAndMinRange()
        {
            long i = Int32.MinValue;
            bool bMarkerHit = false;

            FizzBuzz fb = new FizzBuzz(Int32.MinValue, Int32.MaxValue);

            foreach (string s in fb.GetResults())
            {
                if (i == Int32.MinValue + 1)
                {
                    if (bMarkerHit)
                    {
                        Assert.Fail("The enumeration is in an infinte loop.");
                    }
                    else
                    {
                        bMarkerHit = true;
                    }
                }

                i++;
            }
        }
    }
}
