using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice
    {
	 	private readonly int _diceSize = 6;

		public Dice()
		{
			DiceSize = _diceSize;
		}
		public Dice(int diceSize)
		{
			DiceSize = diceSize;
		}

		public int DiceSize { get; set; }
		
		public int Roll()
		{
			Random rand = new Random();
			{
				return(rand.Next(1, DiceSize));

			}
			
		}

	}
}
