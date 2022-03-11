using System;
using Defenders;

namespace Enemies
{
    class Rat : Enemy
    {
        public int Speed { get; private set; }

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            Speed = speed;
        }
        public void speedIncrease()
        {
            Speed++;
        }
        protected void GetDemage(int? demage)
        {
            HP -= demage.Value;
            speedIncrease();
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }
        public override void DemageDelt(IDefender defender)
        {

            this.GetDamage(defender.DefendAganistRat(this));
            
        }

        public override void DemageDeltbyFireMag(IDefender defender)
        {
            this.GetDamage(defender.DefendAgainstEnemy(this));
        }
    }
}