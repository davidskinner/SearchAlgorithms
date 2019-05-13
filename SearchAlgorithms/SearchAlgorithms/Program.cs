using System;

namespace SearchAlgorithms
{
    class Program
    {
        /// <summary>
        /// Returns the position in the array.
        /// Took 10 seconds to implement.
        /// </summary>
        /// <param name="value">The value you are looking for.</param>
        /// <param name="Array">The array to look in.</param>
        /// <returns></returns>
        public static bool LinearSearchIterative(int value, int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if(Array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Stopping conditions for this recursive function are that we reach the end of the array or we find the value.
        /// Took longer than I will say to implement.
        /// </summary>
        /// <param name="value">The value we are looking for.</param>
        /// <param name="Array">The array we are searching through.</param>
        /// <param name="position">Our place in the array.</param>
        /// <param name="recurse">The truth value of whether or not the array contains the value.</param>
        /// <returns></returns>
        public static bool LinearSearchRecursive(int value, int[] Array, int position, bool recurse)
        {
            if (position == Array.Length - 1)
            {
                return false;
            }

            if (Array[position] == value)
            {
                return true;
            }

            // hang on to 'recurse' through the call stack
            recurse = LinearSearchRecursive(value, Array, ++position,recurse);
            return recurse;
        }

        static void Main(string[] args)
        {
            int[] integerArray = { 2, 3, 4, 7, 2, 1, -1, 4, 6, 3, 2, 33, 75};
            //int[] integerArray = {2,3,4};

            bool answer = false;
            int position = 0;
            bool recurse = false;
            ////bool answer = linearSearchIterative(2, integerArray);
            answer = LinearSearchRecursive(7, integerArray, position,recurse);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
