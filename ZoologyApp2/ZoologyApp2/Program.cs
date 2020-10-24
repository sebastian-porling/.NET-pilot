using System;
using System.Collections.Generic;

namespace ZoologyApp2
{
    /// <summary>
    /// Main app that can generate animals
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method,
        /// Generates animals and displays them
        /// </summary>
        /// <param name="args">Arguments ignored</param>
        static void Main(string[] args)
        {
            PrintAnimals(GenerateAnimals());
        }

        /// <summary>
        /// Generates a list of animals
        /// </summary>
        /// <returns>List of animals</returns>
        static List<Animal> GenerateAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Mammal());
            animals.Add(new Bird(2, "Flamingo", "Skreek"));
            animals.Add(new Mammal(4, "Dear", "Peep"));
            animals.Add(new Amphibian());
            animals.Add(new Reptile(0, "Python", "Szszszsz"));
            animals.Add(new Bird());
            return animals;
        }

        /// <summary>
        /// Prints a list of animals
        /// </summary>
        /// <param name="animals">List of animals to print out</param>
        static void PrintAnimals(List<Animal> animals)
        {
            Console.WriteLine("#### ANIMALS ####");
            animals.ForEach(Console.WriteLine);
            animals.ForEach(Animal.MakeSound);
        }
    }
}
