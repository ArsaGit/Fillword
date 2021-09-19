using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fillword
{
	public class WorkWithFIles
	{
		//создаёт относительный путь к фалйу
		private string GetPathToFile(string fileName)
		{
			string filePath = Environment.CurrentDirectory;
			filePath = filePath.Substring(0, filePath.IndexOf("bin")) + fileName;
			return filePath;
		}

		//считывает слова из файла и возвращает лист строк
		public List<string> GetAllWords()
		{
			List<string> wordList = new List<string>();
			string path = GetPathToFile("russian_nouns.txt");

			foreach (string word in File.ReadLines(path))
			{
				wordList.Add(word);
			}
			return wordList;
		}

		//записывает слова в файл
		public void SaveAllWords(List<string> wordList)
		{
			string path = GetPathToFile("russian_nouns.txt");
			using StreamWriter sw = new StreamWriter(path);
			foreach (string word in wordList)
				sw.WriteLine(word);
		}
	}
}
