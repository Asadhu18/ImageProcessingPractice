using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using AForge.Math.Geometry;



namespace ImageProcessingPractice
{
    public partial class Form1 : Form
    {
        public VideoCaptureDevice captureDevice;
        FilterInfoCollection deviceList;
        public double cr = 0.2125;
        public double cg = .7154;
        public double cb = .0721;
        private System.Timers.Timer frameTimer = new System.Timers.Timer(2000);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            deviceList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (deviceList.Count == 0)
            {
                throw new Exception();
            }
            comboBox1.Items.Clear();

            foreach (FilterInfo device in deviceList)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();

        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(deviceList[comboBox1.SelectedIndex].MonikerString);
            //captureDevice.NewFrame += new NewFrameEventHandler(picture_NewFrame);
            videoSourcePlayer1.VideoSource = captureDevice;
            videoSourcePlayer1.Start();
        }

        void picture_NewFrame(object sender, NewFrameEventArgs e)
        {
            //pictureBox1.Image = (Bitmap)e.Frame.Clone();

        }
        public void graify()
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();

            }


            //pictureBox1.Image = (Bitmap).getCurrentVideoFrame();
            Bitmap colorImg = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            pictureBox4.Image = (System.Drawing.Image)colorImg.Clone();

            Grayscale filter = new Grayscale(cr, cg, cb);
            pictureBox2.Image = (Bitmap)filter.Apply(colorImg);
            pictureBox2.Invalidate();
        }
        private void shutter_Click(object sender, EventArgs e)
        {
            graify();

        }


        public void extractHistogramData(System.Drawing.Image inImage, System.Drawing.Image inImage2)
        {

            int minValVindex = 0;
            int minValHindex = 0;
            float maxValH = 0;
            float maxValV = 0;
            float minValH = 10000000;
            float minValV = 100000000;
            int height = inImage.Height;
            int width = inImage.Width;
            Graphics g = Graphics.FromImage(inImage2);
            Pen redPen = new Pen(Color.FromArgb(60, 255, 0, 0), .5F);
            Pen fuschiaPen = new Pen(Brushes.Fuchsia, 5.0F);
            Pen bluePen = new Pen(Color.FromArgb(60, 0, 0, 255), .5F);


            int verticalLineStart = (int)NUDFirstScanVerticalOffset.Value;
            int verticalSumSpace = (int)NUDverticalScanlineSpace.Value;
            //int horizontalLineStart = (int)NUDFirstScanHorizontallOffset.Value;
            //int horizontalSumSpace = (int)NUDhorizontalScanlineSpace.Value;

            float[] sumArrayHorizontal = new float[width + 1];
            float[] sumArrayVertical = new float[height + 1];


            Bitmap imageClone = (Bitmap)inImage;
            Rectangle imageRectangle = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData imageData = imageClone.LockBits(imageRectangle, System.Drawing.Imaging.ImageLockMode.ReadWrite, imageClone.PixelFormat);
            IntPtr imagePointer = imageData.Scan0;
            int stride = imageData.Stride;
            byte[] imageByteArray = new byte[stride * imageData.Height];
            System.Runtime.InteropServices.Marshal.Copy(imageData.Scan0, imageByteArray, 0, imageByteArray.Length);
            imageClone.UnlockBits(imageData);



            //Prep Pointers for Row Data
            int pointer1 = verticalLineStart * stride;
            int pointer2 = pointer1 + (stride * verticalSumSpace);
            int pointer3 = pointer2 + (stride * verticalSumSpace);
            int pointer4 = pointer3 + (stride * verticalSumSpace);
            int pointer5 = pointer4 + (stride * verticalSumSpace);
            int pointer6 = pointer5 + (stride * verticalSumSpace);
            int pointer7 = pointer6 + (stride * verticalSumSpace);
            int pointer8 = pointer7 + (stride * verticalSumSpace);
            int pointer9 = pointer8 + (stride * verticalSumSpace);
            int pointer10 = pointer9 + (stride * verticalSumSpace);

            for (int xOffset = 0; xOffset < width; xOffset++)
            {//Summing Horizontal Pixel Data
                sumArrayHorizontal[xOffset] += imageByteArray[pointer1 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer2 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer3 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer4 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer5 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer6 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer7 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer8 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer9 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[pointer10 + xOffset];
            }
            //horiztonal sum array
            //Sums row data
            //Repeat for each collumn
            for (int rowOffset = 0; rowOffset < height; rowOffset++)
            {
                for (int yOffset = 0; yOffset < width; yOffset++)
                {//Summing Vertical Pixel Data
                    sumArrayVertical[rowOffset] += imageByteArray[yOffset + (width * (rowOffset))];
                }
            }

            for (int count = 0; count < width; count++)
            {//Finding Max Horizontal Value
                if (sumArrayHorizontal[count] > maxValH)
                {
                    maxValH = sumArrayHorizontal[count];
                }
            }
            for (int count = 0; count < width; count++)
            {//Finding min Horizontal Value
                if (sumArrayHorizontal[count] < minValH)
                {
                    minValH = sumArrayHorizontal[count];
                    minValHindex = count;
                }
            }

            for (int count = 0; count < height; count++)
            {//Finding Max vertical Value

                if (sumArrayVertical[count] > maxValV)
                {
                    maxValV = sumArrayVertical[count];
                }
            }

            for (int count = 0; count < height; count++)
            {//Finding min vertical Value
                if (sumArrayVertical[count] < minValV)
                {
                    minValV = sumArrayVertical[count];
                    minValVindex = count;

                }
            }

            float divisorH = (float)(maxValH / inImage.Height);
            float divisorV = (float)(maxValV / inImage.Width);
            float[] histogramHorizontalData = new float[width + 1];
            float[] histogramVerticalData = new float[height + 1];

            for (int y = 0; y < width; y++)
            {//Scaling Data to fit vertical window, 100 pixels tall
                histogramHorizontalData[y] = (float)sumArrayHorizontal[y] / divisorH;
            }

            for (int b = 0; b < height; b++)
            {
                histogramVerticalData[b] = sumArrayVertical[b] / divisorV;
                //Console.WriteLine(sumArrayVertical[b] + "|||");
            }

            for (int z = 0; z < width; z++)
            {

                g.DrawLine(redPen, z, height, z, histogramHorizontalData[z]);
            }

            for (int a = 0; a < height; a++)
            {

                g.DrawLine(bluePen, width, a, histogramVerticalData[a], a);
            }


            Console.WriteLine("Stride: " + stride);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Max Value H: " + minValHindex);
            g.DrawLine(fuschiaPen, minValHindex, 0, minValHindex, height);
            g.DrawLine(fuschiaPen, 0, minValVindex, width, minValVindex);
            //g.DrawLine(fuschiaPen, 0,(int) (pointer1/stride), width,(int) (pointer1/stride));
            //g.DrawLine(fuschiaPen, 0, (int)(pointer10 / stride), width, (int)(pointer10 / stride));
            pictureBox3.Image = (System.Drawing.Image)inImage2.Clone();
            g.Dispose();
        }

        private void histogramBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

            /*if (pictureBox2.Image != null)
            {
                extractHistogramData(pictureBox2.Image,pictureBox4.Image);
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graify();
            if (pictureBox2.Image != null)
            {
                //pictureBox3.Image = videoSourcePlayer1.GetCurrentVideoFrame();
                extractHistogramData(pictureBox2.Image, pictureBox4.Image);

            }
            /*pictureBox2.Image.Dispose();
            pictureBox3.Image.Dispose();
            pictureBox4.Image.Dispose();*/
        }

        private void circleDetection_Click(object sender, EventArgs e)
        {

            //pictureBox4.SizeMode() = PictureBoxSizeMode.Zoom;
            //pictureBox4.Image = videoSourcePlayer1.GetCurrentVideoFrame();
            if(pictureBox2.Image!=null)
            pictureBox4.Image = (Bitmap)pictureBox2.Image.Clone();
            Bitmap originalImage = (Bitmap)pictureBox4.Image;
            BlobCounter blobCounter = new BlobCounter();
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            blobCounter.ProcessImage(originalImage);
            Blob[] blobObjectArray = blobCounter.GetObjectsInformation();
            float thresholdValue = hScrollBar1.Value;
            Threshold filter = new Threshold((int)thresholdValue);
            filter.ApplyInPlace((Bitmap)pictureBox4.Image);
            
           /* Graphics g = Graphics.FromImage(originalImage);
            Pen yellowPen = new Pen(Color.Yellow, 5.0f);
            int length = blobObjectArray.Length;
          
            

            for (int i = 0; i < length; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobObjectArray[i]);

                AForge.Point center = new AForge.Point();
                float radius;
                if (shapeChecker.IsCircle(edgePoints,out center,out radius))
                {
                    g.DrawEllipse(yellowPen,(int) center.X-radius, (int)center.Y-radius, (int)radius *2, (int)radius *2);
                }
            }
            

            yellowPen.Dispose();
            g.Dispose();*/
            
        }
        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];
            return array;
        }
        private void polygonFinder_Click(object sender, EventArgs e)
        {
            /*pictureBox4.Image = Clipboard.GetImage();
            Bitmap temporaryBitmap = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(temporaryBitmap);
            Blob[] blobObjectArray = blobCounter.GetObjectsInformation();
            Graphics g = Graphics.FromImage(temporaryBitmap);
            Pen fuschsiaPen = new Pen(Color.Fuchsia, 5.0f);
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int length = blobObjectArray.Length;
            // create filter
            BlobsFiltering blobFilter = new BlobsFiltering();
            // configure filter
            blobFilter.CoupledSizeFiltering = true;
            blobFilter.MinWidth = 20;
            blobFilter.MinHeight = 20;
            blobFilter.MaxHeight = hScrollBar2.Value;
            blobFilter.MaxWidth = hScrollBar2.Value;
            // apply the filter
            blobFilter.ApplyInPlace(temporaryBitmap);
            for (int i = 0; i < length; i++) {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobObjectArray[i]);
                List<IntPoint> corners;

               if (shapeChecker.IsQuadrilateral(edgePoints, out corners ))
                {
                    g.DrawPolygon(fuschsiaPen, ToPointsArray(corners));
                }
            }
            pictureBox4.Image= temporaryBitmap;*/

            Bitmap originalBitmap = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            EuclideanColorFiltering colorFilter = new EuclideanColorFiltering();
            colorFilter.CenterColor = new RGB((byte)hScrollBar1.Value, (byte)hScrollBar1.Value, (byte)hScrollBar1.Value);
            colorFilter.Radius = (short)hScrollBar2.Value;
            pictureBox4.Image = colorFilter.Apply(originalBitmap);
            BlobCounter _blobCounter = new BlobCounter();
            //Configure Filter
            _blobCounter.MinWidth = 20;
            _blobCounter.MinHeight = 20;
            _blobCounter.FilterBlobs = true;

            _blobCounter.ProcessImage(originalBitmap);
            Blob[] _blobPoints = _blobCounter.GetObjectsInformation();

            Graphics _g = Graphics.FromImage(originalBitmap);

            SimpleShapeChecker _shapeChecker = new SimpleShapeChecker();
            for (int i = 0; i < _blobPoints.Length; i++)
            {
                List<IntPoint> _edgePoint = _blobCounter.GetBlobsEdgePoints(_blobPoints[i]);
                List<IntPoint> _corners = null;
                AForge.Point _center;
                float _radius;

                if (_shapeChecker.IsQuadrilateral(_edgePoint, out _corners))
                {
                    Rectangle[] _rects = _blobCounter.GetObjectsRectangles();

                    System.Drawing.Point[] _coordinates = ToPointsArray(_corners);
                    int _x = _coordinates[0].X;
                    int _y = _coordinates[0].Y;
                    Pen _pen = new Pen(Color.Blue, 5.0f);

                    if (_coordinates.Length == 4)
                    {
                        string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                        _g.DrawString(_shapeString, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Fuchsia, _x, _y);
                        _g.DrawPolygon(_pen, ToPointsArray(_corners));
                    }
                    //size of rectange
                    foreach (Rectangle rc in _rects)
                    {
                        ///for debug
                        //System.Diagnostics.Debug.WriteLine(
                        //    string.Format("Rect size: ({0}, {1})", rc.Width, rc.Height));

                        /*iFeatureWidth = rc.Width;
                        double dis = FindDistance(iFeatureWidth);
                        _g.DrawString(dis.ToString("N2"), new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Black, _x, _y + 60);*/
                    }
                }
                if (_shapeChecker.IsCircle(_edgePoint, out _center, out _radius))
                {
                    Rectangle[] _rects = _blobCounter.GetObjectsRectangles();

                    string _shapeString = "" + _shapeChecker.CheckShapeType(_edgePoint);
                    Pen _pen = new Pen(Color.Red, 5.0f);
                    int _x = (int)_center.X;
                    int _y = (int)_center.Y;
                    _g.DrawString(_shapeString, new Font("Times New Roman", 48, FontStyle.Bold), Brushes.Fuchsia, _x, _y);
                    _g.DrawEllipse(_pen, (float)(_center.X - _radius),
                                         (float)(_center.Y - _radius),
                                         (float)(_radius * 2),
                                         (float)(_radius * 2));

                    //size of rectange
                    foreach (Rectangle rc in _rects)
                    {
                        ///for debug
                        //System.Diagnostics.Debug.WriteLine(
                        //    string.Format("Circle size: ({0}, {1})", rc.Width, rc.Height));

                        /*iFeatureWidth = rc.Width;
                        double dis = FindDistance(iFeatureWidth);
                        //textBox1.Text = dis.ToString("N2");
                        _g.DrawString(dis.ToString("N2"), _font, _brush, _x, _y + 60);*/
                    }
                }
            }
        }

            

        private void label1_Click(object sender, EventArgs e)
        {
            


        }
    }
}

