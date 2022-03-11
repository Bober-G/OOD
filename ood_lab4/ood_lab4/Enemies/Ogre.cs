using System;
using Defenders;

namespace Enemies
{
    class Ogre : Enemy
    {
        public int Armor { get;  }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
        }
        protected void GetDemage(int? demage)
        {
            if (demage.Value - Armor > 1)
                HP -= demage.Value - Armor;
            else
                HP--;
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }
        public override void DemageDelt(IDefender defender)
        {
            
            this.GetDamage(defender.DefendAganistOgre(this));
            
        }

        public override void DemageDeltbyFireMag(IDefender defender)
        {
            this.GetDamage(defender.DefendAgainstEnemy(this));
        }


    }
}