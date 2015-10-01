using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    /// <summary>
    ///     Provides functionality to enumerate through a range of values and test for divisibility.
    /// </summary>
    public class FizzBuzz
    {
        #region CONSTRUCTOR

        /// <summary>Initializes a new instance of the <see cref="FizzBuzz" /> class.</summary>
        /// <param name="startIndex">The initial value of the range to start FizzBuzz with.</param>
        /// <param name="endIndex">The value to stop FizzBuzz on, this must be more than <paramref name="startIndex" /> value.</param>
        /// <exception cref="ArgumentException"><paramref name="endIndex" /> is less than <paramref name="startIndex" />.</exception>
        public FizzBuzz(int startIndex, int endIndex)
        {
            if (endIndex < startIndex)
                throw new ArgumentException("The endIndex can not be less than the startIndex", "endIndex");

            _startIndex = startIndex;
            _endIndex = endIndex;
        }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        ///     Returns an enumerator that iterates through the results.
        /// </summary>
        /// <returns>
        ///     "Fizz" if the number is divisible by 3,
        ///     "Buzz" if the number is divisible by 5,
        ///     "FizzBuzz" if the number is divisible by both 3 and 5,
        ///     and just the value if it's neither.
        /// </returns>
        public IEnumerable<string> GetResults()
        {
            // Note: Using 'long' type to allow special case of _startIndex = Int32.MinValue and _endIndex = Int32.MaxValue
            //       Otherwise using an 'int' type would cause and infinte loop.
            for (long i = _startIndex; i <= _endIndex; i++)
            {
                yield return RunFizzBuzzTest(i);
            }
        }

        #endregion

        #region PRIVATE METHODS

        private string RunFizzBuzzTest(long i)
        {
            var result = string.Empty;
            var bIsMultiplyOf3 = (i % 3 == 0);
            var bIsMultiplyOf5 = (i % 5 == 0);

            if (bIsMultiplyOf3)
                result = "Fizz";

            if (bIsMultiplyOf5)
                result += "Buzz";

            if (!bIsMultiplyOf3 && !bIsMultiplyOf5)
                result = i.ToString();

            return result;
        }

        #endregion

        #region PRIVATE MEMBERS
        
        private readonly int _startIndex;
        private readonly int _endIndex;
        
        #endregion
    }
}