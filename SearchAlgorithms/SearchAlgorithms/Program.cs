using System;

namespace SearchAlgorithms
{
    class Program
    {
        /// <summary>
        /// Returns the position in the array
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
