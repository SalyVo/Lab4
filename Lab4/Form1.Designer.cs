﻿namespace Lab4
{
    partial class Form1
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWord = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listWords = new System.Windows.Forms.ListBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(284, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время загрузки файла";
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(142, 33);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(130, 20);
            this.textFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Слово";
            // 
            // textWord
            // 
            this.textWord.Location = new System.Drawing.Point(56, 60);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(130, 20);
            this.textWord.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSearch.Location = new System.Drawing.Point(192, 59);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listWords
            // 
            this.listWords.FormattingEnabled = true;
            this.listWords.Location = new System.Drawing.Point(16, 86);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(256, 134);
            this.listWords.TabIndex = 6;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(130, 226);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(142, 20);
            this.textSearch.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время поиска слова";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listWords);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Лабораторная №4";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listWords;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label3;
    }
}

