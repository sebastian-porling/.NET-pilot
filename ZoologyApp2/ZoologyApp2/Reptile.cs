using System;
using System.Collections.Generic;
using System.Text;

namespace ZoologyApp2
{
    class Reptile : Animal
    {
        public Reptile() : base(0, "Snake", "Szszszsz")
        {
            Type = "Reptile";
        }

        public Reptile(int legs, string name, string sound) : base(legs, name, sound)
        {
            Type = "Reptile";
        }
    }
}
