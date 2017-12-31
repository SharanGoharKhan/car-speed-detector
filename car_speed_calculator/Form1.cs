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
using Emgu.CV.Tracking;
using System.Threading;

namespace car_speed_calculator
{
   
    public  partial class Form1 : Form
    {
        //modified
        int progessBarvalue = 0;
        System.Windows.Forms.Timer My_Time = new System.Windows.Forms.Timer();
        List<RotatedRect> previousBoxes = new List<RotatedRect>();
        int FPS = 20;
        VideoCapture _capture;
        string file = "";
        //get a first image and convert it into gray scale
        bool isEroded = false;
        bool isDilated = false;
        Image<Bgr, byte> firstFrame;
        Image<Gray, byte> firstFrameGray;
        double previousCentroidX = 0;
        double previousCentroidY = 0;
        double currentCentroidX = 0;
        double currentCentroidY = 0;
        int speedBoxX = 100;
        int speedBoxY = 400;
        int speedBoxW = 100;
        int speedBoxH = 100;
        int distanceValue = 10;
       
        private void showLoadingScreen()
        {
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            progressBar1.Maximum = 1000000;
            for (int i = 0; i < 1000000; ++i)
            {
                for(int j=0;j<10000;++j)
                {

                }
                //aTimer.Elapsed += updateProgressBar;
                //aTimer.AutoReset = true;
                //aTimer.Enabled = true;
                //System.Threading.Thread.Sleep(5);
                progressBar1.PerformStep();
            }
    }
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            //showLoadingScreen();
            //pictureBox1.ImageLocation = "placeholder-image.jpg";
            //pictureBox2.ImageLocation = "placeholder-image.jpg";
            //pictureBox3.ImageLocation = "placeholder-image.jpg";
            pictureBox4.ImageLocation = "placeholder-image.jpg";
        }
        private void My_Timer_Tick(object sender, EventArgs e)
        {
                if(_capture.QueryFrame() == null)
            {
                My_Time.Stop();
                return;
            }
                using (Emgu.CV.Image<Bgr, byte> orignalFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                #region getValueDynamically
                int erosionValue = Convert.ToInt32(labelErosionValue.Text.ToString());
                int dilationValue = Convert.ToInt32(labelDilationValue.Text.ToString());
                #endregion
                pictureBox4.Image = orignalFrame.ToBitmap();
                //convert image into gray
                Image<Bgr, byte> image = orignalFrame.Resize(pictureBox4.Width, pictureBox4.Height, 0);
                Image<Gray, byte> frame = image.Convert<Gray, byte>();
                //perform differencing on them to find the 'new introduction to the background and motions"
                Image<Gray, byte> BgDifference = new Image<Gray, byte>(pictureBox4.Width, pictureBox4.Height);
                Image<Gray, byte> FrameDifference = new Image<Gray, byte>(pictureBox4.Width, pictureBox4.Height);
                //since i don't have a background image let next frame be considered as background
                //if(_capture.QueryFrame().ToImage<Bgr,byte>() == null)
                //{
                //    My_Time.Stop();
                //    return;
                //}
                Image<Bgr, byte> nextFrame = _capture.QueryFrame().ToImage<Bgr, byte>().Resize(pictureBox4.Width, pictureBox4.Height, 0);
                Image<Gray, byte> nextFrameGray = nextFrame.Convert<Gray, byte>();
                CvInvoke.AbsDiff(frame, nextFrameGray, BgDifference);
                //Perform thresholding to remove noise and boost "new introductions"
                Image<Gray, byte> thresholded = new Image<Gray, byte>(pictureBox4.Width, pictureBox4.Height);
                CvInvoke.Threshold(BgDifference, thresholded, 20, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                //pictureBox2.Image = thresholded.Bitmap;
                //pictureBox2Label.Text = "Abs Difference image";
                //Perform erosion to remove camera noise
                var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(2, 2), new Point(-1, -1));
                Image<Gray, byte> eroded = new Image<Gray, byte>(pictureBox4.Width, pictureBox4.Height);
                if(isDilated)
                    CvInvoke.Dilate(thresholded, eroded, element, new Point(-1, -1), dilationValue, Emgu.CV.CvEnum.BorderType.Default, default(MCvScalar));
                if(isEroded)
                    CvInvoke.Erode(thresholded, eroded, element, new Point(-1, -1), erosionValue, Emgu.CV.CvEnum.BorderType.Default, default(MCvScalar));
                System.Drawing.Size kSize = new Size(10, 10);
                CvInvoke.Blur(thresholded, eroded, kSize,new Point(-1,-1),Emgu.CV.CvEnum.BorderType.Default);
                CvInvoke.Threshold(eroded, eroded, 10, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                //pictureBox3.Image = eroded.Bitmap;
                //pictureBox3Label.Text = "Eroded/Dilated Image";
                //Takes the threshholded image and looks for square and draws the squares out on top of the current frame
                //CvInvoke.Erode(eroded, eroded, element, new Point(-1, -1), 20, Emgu.CV.CvEnum.BorderType.Default, default(MCvScalar));
                CvInvoke.Imshow("ErodedImage", eroded);
                CvInvoke.MedianBlur(eroded, eroded, 7);
                //CvInvoke.Dilate(eror)
                drawBoxes(eroded, image);
            }
        }
        private void calculateSpeed(RotatedRect rect)
        {
            //if the rect enters the frame for the first time
            if(previousCentroidX == 0 || previousCentroidY ==0)
            {
                previousCentroidX = rect.Center.X;
                previousCentroidY = rect.Center.Y;
            }
            else
            {
                currentCentroidX = rect.Center.X;
                currentCentroidY = rect.Center.Y;
                //calculate the distance 
                double distance = Math.Sqrt(Math.Pow(currentCentroidX - previousCentroidX, 2) + Math.Pow(currentCentroidY - previousCentroidY, 2));
                distance = Math.Floor(distance)*Math.Log(distanceValue);
                //if (distance > 30)
                //    distance = 30;
                distance = Math.Floor(distance);
                labelSpeedValue.Text = distance.ToString();
                previousCentroidX = currentCentroidX;
                previousCentroidY = currentCentroidY;
            }
            
        }
        private void drawBoxes(Emgu.CV.Image<Gray,byte> img, Emgu.CV.Image<Bgr,byte> original)
        {
            Gray cannyThreshold = new Gray(180);
            Gray cannyTheshholdLinking = new Gray(120);
            Gray circleAccumulatorThreshhold = new Gray(120);

            Image<Gray, byte> cannyEdges = img.Canny(180,120);
            CvInvoke.Imshow("cannyEdges", cannyEdges);
            //pictureBox3.Image = cannyEdges.ToBitmap();
            //LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
            //    1,//Distance resolution in pixel-related units
            //    Math.PI / 45.0,//Angle resolution measured in radians
            //    20,//threshold
            //    30,//min line width
            //    10//gap between lines
            //    )[0];//Get the lines from the first channel
            #region Find rectangles
            //Image<Bgr, Byte> imageLines = new Image<Bgr, byte>(cannyEdges.Width, cannyEdges.Height);
            //foreach(LineSegment2D line in lines)
            //{
            //    imageLines.Draw(line, new Bgr(Color.DeepSkyBlue), 1);
            //}
            //Image<Bgr, byte> circleLines = new Image<Bgr, byte>(cannyEdges.Width, cannyEdges.Height);
            //CircleF[] circles = CvInvoke.HoughCircles(cannyEdges, Emgu.CV.CvEnum.HoughType.Gradient, 2.0, 20.0, 120, 120, 5);
            //foreach(CircleF circle in circles)
            //{
            //    circleLines.Draw(circle, new Bgr(Color.DeepSkyBlue), 1);
            //}
            //pictureBox4.Image = circleLines.ToBitmap();
            //pictureBox4Label.Text = "Result Image";
            //List<Triangle2DF> boxList = new List<Triangle2DF>();
            //using ( VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint()) //allocate storage for contour approximation
            //    {
            //        CvInvoke.FindContours()                
            //    }
            List<RotatedRect> boxList = new List<RotatedRect>();
            Image<Bgr, Byte> imageCircles = new Image<Bgr, byte>(cannyEdges.Width, cannyEdges.Height);
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, Emgu.CV.CvEnum.RetrType.List, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for(int i = 0; i<count;i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        //CvInvoke.ApproxPolyDP(contour,approxContour,CvInvoke.arc,true)
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        if(CvInvoke.ContourArea(approxContour,false)>500)
                            boxList.Add(CvInvoke.MinAreaRect(approxContour));
                        //if(CvInvoke.ContourArea(approxContour,false)>500) //only consider contours with area greater than 250
                        //{
                        //    if(approxContour.Size == 4) // The contour has 4 vertices
                        //    {
                        //        #region determine if all the angles in the contour are within [80,100] degree
                        //        bool isRectangle = true;
                        //        Point[] pts = approxContour.ToArray();
                        //        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);
                        //        for(int j=0;j<edges.Length;j++)
                        //        {
                        //            double angle = Math.Abs(edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                        //            if (angle < 0 || angle > 360)
                        //            {
                        //                isRectangle = false;
                        //                break;
                        //            }
                        //        }
                        //        #endregion
                        //        if (isRectangle)
                        //            boxList.Add(CvInvoke.MinAreaRect(approxContour));
                        //    }
                        //}
                    }
                }
            }
            #endregion Find rectangles
            int currentboxListCount = boxList.Count;
       
