using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleToys
{
    class Jump : Decorator
    {

        
        public Jump(IToy toy) : base(toy)
        {
            _jumpsLeft = 5;
        }
        public void jumping()
        {
            
        }
        public override float Cost()
        {
            bool canJump = false;
            if (canJump == false)
            {
                canJump = true;
                return base.Cost() + 20;
                
            }
            else
                return base.Cost();
            
        }

        public override string Summary()
        {
            string s = "";
            if (_jumpsLeft > 0)
            {
                s = $"\nI can jump! I just jumped {base.Height() * 0.1 * _jumpsLeft} cm!";
                --_jumpsLeft;
                
            }
            return base.Summary() + s;

        }
    }
}
