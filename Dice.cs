using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice
    {
	 	private static int diceSize = 6;

		public Dice(){}
		public Dice(int diceSize)
		{
			diceSize = DiceSize;
		}

		public int DiceSize { get; set; }
		
		public int Roll()
		{
			Random rand = new Random();
			{
				return(rand.Next(1, diceSize));

			}
			
		}

	}
}
