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
            Console.WriteLine("Enter a search query (full name or part of name): ");
            string query = Console.ReadLine();
            List<Person> persons = getYellowPages();
            Console.WriteLine("\nFull Matches: ");
            getFullMatches(query, persons).ForEach(Console.WriteLine);
            Console.WriteLine("\nPartial Matches: ");
            getPartialMatches(query, persons).ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Generates five persons in a person list
        /// </summary>
        /// <returns>A person list</returns>
        static List<Person> getYellowPages()
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
        static List<Person> getFullMatches(string query, List<Person> persons)
        {
            return persons.FindAll(person => person.FullMatch(query));
        }

        /// <summary>
        /// Returns all persons that matches the search query
        /// </summary>
        /// <param name="query">Search query</param>
        /// <param name="persons">List of persons</param>
        /// <returns>List of persons that matches the search query</returns>
        static List<Person> getPartialMatches(string query, List<Person> persons)
        {
            return persons.FindAll(person => person.PartialMatch(query));
        }
    }
}
