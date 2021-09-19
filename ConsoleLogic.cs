using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class ConsoleLogic
	{

		public void ChooseButton(ButtonCollection buttonCollection)
		{
			ConsoleKeyInfo chInput = Console.ReadKey();

			switch(chInput.Key)
			{
				case ConsoleKey.UpArrow:
				case ConsoleKey.W:
				case ConsoleKey.LeftArrow:
				case ConsoleKey.A:
					buttonCollection.CurrentButtonNumber--;
					break;
				case ConsoleKey.DownArrow:
				case ConsoleKey.S:
				case ConsoleKey.RightArrow:
				case ConsoleKey.D:
					buttonCollection.CurrentButtonNumber++;
					break;
				case ConsoleKey.Enter:
					buttonCollection.Buttons[buttonCollection.CurrentButtonNumber].IsActivated = false;
					break;
			}
		}
	}
}
