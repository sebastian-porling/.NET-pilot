using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace YellowPagesApp
{
    /// <summary>
    /// Represents a person with first and lastname
    /// </summary>
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get;  }
        public string FullName { get => $"{FirstName} {LastName}"; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName">String, persons firstname</param>
        /// <param name="lastName">String, persons lastname</param>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = "XXX-XXX XX XX";
        }

        public Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Checks if query is equal to the fullname
        /// </summary>
        /// <param name="query">String, search query</param>
        /// <returns>True if full match</returns>
        public bool FullMatch(string query)
        {
            return FullName.ToLower().Equals(query.ToLower());
        }

        /// <summary>
        /// Checks if query matches the fullname
        /// </summary>
        /// <param name="query">String, search query</param>
        /// <returns>True if query matches the name in any way</returns>
        public bool PartialMatch(string query)
        {
            return FullName.ToLower().Contains(query.ToLower());
        }

        /// <summary>
        /// String representation of the person class
        /// </summary>
        /// <returns>Fullname of the person</returns>
        public override string ToString()
        {
            return $"{FullName}: {PhoneNumber}";
        }
    }
}
