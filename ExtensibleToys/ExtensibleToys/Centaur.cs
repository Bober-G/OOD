using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Centaur: IToy
    {
       
        private string name;
        private int age;
        private bool haveBeard;

        public Centaur(string n, int a, bool hB)
        {
            name = n;
            age = a;
            haveBeard = hB;
        }
        public float Cost()
        {
            return 250f;
        }

        public float Height()
        {
            return 110;
        }

        public string Summary()
        {
            if (haveBeard == true)
            {
                return "Centaur " + $"{name}" + ". " + $"I am {age} years old and  and has a beard";
            }
            else
            {
                return "Centaur " + $"{name}" + ". " + $"I am {age} years old  and don't have a beard.";
            }

        }
    }
}
