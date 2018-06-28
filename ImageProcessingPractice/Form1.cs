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
        public double workingRedmodifier = .21525;
        public double workingGreenmodifier = .7154;
        public double workingBluemodifier = .0721;

        public int caseValue = 0;
        public int gausianToggle = 0;
        public int colorToggle = 0;
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
            scrollableImagePanel1.Image = (Bitmap)colorImg.Clone();

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
                extractHistogramData(pictureBox2.Image, scrollableImagePanel1.Image);

            }
            /*pictureBox2.Image.Dispose();
            pictureBox3.Image.Dispose();
            pictureBox4.Image.Dispose();*/
        }

        private void circleDetection_Click(object sender, EventArgs e)
        {
            //Bitmap colorImg = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            //Grayscale grayfilter = new Grayscale(cr, cg, cb);
            //Bitmap originalImage = (Bitmap)grayfilter.Apply(colorImg);
            //scrollableImagePanel1.Image = originalImage;
            //CannyEdgeDetector edgeDectector = new CannyEdgeDetector();
            //edgeDectector.HighThreshold =(byte) cannyLowerThresholdSlider.Value;
            //edgeDectector.LowThreshold = (byte)hScrollBar2.Value;
            //edgeDectector.ApplyInPlace(scrollableImagePanel1.Image);



            //pictureBox4.SizeMode() = PictureBoxSizeMode.Zoom;
            //pictureBox4.Image = videoSourcePlayer1.GetCurrentVideoFrame();

            /*Bitmap colorImg = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            Grayscale grayfilter = new Grayscale(cr, cg, cb);
            Bitmap originalImage = (Bitmap)grayfilter.Apply(colorImg);
            scrollableImagePanel1.Image = originalImage;
            float thresholdValue = hScrollBar1.Value;
            Threshold filter = new Threshold((int)thresholdValue);
            filter.ApplyInPlace(scrollableImagePanel1.Image);*/

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
        public Bitmap edgeDetection() {
            Bitmap colorImg = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            Grayscale grayfilter = new Grayscale(redSlider., cg, cb);
            GaussianBlur blurFilter = new GaussianBlur();
            GaussianSharpen sharpenFilter = new GaussianSharpen();
            Bitmap originalImage;
            if (gausianToggle == 0)
            {
                originalImage = (Bitmap)grayfilter.Apply(colorImg);
            }
            else if (gausianToggle == 1)
            {
                originalImage = sharpenFilter.Apply((Bitmap)colorImg);
                originalImage = (Bitmap)grayfilter.Apply(originalImage);
            }
            else
            {
                originalImage = blurFilter.Apply((Bitmap)colorImg);
                originalImage = (Bitmap)grayfilter.Apply(originalImage);
            }
            switch (caseValue)
            {
               
                case 1:
                    //canny
                    scrollableImagePanel1.Image = originalImage;
                    CannyEdgeDetector edgeDectector = new CannyEdgeDetector();
                    edgeDectector.HighThreshold = (byte)cannyUpperThresholdSlider.Value;
                    edgeDectector.LowThreshold = (byte)cannyLowerThresholdSlider.Value;
                    edgeDectector.ApplyInPlace(scrollableImagePanel1.Image);
                    return (Bitmap)scrollableImagePanel1.Image;
                case 2:
                    //gray scale
                    scrollableImagePanel3.Image = originalImage;
                    Grayscale customGrayScale = new Grayscale((cr*(graySlider.Value/100)),(cb * (graySlider.Value / 100)), (cg * (graySlider.Value / 100)));
                    originalImage = customGrayScale.Apply(colorImg);
                    return originalImage ;
                case 3:
                    //Black and White
                    scrollableImagePanel2.Image = originalImage;
                    Threshold thresholdFilter = new Threshold();
                    thresholdFilter.ThresholdValue = hScrollBar1.Value;
                    thresholdFilter.ApplyInPlace(scrollableImagePanel2.Image);
                    return (Bitmap)scrollableImagePanel2.Image;
                case 4:
                    //Mixed Color Edits
                    scrollableImagePanel5.Image = colorImg;
                    ChannelFiltering colorChannelFilter = new ChannelFiltering();
                    colorChannelFilter.Red = new IntRange(0,redSlider.Value);
                    colorChannelFilter.Blue = new IntRange(0, blueSlider.Value);
                    colorChannelFilter.Green = new IntRange(0, greenSlider.Value);
                    colorChannelFilter.ApplyInPlace((Bitmap)scrollableImagePanel5.Image);
                    return (Bitmap)scrollableImagePanel5.Image;
                case 5:
                    //Specific Color edits
                    ColorFiltering colorFilter = new ColorFiltering();
                    if (colorToggle == 1)
                    {
                        Console.WriteLine("Red disabled");
                        colorFilter.Red = new IntRange(0, 0);
                        colorFilter.Blue = new IntRange(0, 255);
                        colorFilter.Green = new IntRange(0, 255);
                        colorFilter.Apply(colorImg);
                        originalImage = colorImg;
                        return originalImage;
                    }
                    else if (colorToggle == 2)
                    {
                        Console.WriteLine("Blue disabled");
                        colorFilter.Red = new IntRange(0, 255);
                        colorFilter.Blue = new IntRange(0, 0);
                        colorFilter.Green = new IntRange(0, 255);
                        colorFilter.Apply(colorImg);
                        originalImage = colorImg;
                        return originalImage;
                    }
                    else if (colorToggle == 3)
                    {
                        Console.WriteLine("Green disabled");
                        colorFilter.Red = new IntRange(0, 255);
                        colorFilter.Blue = new IntRange(0, 255);
                        colorFilter.Green = new IntRange(0, 0);
                        colorFilter.Apply(colorImg);
                        originalImage = colorImg;
                        return originalImage;
                    }
                    else {
                        return colorImg;
                    }
            }
            return originalImage;
           
        }
        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];
            return array;
        }
        private void polygonFinder_Click(object sender, EventArgs e)
        {
            processShapes();
        }
        public void processShapes()
        {

            //Working Variables
            Pen fuschiaPen = new Pen(Color.Fuchsia, 3.0f);
            Pen aquaPen = new Pen(Color.Aqua, 5.0f);
            Pen redPen = new Pen(Color.Red, 3.0f);
            Pen orangePen = new Pen(Color.Orange, 3.0f);


            //Locking Image Bits
            Bitmap workingFrame = edgeDetection();
            System.Drawing.Imaging.BitmapData bmpData = workingFrame.LockBits(new Rectangle(0, 0, workingFrame.Width, workingFrame.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, workingFrame.PixelFormat);


            //Turning the Background Black and getting rid of the green of the PCB
            /*ColorFiltering colorFilter = new ColorFiltering();
            Threshold filter = new Threshold((int)hScrollBar1.Value);

            colorFilter.Red = new IntRange(0, hScrollBar1.Value);
            colorFilter.Blue = new IntRange(0, hScrollBar1.Value);
            colorFilter.Green = new IntRange(0, hScrollBar1.Value);
            */
            // colorFilter.ApplyInPlace(bmpData);
            workingFrame.UnlockBits(bmpData);



            //Identifing the Blobs in target picture
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            //blobCounter.MinHeight = 5;
            //blobCounter.MinWidth = 5;
            blobCounter.MinHeight = hScrollBar2.Value;
            blobCounter.MinWidth = hScrollBar2.Value;

            blobCounter.ProcessImage(bmpData);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            //scrollableImagePanel1.Image = (Bitmap)workingFrame.Clone();
            //Classifying the objects{}
            AForge.Math.Geometry.SimpleShapeChecker shapeCheck = new SimpleShapeChecker();
            Bitmap tempBitmap = new Bitmap(workingFrame.Width, workingFrame.Height);
            Graphics g = Graphics.FromImage(tempBitmap);
            g.DrawImage(workingFrame, 0, 0);

            if (caseValue == 1)
            {
             scrollableImagePanel1.Image = tempBitmap;
            }
            if (caseValue == 2)
            {
                scrollableImagePanel3.Image = tempBitmap;
            }
            if (caseValue == 3)
            {
                scrollableImagePanel2.Image = tempBitmap;
            }
            if (caseValue == 4)
            {
                scrollableImagePanel5.Image = tempBitmap;
            }
            if (caseValue == 5)
            {
                scrollableImagePanel4.Image = tempBitmap;
            }   
            int blobLength = blobs.Length;
            for (int i = 0; i < blobLength; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                AForge.Point center;
                float radius;

                if (shapeCheck.IsCircle(edgePoints, out center, out radius))
                {
                    float tempLocationX = (float)(center.X - radius);
                    float tempLocationY = (float)(center.Y - radius);
                    float diameter = radius * 2.0f;
                    g.DrawEllipse(fuschiaPen, tempLocationX, tempLocationY, diameter, diameter);
                }
                else
                {
                    List<IntPoint> corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                    if (shapeCheck.IsQuadrilateral(edgePoints, out corners))
                    {
                        Rectangle testRectangle = new Rectangle(corners[0].X, corners[0].Y, (corners[1].X - corners[0].X), corners[3].Y - corners[0].Y);
                        g.DrawRectangle(redPen, testRectangle);

                        if (shapeCheck.CheckPolygonSubType(corners) == PolygonSubType.Rectangle)
                        {
                            g.DrawPolygon(aquaPen, ToPointsArray(corners));

                        }
                        else
                        {
                            g.DrawPolygon(orangePen, ToPointsArray(corners));
                        }
                    }

                }

                //redPen.Dispose();
                //orangePen.Dispose();

                //g.Dispose();
            }
        }


        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            labelBlobSize.Text = hScrollBar2.Value.ToString();
            processShapes();
        }


        private void cannyLowerThresholdSlider_Scroll(object sender, ScrollEventArgs e)
        {
            cannyLowerValue.Text = cannyLowerThresholdSlider.Value.ToString();
           processShapes();

        }

        private void cannyUpperThresholdSlider_Scroll(object sender, ScrollEventArgs e)
        {
            CannyUpperValue.Text = cannyUpperThresholdSlider.Value.ToString();
            processShapes();
        }

        private void graySlider_Scroll(object sender, ScrollEventArgs e)
        {
            grayLabel.Text = graySlider.Value.ToString();
            processShapes();
        }

        private void redSlider_Scroll(object sender, ScrollEventArgs e)
        {
            redLabel.Text = (redSlider.Value*.01).ToString();
            processShapes();
        }

        private void blueSlider_Scroll(object sender, ScrollEventArgs e)
        {
            blueValue.Text = (blueSlider.Value*.01).ToString();
            processShapes();
        }

        private void greenSlider_Scroll(object sender, ScrollEventArgs e)
        {
         workingGreenmodifier = (double)(greenSlider.Value*.01);
        greenValue.Text = greenSlider.Value.ToString();
            processShapes();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseValue = 1;
            processShapes();
            
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseValue = 3;
            processShapes();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            blkLabel.Text = hScrollBar1.Value.ToString();
           processShapes();
        }

        private void allFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++) {
                caseValue= i;
                processShapes();
            }
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseValue = 2;
           processShapes();
        }

        private void colorFilterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseValue = 4;
            processShapes();
        }

        private void sharpenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gausianToggle = 1;
        }

        private void blurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gausianToggle = 2;
        }

        private void resfreshBtn_Click(object sender, EventArgs e)
        {
            processShapes();
        }

        private void specificColorFilterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caseValue = 5;
            processShapes();
        }

        private void redCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            colorToggle = 1;
        }

        private void blueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            colorToggle = 2;
        }

        private void greenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            colorToggle = 3;
        }
    }
}
        

            

        
   


