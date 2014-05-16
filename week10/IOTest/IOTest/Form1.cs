using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IOTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Open";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.ResetText();

                string str = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = str;

                LoadTxt(str);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Save as";
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = saveFileDialog1.FileName;
                toolStripStatusLabel1.Text = str;

                SaveTxt(str);
            }
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void LoadTxt(string fileName)
        {
            StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("euc-kr"));
            while (sr.Peek() != -1)
            {
                textBox1.Text += sr.ReadLine() + "\r\n";
            }
            sr.Close();
        }

        private void SaveTxt(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, true, Encoding.GetEncoding("euc-kr"));
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }
    }
}
