using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Minotaur: IToy
    {
       
        private string name;
        private int age;
        private int mass;
       public Minotaur(string n, int a, int m)
        {
            name = n;
            age = a;
            mass = m;
        }
        
        public float Cost()
        {
            return 250f;
        }

        public float Height()
        {
            return 100;
        }

        public string Summary()
        {
            return "Minotaur " + $"{name}" + ". " + $"I am {age} years old and weigh {mass} kg.";
        }
    }
}
