using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }
        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public override string ToString()
        {
            return $"{base.ToString()} School: {School} Pay: {Pay}";
        }
    }
}
