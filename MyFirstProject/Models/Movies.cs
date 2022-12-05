using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Movies
    {
        public string Name { get; set; }
        public Movies (string name)
        {
            Name = name;
        }

        public Movies()
        {

        }

        public static List<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies("test0"),
                new Movies("test1"),
                new Movies("test2"),
                new Movies("test3")
            };
        }
    }
}
