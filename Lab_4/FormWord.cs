using System;
using System.Windows.Forms;
using LibraryForNotebook;

namespace Lab_4
{
	public partial class FormWord : Form
	{
		string text; // Текст, полученный из родительской формы FormMain.
		public string msg; // Переменная, доступная из родительской формы FormMain, где будем хранить ответ.

		public FormWord(string text)
		{
			InitializeComponent();
			this.text = text; // Получаем текст.
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string searchWord = textBox1.Text; // Искомое слово.

			if (searchWord != "")
			{
				bool ignoreCase = checkBox1.Checked; // Значение галочки "Без учёта регистра".

				string result = Notebook.WordSearch(text, searchWord, ignoreCase); // Метод из библиотеки для поиска слов.

				msg = $"Слова, начинающиеся со слога {searchWord}: \n" + result; // Ответ.
				DialogResult = DialogResult.OK; // Вернуть родительской форме FormMain результат ОК.
			}
		}
	}
}