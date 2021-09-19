using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Fillword
	{
		private readonly IDrawer drawer;
		private readonly Menu menu;
		private readonly WorkWithFIles workWithFIles;
		private readonly List<string> allWords;
		private Field Field { get; set; }
		private readonly ConsoleLogic logic;

		public Fillword(IDrawer drawer, ConsoleLogic logic)
		{
			this.drawer = drawer;
			this.logic = logic;
			menu = new Menu(drawer, logic);
			allWords = GetAllWords();
			Field = new Field(allWords);
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
			drawer.AskPlayer();
			string name = drawer.GetStr();
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

		private List<string> GetAllWords()
		{
			return workWithFIles.GetAllWords();
		}
	}
}
