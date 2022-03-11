using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }

        public int DefendAgainstEnemy(Enemy enemy)
        {
            if (CanCastSpell())
            {
                if (rng.NextDouble() < killChance)
                {
                    enemy.isDead();
                    Console.WriteLine($"{name} has killed {enemy.Name} causing {enemy.HP} demage");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"{name} has attacted {enemy.Name} causing {spellPower} demage");
                    return spellPower;
                }
            }
            else return 0;
        }
        public override int DefendAganistOgre(Ogre ogre) => DefendAgainstEnemy(ogre);
        public override int DefendAganistGiant(Giant giant) => DefendAgainstEnemy(giant);

        public override int DefendAganistRat(Rat rat) => DefendAgainstEnemy(rat);
       
        //public override int DefendAganistOgre(Ogre ogre)
        //{
        //    if (CanCastSpell())
        //    {
        //        if (rng.NextDouble() < killChance)
        //        {
        //            ogre.isDead();
        //            Console.WriteLine($"{name} has attacted {ogre.Name} causing {ogre.HP} demage");
        //            return 0;
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{name} has attacted {ogre.Name} causing {spellPower } demage");
        //            return spellPower;
        //        }
        //    }
        //    else return 0;
        //}

        //public override int DefendAganistGiant(Giant giant)
        //{
        //    if (CanCastSpell())
        //    {
        //        if (rng.NextDouble() < killChance)
        //        {
        //            Console.WriteLine($"{name} has attacted {giant.Name} causing {giant.HP} demage, Instant kill!!!");
        //            giant.isDead();

        //        }
        //        else Console.WriteLine($"{name} has attacted {giant.Name} causing {spellPower} demage");

        //        return spellPower;
        //    }
        //    else return 0;
        //}

        //public override int DefendAganistRat(Rat rat)
        //{
        //    if (CanCastSpell())
        //    {
        //        if (rng.NextDouble() < killChance)
        //        {
        //            rat.isDead();
        //            Console.WriteLine($"{name} has attacted {rat.Name} causing {rat.HP} demage");
        //        }
        //        else Console.WriteLine($"{name} has attacted {rat.Name} causing {spellPower} demage");
        //        return spellPower;
        //    }
        //    else return 0;
        //}


    }
}