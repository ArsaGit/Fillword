using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Fillword
	{
		private readonly IDrawer drawer;
		private readonly Menu menu;

		public Fillword(IDrawer drawer)
		{
			this.drawer = drawer;
			menu = new Menu(drawer);
		}

		public void Run()
		{
			RunMenu();
			ActivateButton();
		}

		private void RunMenu()
		{
			do
			{
				menu.Draw();
				menu.SelectButton();
			} while (menu.IsRunning());
		}

		private void ActivateButton()
		{
			Console.Clear();
			int key = menu.GetCurrentButtonNumber();

			switch (key)
			{
				case 0:
					StartNewGame();
					break;
				case 1:
					ContinueGame();
					break;
				case 2:
					OpenRating();
					break;
				case 3:
					ExitApp();
					break;
			}
		}

		private void StartNewGame()
		{
			Console.WriteLine("Enter Player name:");
			string name = Console.ReadLine();
			Player player = new Player(name);
		}

		private void ContinueGame()
		{
			drawer.DrawContinueGame();
		}

		private void OpenRating()
		{
			drawer.DrawRating();
		}

		private void ExitApp()
		{
			drawer.DrawExit();
		}
	}
}
