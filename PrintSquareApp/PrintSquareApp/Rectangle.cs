using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// Generates a printable rectangle with the dimensions and character of the class.
        /// </summary>
        /// <returns>String representation of the rectangle</returns>
        public override string ToString()
        {
            string rectangleOutput = "";
            Func<int, int, bool> isCharacter = (int h, int w) => h == 0 || h == Heigth - 1 || w == 0 || w == Width - 1;
            foreach (int h in Enumerable.Range(0, Heigth))
            {
                foreach (int w in Enumerable.Range(0, Width))
                    rectangleOutput += isCharacter(h, w) ? Character : " ";
                rectangleOutput += "\n";
            }
            return rectangleOutput;
        }
    }
}
