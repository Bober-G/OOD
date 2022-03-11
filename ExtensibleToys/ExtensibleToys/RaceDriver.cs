using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensibleToys
{
    class RaceDriver : IToy
    {
        //private string s = "I'm a race driver.";
        //private float p = 200f;
        //private bool cJ = false;
        //private float h = 190;
        //private int jL = 5;

      
        //public string summary { get { return s; } set { s = value; } }

        //public float price { get { return p; } set { p = value; } }

        //public bool canJump { get { return cJ; } set { cJ = value; } }

        //public float height { get { return h; } set { h = value; } }

        //public int jumpsLeft { get { return jL; } set { jL = value; } }



        public float Cost()
        {
            return 200f;
        }

        public float Height()
        {
            return 200;
        }

        public string Summary()
        {
            return $"I'm a race driver. I am {Height()} high";
        }
    }
}
