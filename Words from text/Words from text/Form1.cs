using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words_from_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("filePath.txt");//беру путь из файла
            textBoxreView.Text = sr.ReadToEnd();//присваиваю
            sr.Close();
        }
        string FileDirectory; //задаю переменную для присваивания пути файла
        private void buttonrVeiew_Click(object sender, EventArgs e)
        {
            //работа кнопки обзор
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt|Файлы Word|*.docx";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                textBoxreView.Text = OPF.FileName;
                FileDirectory = OPF.FileName;
            }
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxreView?.Text.Trim()))
            {
                MessageBox.Show("Путь на файл не выбран",
                "Внимание",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                FileDirectory = textBoxreView.Text.Trim();
                StreamWriter screenwriter = new StreamWriter("filePath.txt");//запоминаем путь в файле
                screenwriter.Write(FileDirectory);
                screenwriter.Close();//закрываем поток 

                if (File.Exists(FileDirectory))
                {
                    Working working = new Working();//переход к след. форме
                    working.Show();
                    this.Hide();
                    working.Location = this.Location;
                }
                else
                {
                    MessageBox.Show("Файл по пути не найден",
                     "Внимание",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }

        }

        private void textBoxreView_MouseClick(object sender, MouseEventArgs e)
        {
            labelPath.Visible = false;
        }

        private void textBoxreView_TextChanged(object sender, EventArgs e)
        {
            labelPath.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
