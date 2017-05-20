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
using Emgu.CV.Structure;
using Emgu.CV;

namespace car_speed_calculator
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer My_Time = new Timer();
        int FPS = 30;
        System.Collections.Generic.List<Emgu.CV.Image<Emgu.CV.Structure.Bgr,System.Byte>> image_array = new List<Image<Bgr, Byte>>();
        Emgu.CV.Capture _capture;
        public Form1()
        {
            InitializeComponent();
        }

        private void My_Timer_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = _capture.QueryFrame().ToImage<Bgr,Byte>();
            pictureBox1.Image = frame.ToBitmap();
            Console.WriteLine("ok");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            string file="";
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                }
                catch (IOException err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
            My_Time.Interval = 1000 / FPS;
            My_Time.Tick += new EventHandler(My_Timer_Tick);
            My_Time.Start();
            _capture = new Capture(file);
        }
    }
}
