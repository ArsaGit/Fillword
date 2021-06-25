using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class ConsoleDrawer : IDrawer
	{
		public void Draw(Menu menu)
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("Fillword\n");

			string[] buttons = menu.GetButtons();
			for (int i = 0; i < buttons.Length; i++)
			{
				if (menu.IsCurrentButton(i))
				{
					Console.ForegroundColor = menu.GetSelectedColor();
				}
				else
				{
					Console.ForegroundColor = menu.GetDefaultTextColor();
				}
				Console.WriteLine(buttons[i]);
			}
		}
	}
}
