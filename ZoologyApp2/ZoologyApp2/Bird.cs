using System;
using System.Collections.Generic;
using System.Text;

namespace ZoologyApp2
{
    class Bird : Animal
    {
        public Bird() : base(2, "Eagle", "Sqwueee")
        {
            Type = "Bird";
        }

        public Bird(int legs, string name, string sound) : base(legs, name, sound)
        {
            Type = "Bird";
        }
    }
}
