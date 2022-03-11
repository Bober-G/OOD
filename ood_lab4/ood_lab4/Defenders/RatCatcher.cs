using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

      

        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }

        public int DefendAgainstEnemy(Enemy enemy)
        {
            return 0;
        }

        public int DefendAganistGiant(Giant giant)
        {
            return 0;
        }

        public int DefendAganistOgre(Ogre ogre)
        {
            if (hasRat)
            {
                ogre.isDead();
                Console.WriteLine($"{name} has killed {ogre.Name} with rat");
                hasRat = false;
            }
             
            return 0;
        }

        public int DefendAganistRat(Rat rat)
        {
            if(!hasRat)
            {
                Console.WriteLine($"{name} has attacted {rat.Name} causing {rat.HP} demage");
                rat.isDead();
                
                hasRat = true;
            }
           
            return 0;
        }
    }
}