using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Speech.Recognition;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV;


namespace LaughMeter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Form2 g = new Form2();
            g.Close();
            ActiveForm.Close(); //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text="Desktop Application: Laugh Meter\r\n\r\nThis Application will measure the intensity of your laugh and also keeps the counter of your each laugh.\r\nThis will be helpful to find the no. of times you laugh in a day.\r\n\r\nThe average four year old child laughs 300 times a day while a 40 year old laughs hardly 4 times a day.\r\n\r\nSo check out how many times you laugh in a day.\r\n\r\nCreated By:\r\nTarang Patel\r\nNikhil Maheswari";
            //textBox1.Text += "a";
        }

    }
}
