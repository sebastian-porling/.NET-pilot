using System;
using System.Linq;

namespace PrintSquareApp
{
    /// <summary>
    /// This class represents a Rectangle/Square
    /// </summary>
    class Rectangle
    {
        public int Heigth { get; set; }
        public int Width { get; set; }
        public string Character { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="heigth">Height of rectangle</param>
        /// <param name="width">Width of rectangle</param>
        /// <param name="character">Character to print the rectangle with</param>
        public Rectangle(int heigth, int width, string character)
        {
            Heigth = heigth;
            Width = width;
            Character = character;
        }

        /// <summary>
        /// Returns the string representation of a rectangle/square
        /// </summary>
        /// <returns>String representation of the rectangle</returns>
        public override string ToString()
        {
            return GeneratePrintable();
        }

        /// <summary>
        /// Generates a printable square of the dimensions of this square class printed with the class character
        /// </summary>
        /// <returns>String representing a square</returns>
        private string GeneratePrintable()
        {
            string rectangleOutput = "";
            Func<int, int, bool> isCharacter = (int h, int w) => h == 0 || h == Heigth - 1 || w == 0 || w == Width - 1;
            foreach (int heigth in Enumerable.Range(0, Heigth))
            {
                foreach (int width in Enumerable.Range(0, Width))
                    rectangleOutput += isCharacter(heigth, width) ? Character : " ";
                rectangleOutput += "\n";
            }
            return rectangleOutput;
        }
    }
}
