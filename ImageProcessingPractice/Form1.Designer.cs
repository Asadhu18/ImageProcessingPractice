namespace ImageProcessingPractice
{
    partial class greySliderBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFilterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scrollableImagePanel1 = new CustomTools.ScrollableImagePanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recordBtn = new System.Windows.Forms.Button();
            this.shutter = new System.Windows.Forms.Button();
            this.histogramBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NUDFirstScanVerticalOffset = new System.Windows.Forms.NumericUpDown();
            this.NUDverticalScanlineSpace = new System.Windows.Forms.NumericUpDown();
            this.circleDetection = new System.Windows.Forms.Button();
            this.polygonFinder = new System.Windows.Forms.Button();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.cannyLowerThresholdSlider = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleButton1 = new HyrelPrinterControls.ToggleButton();
            this.cannyUpperThresholdSlider = new System.Windows.Forms.HScrollBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelBlobSize = new System.Windows.Forms.Label();
            this.cannyLowerValue = new System.Windows.Forms.Label();
            this.CannyUpperValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.graySlider = new System.Windows.Forms.HScrollBar();
            this.redSlider = new System.Windows.Forms.HScrollBar();
            this.blueSlider = new System.Windows.Forms.HScrollBar();
            this.greenSlider = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grayLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFirstScanVerticalOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDverticalScanlineSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1572, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyShapesToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // identifyShapesToolStripMenuItem
            // 
            this.identifyShapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.colorFilterationToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem});
            this.identifyShapesToolStripMenuItem.Name = "identifyShapesToolStripMenuItem";
            this.identifyShapesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.identifyShapesToolStripMenuItem.Text = "Identify Shapes";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            // 
            // colorFilterationToolStripMenuItem
            // 
            this.colorFilterationToolStripMenuItem.Name = "colorFilterationToolStripMenuItem";
            this.colorFilterationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colorFilterationToolStripMenuItem.Text = "Color Filteration";
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Black and White";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.Controls.Add(this.scrollableImagePanel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 500);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // scrollableImagePanel1
            // 
            this.scrollableImagePanel1.AutoSize = true;
            this.scrollableImagePanel1.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel1.Image = null;
            this.scrollableImagePanel1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel1.Location = new System.Drawing.Point(994, 3);
            this.scrollableImagePanel1.Name = "scrollableImagePanel1";
            this.scrollableImagePanel1.ROTATION = 0F;
            this.scrollableImagePanel1.Size = new System.Drawing.Size(257, 494);
            this.scrollableImagePanel1.TabIndex = 22;
            this.scrollableImagePanel1.Zoom = 1F;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(687, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 494);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(345, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 494);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(336, 494);
            this.videoSourcePlayer1.TabIndex = 15;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(130, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gray Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1089, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blob Detection";
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(28, 31);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(114, 27);
            this.recordBtn.TabIndex = 7;
            this.recordBtn.Text = "Begin Recording";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // shutter
            // 
            this.shutter.Location = new System.Drawing.Point(148, 31);
            this.shutter.Name = "shutter";
            this.shutter.Size = new System.Drawing.Size(114, 27);
            this.shutter.TabIndex = 8;
            this.shutter.Text = "Grayify";
            this.shutter.UseVisualStyleBackColor = true;
            this.shutter.Click += new System.EventHandler(this.shutter_Click);
            // 
            // histogramBtn
            // 
            this.histogramBtn.Location = new System.Drawing.Point(268, 31);
            this.histogramBtn.Name = "histogramBtn";
            this.histogramBtn.Size = new System.Drawing.Size(114, 27);
            this.histogramBtn.TabIndex = 10;
            this.histogramBtn.Text = "Generate Histogram";
            this.histogramBtn.UseVisualStyleBackColor = true;
            this.histogramBtn.Click += new System.EventHandler(this.histogramBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NUDFirstScanVerticalOffset
            // 
            this.NUDFirstScanVerticalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDFirstScanVerticalOffset.Location = new System.Drawing.Point(793, 24);
            this.NUDFirstScanVerticalOffset.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.NUDFirstScanVerticalOffset.Name = "NUDFirstScanVerticalOffset";
            this.NUDFirstScanVerticalOffset.Size = new System.Drawing.Size(95, 49);
            this.NUDFirstScanVerticalOffset.TabIndex = 12;
            this.NUDFirstScanVerticalOffset.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NUDverticalScanlineSpace
            // 
            this.NUDverticalScanlineSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDverticalScanlineSpace.Location = new System.Drawing.Point(908, 24);
            this.NUDverticalScanlineSpace.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDverticalScanlineSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDverticalScanlineSpace.Name = "NUDverticalScanlineSpace";
            this.NUDverticalScanlineSpace.Size = new System.Drawing.Size(90, 49);
            this.NUDverticalScanlineSpace.TabIndex = 13;
            this.NUDverticalScanlineSpace.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // circleDetection
            // 
            this.circleDetection.Location = new System.Drawing.Point(388, 31);
            this.circleDetection.Name = "circleDetection";
            this.circleDetection.Size = new System.Drawing.Size(114, 27);
            this.circleDetection.TabIndex = 14;
            this.circleDetection.Text = "Identify Circles";
            this.circleDetection.UseVisualStyleBackColor = true;
            this.circleDetection.Click += new System.EventHandler(this.circleDetection_Click);
            // 
            // polygonFinder
            // 
            this.polygonFinder.Location = new System.Drawing.Point(508, 31);
            this.polygonFinder.Name = "polygonFinder";
            this.polygonFinder.Size = new System.Drawing.Size(114, 27);
            this.polygonFinder.TabIndex = 15;
            this.polygonFinder.Text = "Identify Shapes";
            this.polygonFinder.UseVisualStyleBackColor = true;
            this.polygonFinder.Click += new System.EventHandler(this.polygonFinder_Click);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(1291, 80);
            this.hScrollBar2.Minimum = 5;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(253, 23);
            this.hScrollBar2.TabIndex = 17;
            this.hScrollBar2.Value = 5;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1290, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Black Value";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1288, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Blob Size";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1291, 36);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(253, 23);
            this.hScrollBar1.TabIndex = 16;
            // 
            // cannyLowerThresholdSlider
            // 
            this.cannyLowerThresholdSlider.Location = new System.Drawing.Point(1291, 124);
            this.cannyLowerThresholdSlider.Maximum = 80;
            this.cannyLowerThresholdSlider.Minimum = 20;
            this.cannyLowerThresholdSlider.Name = "cannyLowerThresholdSlider";
            this.cannyLowerThresholdSlider.Size = new System.Drawing.Size(253, 23);
            this.cannyLowerThresholdSlider.TabIndex = 20;
            this.cannyLowerThresholdSlider.Value = 20;
            this.cannyLowerThresholdSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyLowerThresholdSlider_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1288, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Canny Lower Threshold";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // toggleButton1
            // 
            this.toggleButton1.BackColor = System.Drawing.Color.Lime;
            this.toggleButton1.CheckedColor = System.Drawing.Color.Red;
            this.toggleButton1.CheckedText = "Stop";
            this.toggleButton1.CheckedTextColor = System.Drawing.Color.Black;
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            this.toggleButton1.Location = new System.Drawing.Point(0, 0);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OFFIMAGE = null;
            this.toggleButton1.ONIMAGE = null;
            this.toggleButton1.Size = new System.Drawing.Size(75, 23);
            this.toggleButton1.STATE = false;
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.UncheckedColor = System.Drawing.Color.Lime;
            this.toggleButton1.UncheckedText = "START";
            this.toggleButton1.UncheckedTextColor = System.Drawing.Color.Black;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // cannyUpperThresholdSlider
            // 
            this.cannyUpperThresholdSlider.Location = new System.Drawing.Point(1291, 160);
            this.cannyUpperThresholdSlider.Maximum = 200;
            this.cannyUpperThresholdSlider.Minimum = 81;
            this.cannyUpperThresholdSlider.Name = "cannyUpperThresholdSlider";
            this.cannyUpperThresholdSlider.Size = new System.Drawing.Size(253, 23);
            this.cannyUpperThresholdSlider.TabIndex = 22;
            this.cannyUpperThresholdSlider.Value = 81;
            this.cannyUpperThresholdSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyUpperThresholdSlider_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1288, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Canny Upper Threashold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 24;
            // 
            // labelBlobSize
            // 
            this.labelBlobSize.AutoSize = true;
            this.labelBlobSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelBlobSize.Location = new System.Drawing.Point(1547, 80);
            this.labelBlobSize.Name = "labelBlobSize";
            this.labelBlobSize.Size = new System.Drawing.Size(20, 24);
            this.labelBlobSize.TabIndex = 26;
            this.labelBlobSize.Text = "0";
            // 
            // cannyLowerValue
            // 
            this.cannyLowerValue.AutoSize = true;
            this.cannyLowerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cannyLowerValue.Location = new System.Drawing.Point(1547, 124);
            this.cannyLowerValue.Name = "cannyLowerValue";
            this.cannyLowerValue.Size = new System.Drawing.Size(20, 24);
            this.cannyLowerValue.TabIndex = 27;
            this.cannyLowerValue.Text = "0";
            // 
            // CannyUpperValue
            // 
            this.CannyUpperValue.AutoSize = true;
            this.CannyUpperValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CannyUpperValue.Location = new System.Drawing.Point(1547, 160);
            this.CannyUpperValue.Name = "CannyUpperValue";
            this.CannyUpperValue.Size = new System.Drawing.Size(20, 24);
            this.CannyUpperValue.TabIndex = 28;
            this.CannyUpperValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1288, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Gray Scale Slider";
            // 
            // graySlider
            // 
            this.graySlider.Location = new System.Drawing.Point(1293, 196);
            this.graySlider.Maximum = 255;
            this.graySlider.Name = "graySlider";
            this.graySlider.Size = new System.Drawing.Size(253, 23);
            this.graySlider.TabIndex = 30;
            this.graySlider.Value = 81;
            this.graySlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.graySlider_Scroll);
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(1291, 232);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(253, 23);
            this.redSlider.TabIndex = 31;
            this.redSlider.Value = 81;
            this.redSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(1291, 268);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(253, 23);
            this.blueSlider.TabIndex = 32;
            this.blueSlider.Value = 81;
            this.blueSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(1291, 304);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(253, 23);
            this.greenSlider.TabIndex = 33;
            this.greenSlider.Value = 81;
            this.greenSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenSlider_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1288, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Green Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1288, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Blue Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1288, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Red Value";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(1547, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "0";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // grayLabel
            // 
            this.grayLabel.AutoSize = true;
            this.grayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grayLabel.Location = new System.Drawing.Point(1547, 195);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(20, 24);
            this.grayLabel.TabIndex = 38;
            this.grayLabel.Text = "0";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.redLabel.Location = new System.Drawing.Point(1547, 232);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(20, 24);
            this.redLabel.TabIndex = 39;
            this.redLabel.Text = "0";
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blueValue.Location = new System.Drawing.Point(1547, 267);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(20, 24);
            this.blueValue.TabIndex = 40;
            this.blueValue.Text = "0";
            // 
            // greenValue
            // 
            this.greenValue.AutoSize = true;
            this.greenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.greenValue.Location = new System.Drawing.Point(1547, 303);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(20, 24);
            this.greenValue.TabIndex = 41;
            this.greenValue.Text = "0";
            // 
            // greySliderBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 636);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.grayLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.greenSlider);
            this.Controls.Add(this.blueSlider);
            this.Controls.Add(this.redSlider);
            this.Controls.Add(this.graySlider);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CannyUpperValue);
            this.Controls.Add(this.cannyLowerValue);
            this.Controls.Add(this.labelBlobSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cannyUpperThresholdSlider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cannyLowerThresholdSlider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.polygonFinder);
            this.Controls.Add(this.circleDetection);
            this.Controls.Add(this.NUDverticalScanlineSpace);
            this.Controls.Add(this.NUDFirstScanVerticalOffset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.histogramBtn);
            this.Controls.Add(this.shutter);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "greySliderBar";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFirstScanVerticalOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDverticalScanlineSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button shutter;
        private System.Windows.Forms.Button histogramBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown NUDFirstScanVerticalOffset;
        private System.Windows.Forms.NumericUpDown NUDverticalScanlineSpace;
        private System.Windows.Forms.Button circleDetection;
        private System.Windows.Forms.Button polygonFinder;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar cannyLowerThresholdSlider;
        private System.Windows.Forms.Label label7;
        private CustomTools.ScrollableImagePanel scrollableImagePanel1;
        private HyrelPrinterControls.ToggleButton toggleButton1;
        private System.Windows.Forms.HScrollBar cannyUpperThresholdSlider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelBlobSize;
        private System.Windows.Forms.Label cannyLowerValue;
        private System.Windows.Forms.Label CannyUpperValue;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifyShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFilterationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.HScrollBar graySlider;
        private System.Windows.Forms.HScrollBar redSlider;
        private System.Windows.Forms.HScrollBar blueSlider;
        private System.Windows.Forms.HScrollBar greenSlider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.Label greenValue;
    }
}

