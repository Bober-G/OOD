using System;
using Defenders;

namespace Enemies
{
    class Giant : Enemy
    {

        public Giant(string name, int hp) : base(name, hp)
        {
            
        }

        public override void DemageDelt(IDefender defender)
        {
            this.GetDamage(defender.DefendAganistGiant(this));
        }

        public override void DemageDeltbyFireMag(IDefender defender)
        {
            this.GetDamage(defender.DefendAgainstEnemy(this));
        }
    }
}