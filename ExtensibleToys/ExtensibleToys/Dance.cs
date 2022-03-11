using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Dance: Decorator
    {
        private string _typeOfDance;

        public Dance(IToy toy, string typeOfDance) : base(toy)
        {
            _typeOfDance = typeOfDance;
        }
        public override float Cost()
        {
            if (_typeOfDance == "breakdance")
                return base.Cost() + 50;
            if (_typeOfDance == "solo capoeira")
                return base.Cost() + 70;
            if (_typeOfDance == "gangam style dance")
                return base.Cost() + 100;
            else
                return base.Cost();
        }

        public override string Summary()
        {
            return base.Summary() + $"\nI can dance {_typeOfDance}.";
        }
    }
}
