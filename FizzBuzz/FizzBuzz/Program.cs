using System;

namespace FizzBuzz
{
    /// <summary>
    /// Very basic program to play the game of FizzBuzz
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program running to play the game FizzBuzz. It will print out numbers from a lower index (inclusive) to the high index (non-inclusive)
        /// while following the rules of the game.
        /// 
        /// I was inspired to write this by this YouTube video: https://www.youtube.com/watch?v=QPZ0pIK_wsc&t=135s
        /// The rules are described in the video in a bit more detail.
        /// </summary>
        /// <param name="args">Argument 0 is the lower index, and argument 1 is the higher index.</param>
        static void Main(string[] args)
        {
            Int32.TryParse(args[0], out int lo);
            Int32.TryParse(args[1], out int hi);

            for (int i = lo; i < hi; ++i)
            {
                bool wasPrinted = false;
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
                if (!wasPrinted)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
