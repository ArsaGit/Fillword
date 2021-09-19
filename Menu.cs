using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Menu
	{
		private readonly IDrawer drawer;
		private readonly ConsoleLogic consoleLogic;
		private readonly string[] buttons;

		public int currentButtonNumber = 0;

		public bool isRunning = true;

		private const ConsoleColor SelectedColor = ConsoleColor.Green;
		private const ConsoleColor DefaultTextColor = ConsoleColor.White;

		public Menu(IDrawer drawer, ConsoleLogic consoleLogic)
		{
			this.drawer = drawer;
			this.consoleLogic = consoleLogic;
		}

		public void SelectButton()
		{
			ConsoleKeyInfo chInput = Console.ReadKey();

			switch (chInput.Key)
			{
				case ConsoleKey.UpArrow:
				case ConsoleKey.W:
					currentButtonNumber--;
					break;
				case ConsoleKey.DownArrow:
				case ConsoleKey.S:
					currentButtonNumber++;
					break;
				case ConsoleKey.Enter:
					isRunning = false;
					break;
			}

			if (currentButtonNumber < 0) currentButtonNumber = 3;
			if (currentButtonNumber > 3) currentButtonNumber = 0;
		}

		public void Draw()
		{
			drawer.Draw(this);
		}

		public string[] GetButtons()
		{
			return buttons;
		}

		public int GetCurrentButtonNumber()
		{
			return currentButtonNumber;
		}

		public ConsoleColor GetSelectedColor()
		{
			return SelectedColor;
		}

		public ConsoleColor GetDefaultTextColor()
		{
			return DefaultTextColor;
		}

		public bool IsCurrentButton(int i)
		{
			return currentButtonNumber == i;
		}

		public bool IsRunning()
		{
			return isRunning;
		}
	}
}
