using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    class Person
    {
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public static List<Person> getNames()
        {
            return new List<Person>
            {
                new Person("Joe Biden"),
                new Person("Queen Elizabeth")
            };
        }
    }
}
