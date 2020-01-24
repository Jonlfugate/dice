using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice
    {
	 	private readonly int _diceSize = 6;
		private readonly Random _random;

		public Dice()
		{
			DiceSize = _diceSize;
			Random _random = new Random();
			

		}
		public Dice(int diceSize)
		{
			DiceSize = diceSize;
			Random _random = new Random();
			

		}

		public int DiceSize { get; private set; }
		
		public int Roll()
		{
			
			return(_random.Next(1,DiceSize));

		}

	}
}
