using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    class Dice
    {
	 	static int diceSize = 6;
		public Dice(int diceSize)
		{
			DiceSize = diceSize;
		}

		public int DiceSize { get; private set; }
		
		public static int rollDice()
		{
			Random rand = new Random();
			{
				return(rand.Next(1, diceSize));

			}
			
		}


	}
}
