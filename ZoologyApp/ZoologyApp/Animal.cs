using System;
using System.Collections.Generic;
using System.Text;

namespace ZoologyApp
{
    /// <summary>
    /// Class that represents an animal
    /// </summary>
    class Animal
    {
        public int Legs { get; set; }
        public string Name { get; set; }
        public string Sound { get; set; }

        /// <summary>
        /// Empty constructor that generates a dog
        /// </summary>
        public Animal()
        {
            Legs = 4;
            Name = "Dog";
            Sound = "Woof";
        }

        /// <summary>
        /// Constructor that generates an animal with all available properties
        /// </summary>
        /// <param name="legs">int, Number of legs</param>
        /// <param name="name">string, Name of the animal</param>
        /// <param name="sound">string, Sound the animal makes</param>
        public Animal(int legs, string name, string sound)
        {
            Legs = legs;
            Name = name;
            Sound = sound;
        }

        /// <summary>
        /// Prints out a string representation of an animal
        /// </summary>
        /// <returns>String representation, ex: "Legs: {}, Name: {}, Sound: {}"</returns>
        public override string ToString()
        {
            return $"Legs: {Legs}, Name: {Name}, Sound: {Sound}";
        }

        /// <summary>
        /// Prints the sound of an animal
        /// </summary>
        /// <param name="animal">Animal to display the sound of</param>
        public static void MakeSound(Animal animal)
        {
            Console.WriteLine($"{animal.Name} goes {animal.Sound}");
        }
    }
}
