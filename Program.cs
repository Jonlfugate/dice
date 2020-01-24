using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice dice = new Dice();
            Console.WriteLine("enter a dice size");
            dice.DiceValue = int.Parse(Console.ReadLine());
            Console.WriteLine(dice.DiceValue);
        }
    }
}