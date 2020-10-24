using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZoologyApp2
{
    class Amphibian : Animal
    {
        public Amphibian(int legs, string name, string sound) : base(legs, name, sound)
        {
            Type = "Amphibian";
        }

        public Amphibian() : base(0, "Fish", "Blubblub")
        {
            Type = "Amphibian";
        }

    }
}
