using System;

namespace ShootingDice 
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            //.Next(min, max)
            return new Random().Next(DiceSize/2, DiceSize +1);        
        }
    }
}