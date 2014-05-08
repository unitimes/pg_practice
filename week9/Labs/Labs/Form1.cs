using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form1 : Form
    {
        const string MSG = "입력하세요.";
        public Form1()  //생성자
        {
            InitializeComponent();
            label1.Text = "텍스트 입력 프로그램";
            textBox2.Text = MSG;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == MSG)
            {
                if (radioButton1.Checked)
                {
                    textBox2.Text = radioButton1.Text + ": " + textBox1.Text;
                    radioButton2.Select();
                }
                else
                {
                    textBox2.Text = radioButton2.Text + ": " + textBox1.Text;
                    radioButton1.Select();
                }
            }
            else
            {
                if (radioButton1.Checked)
                {
                    textBox2.AppendText("\r\n" + radioButton1.Text + ": " + textBox1.Text);
                    radioButton2.Select();
                }
                else
                {
                    textBox2.AppendText("\r\n" + radioButton2.Text + ": " + textBox1.Text);
                    radioButton1.Select();

                }
            }
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textBox2.Text == MSG)
                {
                    if (radioButton1.Checked)
                    {
                        textBox2.Text = radioButton1.Text + ": " + textBox1.Text;
                        radioButton2.Select();
                    }
                    else
                    {
                        textBox2.Text = radioButton2.Text + ": " + textBox1.Text;
                        radioButton1.Select();
                    }

                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        textBox2.AppendText("\r\n" + radioButton1.Text + ": " + textBox1.Text);
                        radioButton2.Select();
                    }
                    else
                    {
                        textBox2.AppendText("\r\n" + radioButton2.Text + ": " + textBox1.Text);
                        radioButton1.Select();

                    }
                }
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = MSG;
        }
    }
}
