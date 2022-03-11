using System;
using Defenders;

namespace Enemies
{
    abstract class Enemy
    {
        public string Name { get; }

        public bool Alive { get; set; }
        public int HP { get; set; }

        protected Enemy(string name, int hp)
        {
            Name = name;
            HP = hp;
            Alive = true;
        }

        protected virtual void GetDamage(int? damage)
        {
            HP -= damage.Value;
            if(HP<=0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }
        public abstract void DemageDelt(IDefender defender);
        public abstract void DemageDeltbyFireMag(IDefender defender);
        public void isDead()
        {
            HP = 0;
        }
        
        
    }
}