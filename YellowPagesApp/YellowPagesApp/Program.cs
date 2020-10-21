using System;
using System.Collections.Generic;

namespace YellowPagesApp
{
    /// <summary>
    /// The Yellow Page application that can search through a catalog of persons
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program,
        /// Takes in search query from user and prints the full matches and partial matches
        /// </summary>
        /// <param name="args">Arguments ignored</param>
        static void Main(string[] args)
        {
            string query = GetUserInput();
            List<Person> persons = GetYellowPages();
            PrintResult(query, GetFullMatches(query, persons), GetPartialMatches(query, persons));
        }

        /// <summary>
        /// Prints out the result of the search query for full and partial matches
        /// </summary>
        /// <param name="query">String, search query</param>
        /// <param name="fullMatches">List of persons, full mathces of the search query</param>
        /// <param name="partialMatches">List of persons, partial matches of the search query</param>
        /// <returns></returns>
        static void PrintResult(string query, List<Person> fullMatches, List<Person> partialMatches)
        {
            Console.WriteLine("======= RESULT ========");
            Console.WriteLine($"\nSearch Query: {query}");
            Console.WriteLine("\nFull Matches; ");
            fullMatches.ForEach(Console.WriteLine);
            Console.WriteLine("\nPartial Matches: ");
            partialMatches.ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Gets the search query from the user input
        /// </summary>
        /// <returns>Search query</returns>
        static string GetUserInput()
        {
            Console.WriteLine("Enter a search query (full name or part of name): ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Generates five persons in a person list
        /// </summary>
        /// <returns>A person list</returns>
        static List<Person> GetYellowPages()
        {
            List < Person > yellowPages = new List<Person>();
            yellowPages.Add(new Person("Sean", "Skinner"));
            yellowPages.Add(new Person("Sebastian", "Porling"));
            yellowPages.Add(new Person("James", "Bond"));
            yellowPages.Add(new Person("Sean", "Connor"));
            yellowPages.Add(new Person("David", "Stjernqvist"));
            return yellowPages;
        }

        /// <summary>
        /// Returns all persons that are equal to the search query
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="persons">Lis tof persons</param>
        /// <returns>List of persons that are equal to the search query</returns>
        static List<Person> GetFullMatches(string query, List<Person> persons)
        {
            return persons.FindAll(person => person.FullMatch(query));
        }

        /// <summary>
        /// Returns all persons that matches the search query
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="persons">List of persons</param>
        /// <returns>List of persons that matches the search query</returns>
        static List<Person> GetPartialMatches(string query, List<Person> persons)
        {
            return persons.FindAll(person => person.PartialMatch(query));
        }
    }
}
