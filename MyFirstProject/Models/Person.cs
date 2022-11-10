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
            Name = name;
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
                new Person("Xi Jing Ping", "https://lumiere-a.akamaihd.net/v1/images/c94eed56a5e84479a2939c9172434567c0147d4f.jpeg?region=0,0,600,600&width=480"), 
                new Person("Queen Elizabeth", "https://hips.hearstapps.com/hmg-prod/images/britains-queen-elizabeth-ii-presents-the-george-cross-to-news-photo-1657645419.jpg?crop=0.66699xw:1xh;center,top&resize=640:*"),
                new Person ("Joe Biden", "https://media.npr.org/assets/img/2022/06/18/ap22169522843878-654166ca643c44cd281262ac353546a0af90f377.jpg")
            };
        }
    }
}
