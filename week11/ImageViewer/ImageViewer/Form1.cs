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
using System.Xml.Serialization;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG|*.jpg|모든파일|*.*";
            openFileDialog2.Filter = "xml|*.xml|모든파일|*.*";
            saveFileDialog1.Filter = "xml|*.xml|모든파일|*.*";
            statusLabel1.Text = "상태 창";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            statusLabel1.Text = "그림 로딩 중";
            Image img = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;
            statusLabel1.Text = "그림 로딩 완료";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            //Bitmap bmp = new Bitmap(pictureBox1.Image);
            ImageData jungmin = new ImageData();
            jungmin.SetSize(bmp.Width, bmp.Height);
            for (int i = 0; i < jungmin.height; i++)
            {
                for (int j = 0; j < jungmin.width; j++)
                    jungmin.pixel[(jungmin.width * i) + j] = bmp.GetPixel(j, i).ToArgb();
            }
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            statusLabel1.Text = "그림 저장 중";
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            xs.Serialize(sw, jungmin);
            sw.Close();
            statusLabel1.Text = "그림 저장 완료";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            statusLabel1.Text = "그림 로딩 중";
            StreamReader sr = new StreamReader(openFileDialog2.FileName);
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            ImageData imgData = (ImageData)xs.Deserialize(sr);

            Bitmap bmp = new Bitmap(imgData.width, imgData.height);

            for (int i = 0; i < imgData.pixel.Length; i++)
            {
                bmp.SetPixel(i % imgData.width, i / imgData.width, Color.FromArgb(imgData.pixel[i]));
            }
            pictureBox1.Image = bmp;
            sr.Close();
            statusLabel1.Text = "그림 로딩 완료";
        }
    }
}
