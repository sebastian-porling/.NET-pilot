using System;

namespace FirstConsoleApp
{
    /// <summary>
    /// A simple Console Application that prints out a greeting
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry for a console application that creates a greeting based on user input
        /// </summary>
        /// <param name="args">Arguments ignored</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Anon! Enter your name:");
            string name;
            while ((name = Console.ReadLine()).Length < 1) { }
            Console.WriteLine($"Hello {name}!, " +
                $"your name is {name.Replace(" ", "").Length} " +
                $"characters long and starts with a {name.Substring(0, 1)}");
            
        }
    }
}
