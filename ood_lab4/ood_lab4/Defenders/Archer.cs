using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }
        public override int DefendAganistOgre(Ogre ogre)
        {
            if (arrows >= 1)
            {
                arrows--;
                Console.WriteLine($"{name} has attacted {ogre.Name} with an arrow causing {strength} demage");
                return strength;
            }
            else return 0;
            
        }

        public override int DefendAganistGiant(Giant giant)
        {
            if (arrows >= 2)
            {
                arrows -= 2;
                Console.WriteLine($"{name} has attacted {giant.Name} with 2 arrows causing {strength * 2} demage");
            }
            else return 0;
            return strength * 2 ;
        }

        public override int DefendAganistRat(Rat rat)
        {
            if (arrows >= 1)
            {
                arrows--;
                Console.WriteLine($"{name} has attacted {rat.Name} with 1 arrow causing {strength} demage");
            }
            else return 0;
            if (rng.NextDouble() < rat.Speed / 100)
            {
                Console.WriteLine($"{name} misses");
                return 0;
            }
            return strength;
        }

    }
}