using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class ConsoleDrawer : IDrawer
	{
		public void Draw(Menu menu)
		{
			string[] buttons = menu.GetButtons();
			for (int i = 0; i < buttons.Length; i++)
			{
				Console.WriteLine(buttons[i]);
			}
		}
	}
}
