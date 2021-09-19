using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Button
	{
		public string Name { get; set; }
		public bool IsActivated { get; set; }
		public ButtonCollection ButtonCollection { get; set; }

		public Button(string name)
		{
			Name = name;
			IsActivated = false;
		}

		public Button(string name, Button[] buttons)
		{
			Name = name;
			IsActivated = false;
			ButtonCollection.Buttons = buttons;
		}
	}

	public class ButtonCollection
	{
		public Button[] Buttons { get; set; }
		public int CurrentButtonNumber
		{
			get { return CurrentButtonNumber; }
			set
			{
				if (CurrentButtonNumber < 0) CurrentButtonNumber = Buttons.Length - 1;
				if (CurrentButtonNumber > Buttons.Length - 1) CurrentButtonNumber = 0;
			}
		}

		public ButtonCollection(Button[] buttons)
		{
			Buttons = buttons;
		}
	}
}
