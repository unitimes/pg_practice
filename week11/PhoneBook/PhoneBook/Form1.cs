using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//for file IO
using System.IO;
//for xml serialize
using System.Xml.Serialization;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneBook pb;
        public Form1()
        {
            InitializeComponent();
            pb = new PhoneBook();
            saveFileDialog1.Filter = "저장파일|*.xml|전부|*.*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            statusLabel1.Text = "편집 중";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("euc-kr"));
            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));
            pb = (PhoneBook)xs.Deserialize(sr);
            textBox1.Text = pb.GetAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("euc-kr"));
            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));
            
            //writing files
            xs.Serialize(sw, pb);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pb.AddDatas(textBox1.Text);
        }
    }
}
