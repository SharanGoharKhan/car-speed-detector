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
using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace car_speed_calculator
{
    public static class MyUtilities
    {
        public static VectorOfVectorOfPoint FindContours(this Image<Gray, byte> image, Emgu.CV.CvEnum.ChainApproxMethod method = Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple
            , Emgu.CV.CvEnum.RetrType type = Emgu.CV.CvEnum.RetrType.List)
        {
            VectorOfVectorOfPoint result = new Emgu.CV.Util.VectorOfVectorOfPoint();
            //if(method == Emgu.CV.CvEnum.ChainApproxMethod.ChainCode)
            //{
            //    throw new ColsaNotImplementedException
            //}
            CvInvoke.FindContours(image, result, null, type, method);
            return result;
        }
    }

    public  partial class Form1 : Form
    {
        System.Windows.Forms.Timer My_Time = new Timer();
        int FPS = 30;
        int threshhold_value = 50;
        System.Collections.Generic.List<Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte>> image_array = new List<Image<Bgr, Byte>>();
        VideoCapture _capture;
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
                using (Emgu.CV.Image<Bgr, byte> orignalFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                //convert image into gray
                Image<Bgr, byte> image = orignalFrame.Resize(pictureBox1.Width, pictureBox1.Height, 0);
                Image<Gray, byte> frame = image.Convert<Gray, byte>();
                //perform differencing on them to find the 'new introduction to the background and motions"
                Image<Gray, byte> BgDifference = new Image<Gray, byte>(pictureBox1.Width, pictureBox1.Height);
                Image<Gray, byte> FrameDifference = new Image<Gray, byte>(pictureBox1.Width, pictureBox1.Height);
                //since i don't have a background image let next frame be considered as background
                Image<Bgr, byte> nextFrame = _capture.QueryFrame().ToImage<Bgr, byte>().Resize(pictureBox1.Width,pictureBox1.Height,0);
                Image<Gray, byte> nextFrameGray = nextFrame.Convert<Gray, byte>();
                CvInvoke.AbsDiff(frame, nextFrameGray, BgDifference);
                //Perform thresholding to remove noise and boost "new introductions"
                Image<Gray, byte> thresholded = new Image<Gray, byte>(pictureBox1.Width, pictureBox1.Height);
                CvInvoke.Threshold(BgDifference, thresholded, 20, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                //Perform erosion to remove camera noise
                var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(2, 2), new Point(-1, -1));
                Image<Gray, byte> eroded = new Image<Gray, byte>(pictureBox1.Width, pictureBox1.Height);
                CvInvoke.Erode(thresholded, eroded, element, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Default, default(MCvScalar));
                //Takes the threshholded image and looks for square and draws the squares out on top of the current frame
                drawBoxes(eroded, image);
            }
        }
        private void drawBoxes(Emgu.CV.Image<Gray,byte> img, Emgu.CV.Image<Bgr,byte> original)
        {
            Gray cannyThreshold = new Gray(180);
            Gray cannyTheshholdLinking = new Gray(120);
            Gray circleAccumulatorThreshhold = new Gray(120);

            Image<Gray, byte> cannyEdges = img.Canny(180,120);
            LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
                2,//Distance resolution in pixel-related units
                Math.PI / 45.0,//Angle resolution measured in radians
                20,//threshold
                30,//min line width
                10//gap between lines
                )[0];//Get the lines from the first channel
            #region Find rectangles
            List<MCvBlob> boxList = new List<MCvBlob>();
            using ( Emgu.Util.TypeEnum. = new MemStorage()) //allocate storage for contour approximation
                {
                var index = 0;
                    for (Emgu.CV.CvInvoke.con contours = cannyEdges.FindContours(); contours!=null;contours = contours[index])
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
                _capture = new VideoCapture(file);
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
                VideoCapture previewCapture = new VideoCapture(file);
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
                VideoCapture previewCapture = new VideoCapture(file);
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