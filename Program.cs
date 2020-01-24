using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice dice = new Dice();
            Console.WriteLine("enter a dice size");
            dice.DiveValue = int.Parse(Console.ReadLine());
            Console.WriteLine(dice.DiveValue);
        }
    }
}