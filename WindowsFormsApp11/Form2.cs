using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public bool closeForm1 = false;
        public Form2()
        {
            InitializeComponent();
            //label2.Text += form1.nameUser;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Censorship_Click(object sender, EventArgs e)
        {

            string censorship = textCensorship.Text;
            if (censorship != "")
            {
                string text = textBase.Text;
                string[] censorshipArray = censorship.Split(';', ',', ' ');
                string[] pattern = (censorshipArray);
                string target = "***";
                foreach (string el in censorshipArray)
                {
                    Regex swear = new Regex(el, RegexOptions.IgnoreCase);
                    if (swear.IsMatch(text) == true)
                        text = swear.Replace(text, target);
                }

                CorrectText.Text = text;
            }
            else
            {
                MessageBox.Show("You didn't input not correct words");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, textBase.Text);
            MessageBox.Show("Файл сохранен");
        }

       

        private void SaveNorCorrectWords_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            File.WriteAllText(filename, Censorship.Text);
            MessageBox.Show("Файл сохранен");

        }

        private void OpenNorCorrectWords_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textBase.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void baseTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textBase.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void textAfterCensorshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textCensorship.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void baseTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBase.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void notCorrectWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, Censorship.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void textAfterCensorshipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, CorrectText.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void allCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutOfYourAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            form1 = new Form1();
            form1.Visible = true;
            Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Продукт предназначени для цензуры неприличных слов, которые вы можете указать в поле \"Not correct words\". " +
                "Кнопка \"Import for...\" позволяет вам загрузить готовый текст в формате \".txt\" в поля \" Base text\" и \"Not correct words\". Кнопка \"Save... \" позволяет сохранить текст. А кнопка \"Exit\"" +
                "дает возможность выйти со своего аккаунта, вернувшись к форме \"Login and Password\" или выйти со своего аккаунта с послеующим закрытием программы. ");
        }
    }
}
