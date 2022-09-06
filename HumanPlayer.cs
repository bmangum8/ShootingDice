using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {   
            Console.WriteLine("Type a number");
            return int.Parse(Console.ReadLine());
            
        }
    }
}