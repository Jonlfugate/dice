using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            var d20 = new Dice(10000);
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(d20.Roll());
                
            } 
            
        }
    }
}