using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Dress: Decorator
    {
        private string _typeOdDress;
        public Dress(IToy toy, string typeOfDress) : base(toy)
        {
            _typeOdDress = typeOfDress;
        }

        public override float Cost()
        {
            if(_typeOdDress == "flower")
                return base.Cost() + 20;
            if (_typeOdDress == "dotted")
                return base.Cost() + (float)19.99;
            else
                return base.Cost();
        }

        public override string Summary()
        {
            return base.Summary() + $"\nI have a {_typeOdDress} dress.";
        }
    }
}
