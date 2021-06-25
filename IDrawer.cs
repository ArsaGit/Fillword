using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public interface IDrawer
	{
		void Draw(Menu menu);
		void DrawNewGame();
		void DrawContinueGame();
		void DrawRating();
		void DrawExit();
	}
}
