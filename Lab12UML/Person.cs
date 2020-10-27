using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UML
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public override string ToString()
        {
            return $"Name: {this.Name} Address: {this.Address}";
        }
    }
}
