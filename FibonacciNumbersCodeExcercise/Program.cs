using System;

namespace FibonacciNumbersCodeExcercise
{
    class Program
    {
        /// <summary>
        /// In mathematics, the Fibonacci numbers, commonly denoted Fₙ, form a sequence, 
        /// called the Fibonacci sequence, such that each number is the sum of the two preceding ones, 
        /// starting from 0 and 1. That is, and for n > 1.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the sequence size:");
            int sequenceSize = Convert.ToInt32(Console.ReadLine());

            int result = GetFibonacciResult(sequenceSize);
            Console.WriteLine("Fibonacci result: " + result.ToString());

            Console.WriteLine("Please type any key to end the test.");
            Console.ReadLine();
        }

        #region Private methods

        /// <summary>
        /// Return Fibonacci results.
        /// </summary>
        /// <param name="sequenceSize"></param>
        /// <returns></returns>
        private static int GetFibonacciResult(int sequenceSize)
        {
            int fibonacciFinalResult = 0;

            // Initializes the fibonacci sequence
            int[] fibonacciLastSequenceResults = InitializeFibonacciSequence();

            for (int i = 0; i <= sequenceSize; i++)
            {
                // Return the first two numbers in the sequence, 0 and 1.
                fibonacciFinalResult = i;

                // If itering after de second item, then start sumarizing.
                if (i > 1)
                {
                    // Get the next final result in the sequence
                    fibonacciFinalResult = fibonacciLastSequenceResults[1] + fibonacciLastSequenceResults[0];

                    // Move the last index result to the first index
                    fibonacciLastSequenceResults[0] = fibonacciLastSequenceResults[1];

                    // Set the result in the last index
                    fibonacciLastSequenceResults[1] = fibonacciFinalResult;
                }
            }

            // Return the final result.
            return fibonacciFinalResult;
        }

        /// <summary>
        /// Initializes the fibonacci sequence
        /// </summary>
        /// <returns></returns>
        public static int[] InitializeFibonacciSequence()
        {
            return new int[] { 0, 1 };
        }

        #endregion
    }
}
