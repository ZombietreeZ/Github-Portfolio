// Title: Add and Multiply Four Integers
// Class: IT-230-14203-M01 Software Development
// Name: Santiago, Giovanni
// Date: 01/14/2024
// Instructor: Dr. Steven Satterfield
//
// Descriptione: This is a basic C# program that take the inputs from the user Then adds and multiplies those inputs and
// displays it back to the user. First, the program asks the person to type 4 numbers, like 13,55,123,325.
// It keeps asking until the person actually types something. When the numbers are entered,
// the program cuts the long text into little pieces wherever it sees a comma. Then the program adds and multiplies these numbers,
// and turned into a real number. All of the numbers are placed into a list so the program can read them back to the user as:
// "The sum of 13,55,123 and 325 = 515
// The product of 13, 55, 123, and 325 = 28582125.
// Next, the program makes the list of numbers look nice for a sentence by putting commas between them and the word
// “and” before the last number. Then it adds all the numbers together to get the sum, and multiplies all the numbers
// to get the product. Finally, it prints two clean messages: one that shows the sum of the numbers, and one that shows
// the product of the numbers. Building the sentence format and calculating the sum and product are done using  
//
// errors encountered:
// While making the program, I made some mistakes like spelling words wrong, forgetting semicolons, and putting parentheses.
// For example, I wrote "Converto" instead of "Convert" and missed a semicolon after a line. this stoped the program from working and made 
// error messages appear. Than just printed a hello world, but the error messages helped me fix them.
// After fixing those, the program worked the way it was supposed to.
// 
using System; // import System namespace
using System.Collections.Generic; // import Collections.Generic namespace
using System.Linq; //   import Linq namespace


namespace Santiago_Giovanni_addmultiplyfourints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawInput = ""; // Initialize rawInput to an empty string
            List<int> intValues = new List<int>(); // Create a list to hold integer values

            while (String.IsNullOrEmpty(rawInput)) // loop input until something happens
            {
                // Prompt user for input giving example format

                Console.WriteLine("Enter a list of integer values separated by a comma (example:13,55,123,325)");
                rawInput = Console.ReadLine() ?? ""; // Read user input
            }

            string[] arrIntStrings = rawInput.Split(','); // Split input string into an array using comma as delimiter

            // Convert strings to ints

            foreach (string intString in arrIntStrings)
            {
                intValues.Add(Convert.ToInt32(intString.Trim())); // Trim whitespace and convert to int, then add to list
            }

            // Build a sentence format: "13, 55, 123, and 325"

            string formattedList = String.Join(", ", intValues.Take(intValues.Count - 1)) // Join all but the last value with commas
                                   + ", and " + intValues.Last(); // Format the list for output

            // Add the input values together and than multiply them

            int sum = intValues.Sum(); // adding values together 
            int product = intValues.Aggregate(1, (acc, val) => acc * val); // Multiply all values together

            // Print the results to console 

            Console.WriteLine($"The sum of {formattedList} = {sum}"); // made a list that formats the sum as a sentence
            Console.WriteLine($"The product of {formattedList} = {product}"); // made a list that formats the product as a sentence
        }

        }
    }

