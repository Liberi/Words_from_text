using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Words_from_text
{
    public partial class Working : Form
    {
        public Working()
        {
            InitializeComponent();
        }
        string FileDirectory;
        private void Working_Load(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Проверьте текст перед началом, после нажмите _Начать_",
                "Проверьте",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();//подсказка на чекбоксе
            StreamReader sr = new StreamReader("filePath.txt");//беру путь из файла
            FileDirectory = sr.ReadToEnd();//присваиваю
            sr.Close();
            richText.Text = new StreamReader(FileDirectory).ReadToEnd();
            richText.SelectionStart = 0;
            SaveButton.Enabled = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("new_file.txt"))
            {
                SaveFileDialog SVF = new SaveFileDialog();
                SVF.Filter = "Файлы txt|*.txt|Файлы Word|*.docx";
                if (SVF.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(SVF.FileName);
                    string filePath = SVF.FileName;
                    File.AppendAllText(filePath, richText.Text);
                }
            }
            else
            {
                MessageBox.Show("Файл по пути не найден",
                 "Внимание",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            File.Delete("new_file.txt");
            SaveButton.Enabled = false;
            richText.Enabled = false;
            Next2.Enabled = false;
            button2.Enabled = false;
            progressBar1.Value = 0;
            string[] WordsText = new StreamReader(FileDirectory).ReadToEnd().Split(' ');
            HashSet<string> uniqueWords = new HashSet<string>();//только уникальные слова
            progressBar1.Maximum = WordsText.Length;
            Random rnd = new Random();
            string finalWord;
            foreach (string word in WordsText)
            {
                finalWord = new string((from c in word where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());
                if (finalWord.Length >= 5 && finalWord.Length <= 30
                    && rnd.Next(0, 6) == 2
                    && !finalWord.Contains("\n")
                    && !uniqueWords.Contains(finalWord.Trim())
                    && !string.IsNullOrWhiteSpace(finalWord.Trim()) && !finalWord.Trim().All(char.IsDigit))
                {
                    File.AppendAllText("new_file.txt", $"{finalWord.Trim()}\r\n");
                    uniqueWords.Add(finalWord.Trim());
                }
                progressBar1.Value++;
            }
            richText.Text = "";
            richText.Font = new Font("Times New Roman", 20.0f, FontStyle.Bold);
            foreach (string word in uniqueWords)
            {
                richText.Text += word + "\r\n";
            }
            button2.Enabled = true;
            richText.Enabled = true;
            Next2.Enabled = true;
            SaveButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();//переход назад
            Form1.Show();
            this.Hide();
        }

        private void Working_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
