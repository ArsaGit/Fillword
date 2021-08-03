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
		public List<string> ReadFile()
		{
			List<string> input = new List<string>();
			string path = GetPathToFile("russian_nouns.txt");

			foreach (string line in File.ReadLines(path))
			{
				input.Add(line);
			}
			return input;
		}

		//записывает слова в файл
		public void WriteInFile(string content)
		{
			string path = GetPathToFile("russian_nouns.txt");
			using (StreamWriter sw = new StreamWriter(path))
			{
				sw.WriteLine(content);  //запись данных
			}
		}
	}
}