            Boolean firstBoxCalled = false;
            foreach (RotatedRect box in boxList)
            {
                Rectangle temp = new Rectangle(Int32.Parse(Math.Ceiling(box.Center.X).ToString()), Int32.Parse(Math.Ceiling(box.Center.Y).ToString()), 40, 40);
                if (speedBoxX < box.Center.X && speedBoxY < box.Center.Y && speedBoxX + speedBoxW > box.Center.X && speedBoxY + speedBoxH > box.Center.Y)
                {
                    if(!firstBoxCalled)
                    {
                        calculateSpeed(box);
                        firstBoxCalled = true;
                    }
                    original.Draw(temp, new Bgr(Color.Green), 2);
                }
                else
                    original.Draw(temp, new Bgr(Color.DeepSkyBlue), 1);
                //CvInvoke.PutText(original, "(" + Math.Ceiling(box.Center.X).ToString() + "," + Math.Ceiling(box.Center.Y).ToString() + ")", new Point((int)Math.Ceiling(box.Center.X), (int)Math.Ceiling(box.Center.Y)), Emgu.CV.CvEnum.FontFace.HersheyComplex, .5, new Bgr(0, 255, 0).MCvScalar);
            }
            System.Drawing.Rectangle speedBox = new Rectangle(speedBoxX, speedBoxY, speedBoxW, speedBoxH);
            //RotatedRect speedBox = new RotatedRect(new PointF(speedBoxX, speedBoxY), new SizeF(speedBoxW, speedBoxH), 0);
            original.Draw(speedBox, new Bgr(Color.Red), 4);
            pictureBox4.Image = original.ToBitmap();
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
        //private void reduceBoxes(List<RotatedRect> currentBoxes)
        //{
        //    List<RotatedRect> resultBoxes = new List<RotatedRect>();
        //    foreach(RotatedRect currBox in currentBoxes)
        //    {
        //        foreach(RotatedRect prevBox in this.previousBoxes)
        //        {
        //            if(currBox.Center.X == prevBox )
        //        }
        //    }
        //}
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
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                this.firstFrameGray = this.firstFrame.Convert<Gray, byte>();
                //pictureBox1.Image = this.firstFrame.ToBitmap();

            }
        }

        private void buttonErosionPlus_Click(object sender, EventArgs e)
        {
            isEroded = true;
            isDilated = false;
            int valueOfErosion = Convert.ToInt32(labelErosionValue.Text.ToString());
            valueOfErosion++;
            labelErosionValue.Text = valueOfErosion.ToString();
        }

        private void buttonErosionMinus_Click(object sender, EventArgs e)
        {
            isEroded = true;
            isDilated = false;
            int valueOfErosion = Convert.ToInt32(labelErosionValue.Text.ToString());
            if (valueOfErosion > 0)
                valueOfErosion--;
            labelErosionValue.Text = valueOfErosion.ToString();
        }

        private void buttonDilationPlus_Click(object sender, EventArgs e)
        {
            isDilated = true;
            isEroded = false;
            int valueOfDilation = Convert.ToInt32(labelDilationValue.Text.ToString());
            valueOfDilation++;
            labelDilationValue.Text = valueOfDilation.ToString();
        }

        private void buttonDilationMinus_Click(object sender, EventArgs e)
        {
            isDilated = true;
            isEroded = false;
            int valueOfDilation = Convert.ToInt32(labelDilationValue.Text.ToString());
            if (valueOfDilation > 0)
                valueOfDilation--;
            labelDilationValue.Text = valueOfDilation.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            speedBoxY -= 10;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            speedBoxY += 10;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            speedBoxX -= 10;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            speedBoxX += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            labelDistance.Hide();
            buttonDistanceMinus.Hide();
            buttonDistancePlus.Hide();
            progressBar1.ForeColor = Color.Red;
            progressBar1.Increment(1);
            this.progessBarvalue += 1;
            if(progressBar1.Maximum == this.progessBarvalue)
            {
                label1.Show();
                label2.Show();
                labelDistance.Show();
                buttonDistanceMinus.Show();
                buttonDistancePlus.Show();
                panel1.Hide();
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void buttonDistancePlus_Click(object sender, EventArgs e)
        {
            int valueOfDistance = Convert.ToInt32(labelDistance.Text.ToString());
            valueOfDistance += 1;
            distanceValue = valueOfDistance;
            labelDistance.Text = valueOfDistance.ToString();
        }

        private void buttonDistanceMinus_Click(object sender, EventArgs e)
        {
            int valueOfDistance = Convert.ToInt32(labelDistance.Text.ToString());
            if (valueOfDistance > 0)
                valueOfDistance -= 1;
            distanceValue = valueOfDistance;
            labelDistance.Text = valueOfDistance.ToString();
        }
    }
}
