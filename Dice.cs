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
			Random rand = new Random();

		}
		public Dice(int diceSize)
		{
			DiceSize = diceSize;
			Random rand = new Random();

		}

		public int DiceSize { get; private set; }
		
		public int Roll()
		{
			
			return(rand.Next(1,DiceSize));

		}

	}
}
