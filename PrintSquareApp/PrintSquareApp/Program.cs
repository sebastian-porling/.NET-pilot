using System;

namespace PrintSquareApp
{
    /// <summary>
    /// This program takes in user input to generate a s
    /// quare/rectangle of any size printed with any character.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Takes in user input to generate the square/rectangle then prints it to console.
        /// </summary>
        /// <param name="args">Arguments ignored</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the rectangle/square (3x6, 2x2, etc): ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter character to print the rectangle/square with (ex. #, * etc): ");
            string character = Console.ReadLine();
            try
            {
                Console.WriteLine(parseUserInput(userInput, character));
            }
            catch (Exception e)
            {
                Console.WriteLine("Not valid rectangle/square");
            }
        }

        /// <summary>
        /// Parses the user input for the size of rectangle/square and character to print with.
        /// </summary>
        /// <param name="userInput">User input formated like 3x3, 9x19 etc...</param>
        /// <param name="character">A single character</param>
        /// <returns>A Rectangle object</returns>
        static Rectangle parseUserInput(string userInput, string character)
        {
            string[] userInputParts = userInput.Split('x');
            return new Rectangle(parseSide(userInputParts[0]), parseSide(userInputParts[1]), parseCharacter(character));
        }

        /// <summary>
        /// Makes sure that the side is positive,
        /// error is thrown if the parameter is non integer.
        /// </summary>
        /// <param name="side">Size of a side of a rectangle/square</param>
        /// <returns>Integer value of the side</returns>
        static int parseSide(string side)
        {
            return Math.Abs(Int32.Parse(side));
        }

        /// <summary>
        /// Makes sure that the characters is only one character.
        /// Otherwise we return a default value.
        /// </summary>
        /// <param name="character">Character to print the rectangle/square with</param>
        /// <returns>String with a single character</returns>
        static string parseCharacter(string character)
        {
            try
            {
                return character.Substring(0, 1);
            }
            catch (Exception e)
            {
                return "#";
            }
        }
    }
}
