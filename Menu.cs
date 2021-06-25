using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Menu
	{
		private readonly IDrawer drawer;
		private readonly string[] buttons = {"New game",
							"Continue",
							"Rating",
							"Exit"};

		private int currentButtonNumber = 0;

		private bool isRunning = true;

		private const ConsoleColor SelectedColor = ConsoleColor.Green;
		private const ConsoleColor DefaultTextColor = ConsoleColor.White;

		public Menu(IDrawer drawer)
		{
			this.drawer = drawer;
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
	}
}
