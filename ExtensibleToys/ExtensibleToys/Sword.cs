using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Sword: Decorator
    {
        public Sword(IToy toy) : base(toy)
        {

        }
        public override float Cost()
        {
            return base.Cost() + 15;
        }

        public override string Summary()
        {
            return base.Summary() + "\nI have a sword.";
        }
    }
}
