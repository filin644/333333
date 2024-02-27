using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace LibraryForNotebook
{
	public class Notebook // Класс для: открытия, создания, сохранения, поиска слова, печати.
	{
		public string NewDoc(ref string filename) // Передача по ссылке, чтобы и в библиотеке, и в форме менялось значение.
		{
			filename = ""; // Очистка пути в текущей форме.
			return string.Empty;
		}

		public string OpenFile(string filename) // Открытие файла.
		{
			try
			{
				using (StreamReader sr = new StreamReader(filename)) // Поток для чтения выбранного файла.
				{
					string text = sr.ReadToEnd(); // Чтение.
					return text;
				}
			}
			catch
			{
				return "Ошибка: не удалось открыть txt файл";
			}
		}

		public void SaveAS(string filename, string richTextBox) // Сохранение файла с выбором пути.
		{
			using (StreamWriter sw = new StreamWriter(filename)) // Поток для записи в файл по выбранному пути.
			{
				sw.Write(richTextBox); // Запись.
			}
		}

		public static string WordSearch(string text, string searchWord, bool ignoreCase) // Поиск слов с учётом регистра/без учёта регистра (ignoreCase).
		{
			// Шаблон поиска: начало слова \b, искомый слог, затем любые буквы и цифры \w любое кол-во раз *, т.е. ищем фрагмент searchWord в начале слова.
			string pattern = $@"\b{searchWord}(\w*)";

			Regex regex; // Класс для поиска в строках.
			if (ignoreCase) regex = new Regex(pattern, RegexOptions.IgnoreCase); // Без учёта регистра.
			else regex = new Regex(pattern); // С учётом регистра.
			MatchCollection matches = regex.Matches(text); // Получить совпадения.

			List<string> result = matches.Cast<Match>().Select(m => m.Value).ToList(); // Преобразовать MatchCollection в список.
			result.Sort(); // Сортировка по алфавиту.
			return string.Join(" ", result); // Объединить совпадения в одну строку, разделяя пробелом.
		}

		string stringToPrint; // Переменная для считывания текста для печати.
		public void Print(string text, PrintDocument printDocument)
		{
			stringToPrint = text; // Устанавливаем текст для печати.
			printDocument.PrintPage += PrintPage; // Указываем объекту, выводящему данные на печать, использовать наш метод.
			printDocument.Print();
		}

		public void PrintPage(object sender, PrintPageEventArgs e) // Событие печати.
		{
			// Устанавливает переменную charactersOnPage = кол-ву символов строки stringToPrint, которая будет вписываться в границы страницы.
			e.Graphics.MeasureString(stringToPrint, new Font("Times New Roman", 14), e.MarginBounds.Size, StringFormat.GenericTypographic,
				out int charactersOnPage, out _);

			// Выводит строку в пределах страницы.
			e.Graphics.DrawString(stringToPrint, new Font("Times New Roman", 14), Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

			stringToPrint = stringToPrint.Remove(0, charactersOnPage); // Удаляет часть строки, которая была напечатана.
			e.HasMorePages = stringToPrint.Length > 0; // Проверяет, нужно ли печатать больше страниц.
		}
	}
}