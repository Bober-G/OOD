using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

        public virtual int DefendAganistOgre(Ogre ogre)
        {
            return strength;
        }

        public virtual int DefendAganistGiant(Giant giant)
        {
            Console.WriteLine($"{name} has attacted {giant.Name} causing {strength} demage");
            return strength;
        }

        public virtual int DefendAganistRat(Rat rat)
        {
            if (rng.NextDouble() < rat.Speed / 100)
            {
                Console.WriteLine($"{name} misses");
                return 0;
            }
            Console.WriteLine($"{name} has attacted {rat.Name} causing {strength} demage");
            return strength;
        }

        public int DefendAgainstEnemy(Enemy enemy)
        {
            return 0;
        }
    }
}