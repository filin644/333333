using System;
using System.IO;
using System.Windows.Forms;
using LibraryForNotebook;

namespace Lab_4
{
	// Открытие, сохранение, принтер, поиск - библиотека.

	public partial class FormMain : Form
	{
		string filename = ""; // Путь к текущему файлу.
		public bool isDocChanged = false; // Переменная для отслеживания изменений в документе.
		Notebook notebook = new Notebook(); // Создание блокнота библиотеки LibraryForNotebook.

		public FormMain() // Конструктор (действия при создании формы).
		{
			InitializeComponent();
			statusStrip.Items[2].Text = "Состояние: " + "редактор"; // Текущее состояние блокнота.

			toolStrip.Visible = true; // Отобразить панель инструментов.
			ShowOrHide.Checked = true; // Установить галочку на пункте меню "Панель инструментов".

			// Настройка компонента openFileDialog1.
			openFileDialog1.Filter = "текст|*.txt"; // Искать в проводнике только текстовые файлы.
			openFileDialog1.Title = "Открыть документ"; // Заголовок окна.

			// Настройка компонента saveFileDialog1.
			saveFileDialog1.DefaultExt = "txt"; // Расширение .txt по умолчанию для сохраняемого файла.
			saveFileDialog1.Filter = "текст|*.txt"; // Искать в проводнике только текстовые файлы.
			saveFileDialog1.Title = "Сохранить документ"; // Заголовок окна.
		}

		private void richTextBox_TextChanged(object sender, EventArgs e) // Событие при вводе текста.
		{
			statusStrip.Items[2].Text = "Состояние: " + "редактирование документа";

			int len = richTextBox.Text.Length; // Кол-во символов в поле редактирования.
			int lines = richTextBox.Lines.Length; // Кол-во строк в поле редактирования.

			statusStrip.Items[0].Text = "Число знаков: " + len.ToString();
			statusStrip.Items[1].Text = "Число строк: " + lines.ToString();

			isDocChanged = true; // Документ редактируется, изменения не сохранены.
		}

		// НОВЫЙ ДОКУМЕНТ.
		private void NewDocument_Click(object sender, EventArgs e) // Кнопка и пункт меню "Файл - Создать".
		{
			statusStrip.Items[2].Text = "Состояние: " + "редактирование документа";
			IsSaveDocChange(); // Был ли сохранён текущий документ.

			// Создание нового документа.
			// Передача пути filename по ссылке (ref), чтобы его очистить и в библиотеке, и в форме.
			// Очистка текстового поля.
			richTextBox.Text = notebook.NewDoc(ref filename);

			isDocChanged = false; // Документ не изменён (новый).
			Text = "Новый документ"; // Заголовок формы.
		}

		// ОТКРЫТИЕ ФАЙЛА.
		private void openFile_ButtonClick(object sender, EventArgs e) // Кнопка и пункт меню "Файл - Открыть".
		{
			IsSaveDocChange(); // Был ли сохранён текущий документ.
			statusStrip.Items[2].Text = "Состояние: " + "открытие документа";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) // Открытие диалогового окна выбора файла, изменения будут внесены после нажатия на ОК.
			{
				try
				{
					using (StreamReader sr = new StreamReader(openFileDialog1.FileName)) // Поток для чтения выбранного файла.
					{
						filename = openFileDialog1.FileName; // Выбранный путь из диалогового окна.
						richTextBox.Text = notebook.OpenFile(filename); // Метод из библиотеки для чтения.
					}

					richTextBox_TextChanged(sender, e); // Рассчитать кол-во знаков и строк.
					isDocChanged = false; // Документ не изменён (новый).
					Text = filename; // Заголовок формы.
				}
				catch
				{
					MessageBox.Show("Ошибка: не удалось открыть txt файл");
				}
			}

			statusStrip.Items[2].Text = "Состояние: ";
		}

		// СОХРАНЕНИЕ.
		private void Save_Click(object sender, EventArgs e) // Кнопка и пункт меню "Файл - Сохранить".
		{
			statusStrip.Items[2].Text = "Состояние: " + "сохранение документа";
			if (filename == "") // При отсутствии пути к файлу вызывается диалоговое окно.
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Открытие диалогового окна выбора пути, изменения будут внесены после нажатия на ОК.
				{
					filename = saveFileDialog1.FileName; // Выбранный путь из диалогового окна.
					notebook.SaveAS(filename, richTextBox.Text); // Метод из библиотеки для сохранения.
				}
			}
			else
			{
				notebook.SaveAS(filename, richTextBox.Text); // Если путь есть, то документ сохранится по нему без вызова окна.
			}

