using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class Vacation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Visited { get; set; }
    }
}
