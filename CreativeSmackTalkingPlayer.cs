using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _taunt = new List<string>()
        {
            "You are not good at dice", "Learn how to roll", "Your wrist is weak"
        };

        public override int Roll()
        {
           int randomIndex = new Random().Next(_taunt.Count);
           string randomTaunt = _taunt[randomIndex];
            Console.WriteLine(randomTaunt);
            return new Random().Next(DiceSize) + 1;

            //a condensed version:
            //Console.WriteLine(_taunts[new Random().Next(_taunts.Count)]);
            //return base.Roll();

        }
    }
}