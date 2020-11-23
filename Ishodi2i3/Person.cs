using System;
using System.Collections.Generic;
using System.Text;

namespace Ishodi2i3
{
    abstract class Person
    {
        protected Person(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"First name: {FirstName}, last name: {LastName}";

    }
}
