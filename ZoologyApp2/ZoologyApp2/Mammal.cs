using System;
using System.Collections.Generic;
using System.Text;

namespace ZoologyApp2
{
    class Mammal : Animal
    {
        public Mammal() : base(4, "Cow", "Mooo")
        {
            Type = "Mammal";
        }

        public Mammal(int legs, string name, string sound) : base(legs, name, sound)
        {
            Type = "Mammal";
        }
    }
}
