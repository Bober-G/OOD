using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    public abstract class Decorator : IToy
    {
        private readonly IToy _toy;
        public int _jumpsLeft;
        public Decorator(IToy toy)
        {
            _toy = toy;
        }

        public virtual float Cost()
        {
            return _toy.Cost();
        }

        public float Height()
        {
            return _toy.Height();
        }

        public virtual string Summary()
        {
            return _toy.Summary();
        }

        


    }
}
