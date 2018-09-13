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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Censorship_Click(object sender, EventArgs e)
        {
            string censorship = textCensor.Text;
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

        private void baseTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textBase.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename, Encoding.GetEncoding(1251));
            textCensor.Text = fileText;
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

        private void textAfterCensorshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, CorrectText.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void notCorrectWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textCensor.Text);
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

        private void adminMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            
        }
    }
}
