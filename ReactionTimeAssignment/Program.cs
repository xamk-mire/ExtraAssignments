using System.Diagnostics;

namespace ReactionTimeAssignment
{
    internal class Program
    {
        // Create an application that measures the user's reaction time.
        // Record 3-5 reaction times from the user and then inform them of their average reaction speed.
        // Additionally, you can implement a High Score feature using a Dictionary.
        // Store in the Dictionary the user's name as the key and their reaction time as the value.
        // Display the High Score list after each completed game.
        // The High Score list can only have five names at a time.
        // If a new result is better than the ones on the list, remove the worst score from there and add the new one.
        // Also, the High Score list should always be printed so that the best player is first.

        // The user can then continue to play or exit the program.

        // NOTE: You are free to implement the program the way you like, but it's good idea to use this exercise to
        //       practice using methods too.

        static void Main(string[] args)
        {
            // Create a new random object
            Random random = new Random();
            // Set a random time between 1-5 seconds.
            int sleepTime = random.Next(1000, 5000);
            // Wait for a random time between 1-5 seconds.
            Thread.Sleep(sleepTime);

            // Start the timer.
            Stopwatch stopwatch = Stopwatch.StartNew();
            // Stop the timer.
            stopwatch.Stop();
            // Record the reaction time.
            double reactionTime = stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}