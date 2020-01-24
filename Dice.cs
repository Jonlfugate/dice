using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    class Dice
    {
		private int diceValue;
		private int topEnd;
		public int DiceValue
		{
			get { return diceValue; }
			set 
			{ 
				topEnd = value;
				Random rand = new Random();
				diceValue = (rand.Next(1 , topEnd));
			}

		}

	}
}
