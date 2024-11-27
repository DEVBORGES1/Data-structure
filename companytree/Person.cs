using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Person() {}

        public Person(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

        // Override ToString for a more readable output
        public override string ToString()
        {
            return $"{Name} ({Role})";
        }
    }
}