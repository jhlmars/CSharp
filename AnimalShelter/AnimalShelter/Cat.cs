using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat
    {
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Cat(string name, string color, string gender)
        {
            Name = name;
            Color = color;
            Gender = gender;
        }

        public string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }

    }
}
