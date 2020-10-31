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
        /// </summary>
        /// <param name="value">The value we are looking for.</param>
        /// <param name="Array">The array we are searching through.</param>
        /// <param name="position">Our place in the array.</param>
        /// <param name="truthValue">The truth value of whether or not the array contains the value.</param>
        /// <returns></returns>
        public static bool LinearSearchRecursive(int value, int[] Array, int position, bool truthValue)
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
            truthValue = LinearSearchRecursive(value, Array, ++position,truthValue);
            return truthValue;
        }

        /// <summary>
        /// Increment the positions of the max and min of the sub-array based on whether or not the value you are looking for is higher
        /// or lower than where you currently are.
        /// Pretty simple to reason through, and easy to implement.
        /// </summary>
        /// <param name="value">The value you are looking for.</param>
        /// <param name="Array">The integer array to search through,</param>
        /// <returns>The truth value of whether or not value is in Array.</returns>
        public static bool BinarySearchIterative(int value, int[] Array)
        {
            // { 0, 1, 2, 3, 4, 5, 6, 7 };
            int min = 0;
            int max = Array.Length-1;
            int pos = (max + min) / 2;

            while(min != max)
            {
                if(Array[pos] < value)
                {
                    min = pos + 1;
                    pos = (max + min) / 2;
                }
                else if(Array[pos] > value)
                {
                    max = pos - 1;
                    pos = (max + min) / 2;
                }
                
                // if you do not check position here, you risk skipping the end points 
                if (Array[pos] == value)
                {
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>
        /// Flip the logic for the ending condition from the iterative approach. 
        /// Otherwise this is extremely similar to the iterative approach.
        /// </summary>
        /// <param name="value">The value you are looking for.</param>
        /// <param name="Array">The array to look through.</param>
        /// <param name="max">The max value of the sub-array.</param>
        /// <param name="min">The min value of the sub-array.</param>
        /// <param name="pos">The current position in the sub-array.</param>
        /// <param name="truthValue">Bool value used to hang on to the search result through the callstack.</param>
        /// <returns></returns>
        public static bool BinarySearchRecursive(int value, int[] Array, int max, int min, int pos, bool truthValue)
        {
            truthValue = false;

            if(Array[pos] == value)
            {
                return true;
            }
            if(min == max)
            {
                return false;
            }

            if(Array[pos] < value)
            {
                min = pos + 1;
                pos = (max + min) / 2;
                truthValue = BinarySearchRecursive(value, Array, max, min, pos, truthValue);
            }
            else if (Array[pos] > value)
            {
                max = pos - 1;
                pos = (max + min) / 2;
                truthValue = BinarySearchRecursive(value, Array, max, min, pos, truthValue);
            }
            return truthValue;
        }

        static void Main(string[] args)
        {
            int[] integerArray = { 2, 3, 4, 7, 2, 1, -1, 4, 6, 3, 2, 33, 75};
            int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7 };

            bool answer = false;
            //answer = LinearSearchIterative(2, integerArray);
            //answer = LinearSearchRecursive(7, integerArray, position,recurse);
            //answer = BinarySearchIterative(5, sortedArray);
            //answer = BinarySearchRecursive(6, sortedArray, sortedArray.Length - 1, 0, (sortedArray.Length - 1 + 0) / 2, false);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
