using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    public class Helmet : Decorator
    {
        public Helmet(IToy toy) : base(toy)
        {

        }

        public override float Cost()
        {
            return base.Cost() + 10;
        }

        public override string Summary()
        {
            return base.Summary() + "\nI have a helmet on my head.";
        }
    }
}
