using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensibleToys
{
    class Doll : IToy
    {
        //private string s = "I'm a doll.";
        //private float p = 100f;
        //private bool cJ = false;
        //private float h = 100;
        //private int jL = 5;

     
        //public string summary { get { return s; } set { s = value; } }

        //public float price { get { return p; } set { p = value; } }

        //public bool canJump { get { return cJ; } set { cJ = value; } }

        //public float height { get { return h; } set { h = value; } }
        //public int jumpsLeft { get { return jL; } set { jL = value; } }


        public float Cost()
        {
            return 100f;
        }

        public float Height()
        {
            return 120;
        }

        public string Summary()
        {
            return $"I'm a doll. I am {Height()} high";
        }

       
    }
}
