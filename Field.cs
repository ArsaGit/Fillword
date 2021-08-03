using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Field
	{
		private int fieldWidth;
		private int fieldHeight;

		char[,] field;

		private class WordData
		{
			public string Word { get; set; }
			public List<int[]> Coordinades { get; set; }
		}

		private List<WordData> words;

		private const ConsoleColor CurrentCellColor = ConsoleColor.Green;
		private const ConsoleColor SelectedCellColor = ConsoleColor.Blue;
		private const ConsoleColor GuessedCellColor = ConsoleColor.Gray;

		public Field()
		{
			fieldHeight = 6;
			fieldWidth = 6;
			GenerateField();
		}

		public void GenerateField()
		{
			field = new char[fieldHeight, fieldWidth];

		}

		private void GetWords()
		{

		}
	}
}
