using Enemies;

namespace Defenders
{
    interface IDefender
    {
        int DefendAganistOgre(Ogre ogre);
        int DefendAganistGiant(Giant giant);
        int DefendAganistRat(Rat rat);
        int DefendAgainstEnemy(Enemy enemy);
    }
}