using System;

namespace Basic
{
    class Program
    {
        /// <summary>
        /// Configuration
        /// </summary>

        // Enter your factors here
        static int[] factors = new int[] { 3, 5 };

        // Enter here your words to be displayed when a factor appears.
        // Write the words in the same order of the factors array
        static string[] factorWords = new string[] { "Fizz", "Buzz" };

        // The highest number that we should go to
        static int maxNumber = 100;

        /// <summary>
        /// Main code
        /// </summary>
        /// <param name="args">Array of console arguments</param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                string output = "";

                // Test for the factors provided and apply the words that are needed
                for (int i2 = 0; i2 < factors.Length; i2++)
                {
                    if (i % factors[i2] == 0)
                        output += factorWords[i2];
                }

                // Check if there are no factors applied for this number.
                // If so, set the output to the number
                if (output == "")
                    output = i.ToString();

                // Write our final product to the console
                Console.WriteLine(output);
            }

            // "Pause" the console so you can see the numbers
            Console.ReadKey();
        }
    }
}
