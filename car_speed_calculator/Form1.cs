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
        int threshhold_value = 50;
        System.Collections.Generic.List<Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte>> image_array = new List<Image<Bgr, Byte>>();
        Emgu.CV.Capture _capture;
        string file = "";
        //get a first image and convert it into gray scale
        Image<Bgr, byte> firstFrame;
        Image<Gray, byte> firstFrameGray;
        public Form1()
        {
            InitializeComponent();
        }

        private void My_Timer_Tick(object sender, EventArgs e)
        {
            using (Emgu.CV.Image<Bgr, byte> nextFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (nextFrame != null)
                {
                    //convert both images into gray
                    Image<Gray, byte> nextFrameGray = nextFrame.Convert<Gray, byte>();
                    Image<Bgr, byte> nextNextFrame = _capture.QueryFrame().ToImage<Bgr, byte>();
                    Image<Gray, byte> nextNextFrameGray = nextNextFrame.Convert<Gray, byte>();
                    //find absolute diff of gray images
                    Image<Gray, byte> diffFrame = nextFrameGray.AbsDiff(nextNextFrameGray);
                    pictureBox1.Image = nextFrame.ToBitmap();
                    //convert diffFrame to binary
                    Image<Gray, byte> diffFrameBinary = diffFrame.ThresholdBinary(new Gray(30), new Gray(255));
                    //create an empty image
                    Image<Gray, byte> resultImage = diffFrameBinary;
                    //create a structuring element
                    var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(2,2), new Point(-1, -1));
                    //apply dilation on image
                    Emgu.CV.CvInvoke.Dilate(diffFrameBinary, resultImage,element,new Point(-1,-1),10,Emgu.CV.CvEnum.BorderType.Default,default(MCvScalar));
                    //convert the image to bitmap and set to picturebox
                    pictureBox2.Image = resultImage.ToBitmap();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Start Button
            if (file == "")
                MessageBox.Show("Please select a video first", "Error");
            else
            {
                My_Time.Interval = 1000 / FPS;
                My_Time.Tick += new EventHandler(My_Timer_Tick);
                My_Time.Start();
                _capture = new Capture(file);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Select Video Button
            DialogResult result = openFileDialog1.ShowDialog();
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
                Capture previewCapture = new Capture(file);
                this.firstFrame = previewCapture.QueryFrame().ToImage<Bgr, Byte>();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                this.firstFrameGray = this.firstFrame.Convert<Gray, byte>();
                pictureBox1.Image = this.firstFrame.ToBitmap();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Stop Button
            if (file == "")
                MessageBox.Show("Please select a video first", "Error");
            else
            {
                My_Time.Stop();
                Capture previewCapture = new Capture(file);
                firstFrame = previewCapture.QueryFrame().ToImage<Bgr, Byte>();
                firstFrameGray = firstFrame.Convert<Gray, byte>();
                pictureBox1.Image = firstFrame.ToBitmap();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Pause Button
            if (file == "")
                MessageBox.Show("Please select a video first", "Error");
            else
            {
                if (button6.Text == "Pause")
                {
                    button6.Text = "Play";
                    button6.BackColor = Color.Green;
                }
                else
                {
                    button6.Text = "Pause";
                    button6.BackColor = Color.Red;
                }
                //My_Time.Stop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Binarize Video Button
            if (file == "")
                MessageBox.Show("Please select a video first", "Error");
            else
            {
                My_Time.Stop();
            }
        }
    }
}