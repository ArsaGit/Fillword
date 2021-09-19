using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public abstract class Menu
	{
		private readonly IDrawer drawer;
		private readonly ConsoleLogic logic;

		public abstract string Header { get; }
		public abstract ButtonCollection ButtonCollection { get; }
		public bool IsRunning { get; set; }

		public Menu(IDrawer drawer, ConsoleLogic logic)
		{
			this.drawer = drawer;
			this.logic = logic;
			IsRunning = true;
		}

		public void Draw()
		{
			drawer.Draw(this);
		}
	}

	public class MainMenu : Menu
	{
		private readonly IDrawer drawer;
		private readonly ConsoleLogic logic;

		public override string Header => "Fillwords";
		public override ButtonCollection ButtonCollection => new ButtonCollection(
			"New game",
			"Continue",
			"Options",
			"Exit");

		public MainMenu(IDrawer drawer, ConsoleLogic logic) : base(drawer, logic)
		{
			this.drawer = drawer;
			this.logic = logic;
			IsRunning = true;
		}
	}
}
