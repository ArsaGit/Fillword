using System;
using System.Collections.Generic;
using System.Text;

namespace Fillword
{
	public class Field
	{
		private class WordData
		{
			public string Word { get; set; }
			public List<int[]> Coordinades { get; set; }
		}

		private int fieldWidth;
		private int fieldHeight;

		private List<string> allWords;
		private char[,] field;
		private List<WordData> wordsords;

		private const ConsoleColor CurrentCellColor = ConsoleColor.Green;
		private const ConsoleColor SelectedCellColor = ConsoleColor.Blue;
		private const ConsoleColor GuessedCellColor = ConsoleColor.Gray;

		public Field(List<string> allWords)
		{
			fieldHeight = 6;
			fieldWidth = 8;
			this.allWords = allWords;
			field = GenerateField();
		}

		public char[,] GenerateField()
		{
			
			return new char[fieldHeight, fieldWidth];
		}

		private void GetWords()
		{
			
		}
	}
}
