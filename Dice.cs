using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice
    {
	 	private static int diceSize = 6;

		public Dice()
		{
			DiceSize = _diceSize
		}
		public Dice(int diceSize)
		{
			DiceSize = diceSize;
		}

		private int _diceSize { get; set; }
		
		public int Roll()
		{
			Random rand = new Random();
			{
				return(rand.Next(1, DiceSize));

			}
			
		}

	}
}
