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
			string[] buttons = menu.GetButtons();

			Console.WriteLine("Chess\n");

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

			Console.ResetColor();
		}

		public void DrawNewGame()
		{
			Console.WriteLine("Тут однажды будет New game");
		}

		public void DrawContinueGame()
		{
			Console.WriteLine("Тут однажды будет Continue Game");
		}

		public void DrawRating()
		{
			Console.WriteLine("Тут однажды будет Rating");
		}

		public void DrawExit()
		{
			Console.WriteLine("Тут однажды будет Exit");
		}

		public void AskPlayer()
		{
			Console.WriteLine("Enter Player name: ");
		}

		public string GetStr()
		{
			return Console.ReadLine();
		}
	}
}
