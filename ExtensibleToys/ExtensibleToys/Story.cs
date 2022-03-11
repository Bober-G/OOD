using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Story: Decorator
    {
        private string _typeOfStory;
        public Story(IToy toy, string typeOfStory) : base(toy)
        {
            _typeOfStory = typeOfStory;
        }
        public override float Cost()
        {
            return base.Cost() + 30;
        }

        public override string Summary()
        {
            if(_typeOfStory =="scary")
                return base.Summary() + $"\nI tell {_typeOfStory} stories";
            if (_typeOfStory == "jokes")
                return base.Summary() + $"\nI tell very funny stories";
            else
                return base.Summary();
        }
    }
}
