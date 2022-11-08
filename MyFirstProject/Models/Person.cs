using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    class Person
    {
        public string Name { get; set; }
        public string URI { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string uri)
        {
            URI = uri;
        }

        public static List<Person> GetNames()
        {
            return new List<Person>
            {
                new Person("Xi Jing Ping"),
                new Person("Queen Elizabeth"),
                new Person ("Joe Biden")
            };
        }

        public static List<Person> GetNameImages()
        {
            return new List<Person>
            {
                new Person("Xi Jing Ping"), //START HERE, add second parameter - URI image link
                new Person("Queen Elizabeth"),
                new Person ("Joe Biden")
            };
        }
    }
}
