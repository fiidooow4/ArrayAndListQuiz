using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This will be an exercise in array and list creation!");
            Console.WriteLine("Try to get the lowest possible score...");
            Console.WriteLine("Hit any key to begin the quiz and start the timer");
            Console.ReadLine();

            Stopwatch sw = Stopwatch.StartNew();
            int wrongCount = 0;

            AskQuestion("Using inferred typing: create a new array named numbers that will hold 5 integers:", "var numbers = new int[5];", ref wrongCount);
            AskQuestion("Using explicit typing: create a new array named numbers that will hold 5 integers:", "int[] numbers = new int[5];", ref wrongCount);
            // Add more questions...

            var time = sw.Elapsed.TotalSeconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            int score = (int)((time * 0.4) + (wrongCount * 0.6));

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();
        }

        static void AskQuestion(string prompt, string answer, ref int wrongCount)
        {
            var guess = "";
            do
            {
                Console.WriteLine(prompt);
                guess = Console.ReadLine();
                if (guess == answer)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
            } while (answer != guess);
        }
    }
}
