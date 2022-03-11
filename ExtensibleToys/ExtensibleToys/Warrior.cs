using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensibleToys
{
    class Warrior : IToy
    {


        public float Cost()
        {
            return 150f;
        }

        public float Height()
        {
            return 190;
        }

        public string Summary()
        {
            return $"I'm a warrior. I am {Height()} high";
        }
    }
}