			statusStrip.Items[2].Text = "Состояние: ";
			isDocChanged = false; // Документ сохранён.
			Text = filename; // Заголовок формы.
		}

		private void SaveAS_Click(object sender, EventArgs e) // Пункт меню "Файл - Сохранить как..."
		{
			statusStrip.Items[2].Text = "Состояние: " + "сохранение документа";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK) // Всегда вызывается диалоговое окно.
			{
				filename = saveFileDialog1.FileName; // Выбранный путь из диалогового окна.
				notebook.SaveAS(filename, richTextBox.Text); // Метод из библиотеки для сохранения.
				Text = filename; // Заголовок формы.
			}
		}

		// ПЕЧАТЬ.
		private void printText_ButtonClick(object sender, EventArgs e) // Кнопка печати.
		{
			statusStrip.Items[2].Text = "Состояние: " + "печать документа";
			if (richTextBox.Text != "")
			{
				// Метод из библиотеки для печати.
				// Передаётся текст и объект printDocument1, который посылает данные на принтер.
				notebook.Print(richTextBox.Text, printDocument1);
			}
		}

		// ПАРАМЕТРЫ.
		private void ShowOrHide_Click(object sender, EventArgs e) // Пункт меню "Параметры - Панель инструментов".
		{
			toolStrip.Visible = !toolStrip.Visible; // Отобразить/скрыть панель инструментов.
			ShowOrHide.Checked = !ShowOrHide.Checked; // Установить/убрать галочку на пункте меню "Панель инструментов".
		}

		private void FontMenu_Click(object sender, EventArgs e) // Пункт меню "Параметры - Шрифт".
		{
			statusStrip.Items[2].Text = "Состояние: " + "настройки шрифта";
			if (fontDialog1.ShowDialog() == DialogResult.OK) // Открытие диалогового окна выбора шрифта, изменения будут внесены после нажатия на ОК.
			{
				richTextBox.Font = fontDialog1.Font; // Установка нового шрифта в текстовое поле.
			}
			statusStrip.Items[2].Text = "Состояние: ";
		}

		private void FontColorMenu_Click(object sender, EventArgs e) // Пункт меню "Параметры - Цвет шрифта".
		{
			statusStrip.Items[2].Text = "Состояние: " + "выбор цвета шрифта";
			ColorDialog MyDialog = new ColorDialog(); // Создание диалогового окна выбора цвета.
			if (MyDialog.ShowDialog() == DialogResult.OK) // Открытие диалогового окна выбора цвета, изменения будут внесены после нажатия на ОК.
			{
				richTextBox.ForeColor = MyDialog.Color; // Установка нового цвета в текстовое поле.
			}
			statusStrip.Items[2].Text = "Состояние: ";
		}
		
		// ПОИСК СЛОВ.
		private void WordSearch_Click(object sender, EventArgs e)
		{
			if (richTextBox.Text != "")
			{
				statusStrip.Items[2].Text = "Состояние: " + "поиск слов";
				FormWord form1 = new FormWord(richTextBox.Text); // Создание диалогового окна поиска слов, передаём текущий текст.
				form1.ShowDialog();
				if (form1.DialogResult == DialogResult.OK) // Если диалог закрыт и вернул результат ОК.
				{
					MessageBox.Show(form1.msg, "Поиск слов"); // Вывод из диалога FormWord переменной msg с найденными словами.
				}
				statusStrip.Items[2].Text = "Состояние: ";
			}
			else
			{
				MessageBox.Show("Поиск слов не может происходить в пустом текстовом поле");
			}
		}

		// СПРАВКА.
		private void Справка_Click(object sender, EventArgs e)
		{
			statusStrip.Items[2].Text = "Состояние: " + "справка о программе";
			FormAbout about = new FormAbout(); // Создание диалогового окна справки.
			about.ShowDialog();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Событие при закрытии программы.
		{
			IsSaveDocChange(); // Был ли сохранён текущий документ.
		}

		private void IsSaveDocChange() // Проверка файла на сохранение.
		{
			if (isDocChanged) // Документ изменён.
			{
				statusStrip.Items[2].Text = "Состояние: " + "проверка на сохранение";

				DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", // Открытие диалогового окна.
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes) // Если нажали Да.
				{
					Save_Click(this, new EventArgs()); // Вызов метода кнопки "Сохранить".
				}
				statusStrip.Items[2].Text = "Состояние: ";
			}
		}
	}
}