namespace Lab_4
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.NewDocument = new System.Windows.Forms.ToolStripButton();
			this.openFile = new System.Windows.Forms.ToolStripButton();
			this.Save = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printText = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAS = new System.Windows.Forms.ToolStripMenuItem();
			this.ParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowOrHide = new System.Windows.Forms.ToolStripMenuItem();
			this.FontMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.FontColorMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Справка = new System.Windows.Forms.ToolStripMenuItem();
			this.WordSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDocument,
            this.openFile,
            this.Save,
            this.toolStripSeparator1,
            this.printText});
			this.toolStrip.Location = new System.Drawing.Point(0, 28);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 71);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			// 
			// NewDocument
			// 
			this.NewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NewDocument.Image = ((System.Drawing.Image)(resources.GetObject("NewDocument.Image")));
			this.NewDocument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.NewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewDocument.Name = "NewDocument";
			this.NewDocument.Size = new System.Drawing.Size(68, 68);
			this.NewDocument.Text = "Создать";
			this.NewDocument.Click += new System.EventHandler(this.NewDocument_Click);
			// 
			// openFile
			// 
			this.openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
			this.openFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(68, 68);
			this.openFile.Text = "Открыть";
			this.openFile.Click += new System.EventHandler(this.openFile_ButtonClick);
			// 
			// Save
			// 
			this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
			this.Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(68, 68);
			this.Save.Text = "Сохранить";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
			// 
			// printText
			// 
			this.printText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printText.Image = ((System.Drawing.Image)(resources.GetObject("printText.Image")));
			this.printText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.printText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printText.Name = "printText";
			this.printText.Size = new System.Drawing.Size(68, 68);
			this.printText.Text = "Печать";
			this.printText.Click += new System.EventHandler(this.printText_ButtonClick);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
			this.statusStrip.Location = new System.Drawing.Point(0, 424);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 26);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 20);
			this.toolStripStatusLabel1.Text = "Число знаков: 0";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(333, 20);
			this.toolStripStatusLabel2.Spring = true;
			this.toolStripStatusLabel2.Text = "Число строк: 0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(333, 20);
			this.toolStripStatusLabel3.Spring = true;
			this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ParamToolStripMenuItem,
            this.Справка,
            this.WordSearch});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 28);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.SaveAS});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.NewDocument_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openFile_ButtonClick);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
			// 
			// SaveAS
			// 
			this.SaveAS.Name = "SaveAS";
			this.SaveAS.Size = new System.Drawing.Size(201, 26);
			this.SaveAS.Text = "Сохранить как...";
			this.SaveAS.Click += new System.EventHandler(this.SaveAS_Click);
			// 
			// ParamToolStripMenuItem
			// 
			this.ParamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowOrHide,
            this.FontMenu,
            this.FontColorMenu});
			this.ParamToolStripMenuItem.Name = "ParamToolStripMenuItem";
			this.ParamToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
			this.ParamToolStripMenuItem.Text = "Параметры";
			// 
			// ShowOrHide
			// 
			this.ShowOrHide.Name = "ShowOrHide";
			this.ShowOrHide.Size = new System.Drawing.Size(246, 26);
			this.ShowOrHide.Text = "Панель инструментов";
			this.ShowOrHide.Click += new System.EventHandler(this.ShowOrHide_Click);
			// 
			// FontMenu
			// 
			this.FontMenu.Name = "FontMenu";
			this.FontMenu.Size = new System.Drawing.Size(246, 26);
			this.FontMenu.Text = "Шрифт";
			this.FontMenu.Click += new System.EventHandler(this.FontMenu_Click);
			// 
			// FontColorMenu
			// 
			this.FontColorMenu.Name = "FontColorMenu";
			this.FontColorMenu.Size = new System.Drawing.Size(246, 26);
			this.FontColorMenu.Text = "Цвет шрифта";
			this.FontColorMenu.Click += new System.EventHandler(this.FontColorMenu_Click);
			// 
			// Справка
			// 
			this.Справка.Name = "Справка";
			this.Справка.Size = new System.Drawing.Size(81, 26);
			this.Справка.Text = "Справка";
			this.Справка.Click += new System.EventHandler(this.Справка_Click);
			// 
			// WordSearch
			// 
			this.WordSearch.Name = "WordSearch";
			this.WordSearch.Size = new System.Drawing.Size(102, 26);
			this.WordSearch.Text = "Поиск слов";
			this.WordSearch.Click += new System.EventHandler(this.WordSearch_Click);
			// 
			// richTextBox
			// 
			this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox.Location = new System.Drawing.Point(0, 99);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(800, 325);
			this.richTextBox.TabIndex = 3;
			this.richTextBox.Text = "";
			this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.Text = "Новый документ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ParamToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Справка;
		private System.Windows.Forms.ToolStripMenuItem WordSearch;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.ToolStripButton NewDocument;
		private System.Windows.Forms.ToolStripButton openFile;
		private System.Windows.Forms.ToolStripButton Save;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton printText;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripMenuItem ShowOrHide;
		private System.Windows.Forms.ToolStripMenuItem FontMenu;
		private System.Windows.Forms.ToolStripMenuItem FontColorMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAS;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
	}
}

