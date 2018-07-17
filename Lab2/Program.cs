using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            // Creates string for user input to be stored in when asked to continue and to be referenced in the while loop.
            string ContinueUserInput;

            // Creates do-while loop that will repeat the code when the user requests it.
            do
            {

                // Asks user to input 3 values, and parses them into double variables.
                Console.WriteLine("Please enter the length, width, and height of the room you would like details on.");
                Console.Write("Enter length: ");
                string LengthInput = Console.ReadLine();
                double LengthParse = double.Parse(LengthInput);

                Console.Write("Enter width: ");
                string WidthInput = Console.ReadLine();
                double WidthParse = double.Parse(WidthInput);

                Console.Write("Enter height: ");
                string HeightInput = Console.ReadLine();
                double HeightParse = double.Parse(HeightInput);

                // Calculates area, perimeter, and volume using values provided by user, and prints each one to the console.
                double AreaResult = LengthParse * WidthParse;
                double PerimeterResult = (2 * LengthParse) + (2 * WidthParse);
                double VolumeResult = LengthParse * WidthParse * HeightParse;

                Console.WriteLine($"Area: {AreaResult}");
                Console.WriteLine($"Perimeter: {PerimeterResult}");
                Console.WriteLine($"Volume: {VolumeResult}");

                // Asks user if they would like to try the inputs again. If they do not put y, ends the loop and therefore the program.
                Console.WriteLine("Would you like details on another room? (y/n): ");
                ContinueUserInput = Console.ReadLine();
            }

            while (ContinueUserInput.Equals("y", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
