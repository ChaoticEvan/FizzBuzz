using System;

namespace FizzBuzz
{
    /// <summary>
    /// Very basic program to play the game of FizzBuzz
    /// </summary>
    public static class FizzBuzz
    {
        /// <summary>
        /// Program running to play the game FizzBuzz. It will print out numbers from a lower int index (inclusive) to the high int index (non-inclusive)
        /// while following the rules of the game.
        /// 
        /// I was inspired to write this by this YouTube video: https://www.youtube.com/watch?v=QPZ0pIK_wsc&t=135s
        /// The rules are described in the video in a bit more detail.
        /// </summary>
        /// <param name="args">Argument 0 is the lower index, and argument 1 is the higher index. If given anything that doesn't convert to an int
        /// it will not print anything.</param>
        public static void Main(string[] args)
        {
            // Parse in the user's given inputs
            Int32.TryParse(args[0], out int lo);
            Int32.TryParse(args[1], out int hi);

            for (int i = lo; i < hi; ++i)
            {
                bool wasPrinted = false;

                // Here is the logic of the game
                if ((i % 3) == 0)
                {
                    Console.Write("Fizz");
                    wasPrinted = true;
                }
                if ((i % 5) == 0)
                {
                    Console.Write("Buzz");
                    wasPrinted = true;
                }

                // If we already printed something, then we don't print the current number
                if (!wasPrinted)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
