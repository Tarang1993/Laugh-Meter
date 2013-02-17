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
    public partial class Form1 : Form
    {
        int c = 0;

                 
        public Form1()
        {
            InitializeComponent();
            Image<Bgr, Byte> f = new Image<Bgr, byte>(300,300);
            MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 2d, 2d);
            f.Draw(c.ToString(), ref font, new Point(32, 55), new Bgr(Color.Red));
            imageBox1.Image = f;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognizer r = new SpeechRecognizer();
            Choices c = new Choices();
            c.Add(new String[] {"haha","hahaha","hahahaha","hahahahaha","hahahahahaha","hahahahahahaha","hahahahahahahaha","hahahahahahahahahah"});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(c);
            Grammar g = new Grammar(gb);
            r.LoadGrammar(g);
            r.SpeechRecognized+=new EventHandler<SpeechRecognizedEventArgs>(r_SpeechRecognized);
        }
        
        void r_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            c++;
            String a= e.Result.Text;
            String low1 = "haha";
            String low2 = "hahaha";
            String med1 = "hahahaha";
            String med2 = "hahahahaha";
            String high1 ="hahahahahaha";
            String high2 ="hahahahahahaha";
            String high3 ="hahahahahahahaha";
            String high4 ="hahahahahahahahaha";
                MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX,2d,2d);
                Image<Bgr, Byte> frame = new Image<Bgr, byte>(300, 300);
                FontFamily ff = new FontFamily("Courier New");    
            Font f = new Font(ff, 50, FontStyle.Italic);
            frame.Draw(c.ToString(), ref font, new Point(32, 55), new Bgr(Color.Red));
              imageBox1.Image = frame;
            if (a.Equals(low1))
            {
                progressBar1.Value = 25;

            }
            if (a.Equals(low2))
             {
                progressBar1.Value = 25;
            
            }
            if (a.Equals(med1))
            {
                progressBar1.Value = 50;
            
            }
            if (a.Equals(med2))
            {
                progressBar1.Value = 50;
            
            }
            if ((a.Equals(high2))||(a.Equals(high1)))
            {
                progressBar1.Value = 80;
            }
            if ((a.Equals(high3)) || (a.Equals(high4)))
            {
                progressBar1.Value = 100;
            
            }
        }   

        
        private void button2_Click(object sender, EventArgs e)
        {
            c = 0;
            //pictureBox1.Image = Image.FromFile("C:\\Users\\Tarang\\Desktop\\New folder\\image6.png");
            Image<Bgr, Byte> f = new Image<Bgr, byte>(300, 300);
            MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 2d, 2d);
            f.Draw(c.ToString(), ref font, new Point(32,55), new Bgr(Color.Red));
            imageBox1.Image = f;
            
            progressBar1.Value = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
                //MessageBoxButtons m = new MessageBoxButtons();
            //m = MessageBoxButtons.YesNo;
            DialogResult a=MessageBox.Show("Do u really want to exit?", "Important!", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                Close();
            }
            if (a == DialogResult.No)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
