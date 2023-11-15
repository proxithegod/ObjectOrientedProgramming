using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Animal : Mechanism
    {
        public string? Color { get; set; } = "Black";
        public int? NumberOfLegs{ get; set; } = null;

        public string? Name { get; set; }

        public Animal(string Color, int NumberOfLegs, string Name) 
        { 
            this.Color = Color;
            this.NumberOfLegs = NumberOfLegs;
            this.Name = Name;
        }

        
    }
}
