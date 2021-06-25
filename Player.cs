using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Player
	{
		private readonly string name;

		public Player(string name)
		{
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}
	}
}
