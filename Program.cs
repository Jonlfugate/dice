using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            var d20 = new Dice(20);
            
            System.Console.WriteLine(Dice.Roll());
            
        }
    }
}