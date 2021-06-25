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
		}

		private void RunMenu()
		{
			do
			{
				menu.Draw();
				menu.SelectButton();
			} while (menu.IsRunning());
		}
	}
}
