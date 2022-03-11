using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"Mage {name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public virtual int DefendAganistOgre(Ogre ogre)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} has attacted {ogre.Name} causing {spellPower} demage");
                return spellPower;
            }
            else
            {
                return 0;
            }
        }

        public virtual int DefendAganistGiant(Giant giant)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} has attacted {giant.Name} causing {spellPower} demage");
                return spellPower;
            }
            else
            {
                return 0;
            }
        }

        public virtual int DefendAganistRat(Rat rat)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} has attacted {rat.Name} causing {spellPower} demage");
                return spellPower;
            }
            else
            {
                 return 0;
            }
        }

        public int DefendAgainstEnemy(Enemy enemy)
        {
            return 0;
        }
    }
}