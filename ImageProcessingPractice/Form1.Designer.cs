namespace ImageProcessingPractice
{
    partial class Form1
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
            this.allFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.blkLabel = new System.Windows.Forms.Label();
            this.grayLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.scrollableImagePanel5 = new CustomTools.ScrollableImagePanel();
            this.scrollableImagePanel4 = new CustomTools.ScrollableImagePanel();
            this.scrollableImagePanel3 = new CustomTools.ScrollableImagePanel();
            this.scrollableImagePanel2 = new CustomTools.ScrollableImagePanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.blurCheckBox = new System.Windows.Forms.CheckBox();
            this.sharpenCheckBox = new System.Windows.Forms.CheckBox();
            this.resfreshBtn = new System.Windows.Forms.Button();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.specificColorFilterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFirstScanVerticalOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDverticalScanlineSpace)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1809, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(1809, 24);
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
            this.blackAndWhiteToolStripMenuItem,
            this.allFiltersToolStripMenuItem,
            this.specificColorFilterationToolStripMenuItem});
            this.identifyShapesToolStripMenuItem.Name = "identifyShapesToolStripMenuItem";
            this.identifyShapesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.identifyShapesToolStripMenuItem.Text = "Identify Shapes";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // colorFilterationToolStripMenuItem
            // 
            this.colorFilterationToolStripMenuItem.Name = "colorFilterationToolStripMenuItem";
            this.colorFilterationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colorFilterationToolStripMenuItem.Text = "Color Filteration";
            this.colorFilterationToolStripMenuItem.Click += new System.EventHandler(this.colorFilterationToolStripMenuItem_Click);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Black and White";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // allFiltersToolStripMenuItem
            // 
            this.allFiltersToolStripMenuItem.Name = "allFiltersToolStripMenuItem";
            this.allFiltersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.allFiltersToolStripMenuItem.Text = "All Filters";
            this.allFiltersToolStripMenuItem.Click += new System.EventHandler(this.allFiltersToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.scrollableImagePanel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1478, 271);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // scrollableImagePanel1
            // 
            this.scrollableImagePanel1.AutoSize = true;
            this.scrollableImagePanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scrollableImagePanel1.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel1.Image = null;
            this.scrollableImagePanel1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel1.Location = new System.Drawing.Point(1216, 3);
            this.scrollableImagePanel1.Name = "scrollableImagePanel1";
            this.scrollableImagePanel1.ROTATION = 0F;
            this.scrollableImagePanel1.Size = new System.Drawing.Size(259, 265);
            this.scrollableImagePanel1.TabIndex = 22;
            this.scrollableImagePanel1.Zoom = 1F;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(882, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 265);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(492, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(483, 265);
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
            this.label2.Location = new System.Drawing.Point(650, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gray Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1004, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1354, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Canny";
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
            this.hScrollBar2.Location = new System.Drawing.Point(1523, 282);
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
            this.label5.Location = new System.Drawing.Point(1522, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Black Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1520, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Blob Size";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1523, 238);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Minimum = 20;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(253, 23);
            this.hScrollBar1.TabIndex = 16;
            this.hScrollBar1.Value = 20;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // cannyLowerThresholdSlider
            // 
            this.cannyLowerThresholdSlider.Location = new System.Drawing.Point(1523, 326);
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
            this.label7.Location = new System.Drawing.Point(1520, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Canny Lower Threshold";
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
            this.cannyUpperThresholdSlider.Location = new System.Drawing.Point(1523, 362);
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
            this.label8.Location = new System.Drawing.Point(1520, 349);
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
            this.labelBlobSize.Location = new System.Drawing.Point(1779, 282);
            this.labelBlobSize.Name = "labelBlobSize";
            this.labelBlobSize.Size = new System.Drawing.Size(20, 24);
            this.labelBlobSize.TabIndex = 26;
            this.labelBlobSize.Text = "0";
            // 
            // cannyLowerValue
            // 
            this.cannyLowerValue.AutoSize = true;
            this.cannyLowerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cannyLowerValue.Location = new System.Drawing.Point(1779, 326);
            this.cannyLowerValue.Name = "cannyLowerValue";
            this.cannyLowerValue.Size = new System.Drawing.Size(20, 24);
            this.cannyLowerValue.TabIndex = 27;
            this.cannyLowerValue.Text = "0";
            // 
            // CannyUpperValue
            // 
            this.CannyUpperValue.AutoSize = true;
            this.CannyUpperValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CannyUpperValue.Location = new System.Drawing.Point(1779, 362);
            this.CannyUpperValue.Name = "CannyUpperValue";
            this.CannyUpperValue.Size = new System.Drawing.Size(20, 24);
            this.CannyUpperValue.TabIndex = 28;
            this.CannyUpperValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1520, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Gray Scale Slider";
            // 
            // graySlider
            // 
            this.graySlider.Location = new System.Drawing.Point(1525, 398);
            this.graySlider.Maximum = 200;
            this.graySlider.Minimum = 1;
            this.graySlider.Name = "graySlider";
            this.graySlider.Size = new System.Drawing.Size(253, 23);
            this.graySlider.TabIndex = 30;
            this.graySlider.Value = 100;
            this.graySlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.graySlider_Scroll);
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(1523, 434);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(253, 23);
            this.redSlider.TabIndex = 31;
            this.redSlider.Value = 21;
            this.redSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(1523, 470);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(253, 23);
            this.blueSlider.TabIndex = 32;
            this.blueSlider.Value = 7;
            this.blueSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(1523, 506);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(253, 23);
            this.greenSlider.TabIndex = 33;
            this.greenSlider.Value = 71;
            this.greenSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenSlider_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1520, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Green Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1520, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Blue Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1520, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Red Value";
            // 
            // blkLabel
            // 
            this.blkLabel.AutoSize = true;
            this.blkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blkLabel.Location = new System.Drawing.Point(1779, 244);
            this.blkLabel.Name = "blkLabel";
            this.blkLabel.Size = new System.Drawing.Size(20, 24);
            this.blkLabel.TabIndex = 37;
            this.blkLabel.Text = "0";
            // 
            // grayLabel
            // 
            this.grayLabel.AutoSize = true;
            this.grayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grayLabel.Location = new System.Drawing.Point(1779, 397);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(20, 24);
            this.grayLabel.TabIndex = 38;
            this.grayLabel.Text = "0";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.redLabel.Location = new System.Drawing.Point(1779, 434);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(20, 24);
            this.redLabel.TabIndex = 39;
            this.redLabel.Text = "0";
            // 
            // blueValue
            // 
            this.blueValue.AutoSize = true;
            this.blueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.blueValue.Location = new System.Drawing.Point(1779, 469);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(20, 24);
            this.blueValue.TabIndex = 40;
            this.blueValue.Text = "0";
            // 
            // greenValue
            // 
            this.greenValue.AutoSize = true;
            this.greenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.greenValue.Location = new System.Drawing.Point(1779, 505);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(20, 24);
            this.greenValue.TabIndex = 41;
            this.greenValue.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel2.Controls.Add(this.scrollableImagePanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.scrollableImagePanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.scrollableImagePanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.scrollableImagePanel2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 436);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1475, 344);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // scrollableImagePanel5
            // 
            this.scrollableImagePanel5.AutoSize = true;
            this.scrollableImagePanel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scrollableImagePanel5.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel5.Image = null;
            this.scrollableImagePanel5.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel5.Location = new System.Drawing.Point(911, 3);
            this.scrollableImagePanel5.Name = "scrollableImagePanel5";
            this.scrollableImagePanel5.ROTATION = 0F;
            this.scrollableImagePanel5.Size = new System.Drawing.Size(300, 338);
            this.scrollableImagePanel5.TabIndex = 26;
            this.scrollableImagePanel5.Zoom = 1F;
            // 
            // scrollableImagePanel4
            // 
            this.scrollableImagePanel4.AutoSize = true;
            this.scrollableImagePanel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scrollableImagePanel4.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel4.Image = null;
            this.scrollableImagePanel4.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel4.Location = new System.Drawing.Point(1217, 3);
            this.scrollableImagePanel4.Name = "scrollableImagePanel4";
            this.scrollableImagePanel4.ROTATION = 0F;
            this.scrollableImagePanel4.Size = new System.Drawing.Size(255, 338);
            this.scrollableImagePanel4.TabIndex = 25;
            this.scrollableImagePanel4.Zoom = 1F;
            // 
            // scrollableImagePanel3
            // 
            this.scrollableImagePanel3.AutoSize = true;
            this.scrollableImagePanel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scrollableImagePanel3.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel3.Image = null;
            this.scrollableImagePanel3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel3.Location = new System.Drawing.Point(3, 3);
            this.scrollableImagePanel3.Name = "scrollableImagePanel3";
            this.scrollableImagePanel3.ROTATION = 0F;
            this.scrollableImagePanel3.Size = new System.Drawing.Size(449, 338);
            this.scrollableImagePanel3.TabIndex = 24;
            this.scrollableImagePanel3.Zoom = 1F;
            // 
            // scrollableImagePanel2
            // 
            this.scrollableImagePanel2.AutoSize = true;
            this.scrollableImagePanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.scrollableImagePanel2.CanvasSize = new System.Drawing.Size(60, 40);
            this.scrollableImagePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableImagePanel2.Image = null;
            this.scrollableImagePanel2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.scrollableImagePanel2.Location = new System.Drawing.Point(458, 3);
            this.scrollableImagePanel2.Name = "scrollableImagePanel2";
            this.scrollableImagePanel2.ROTATION = 0F;
            this.scrollableImagePanel2.Size = new System.Drawing.Size(447, 338);
            this.scrollableImagePanel2.TabIndex = 23;
            this.scrollableImagePanel2.Zoom = 1F;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(161, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 24);
            this.label15.TabIndex = 43;
            this.label15.Text = "Gray Scale";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(504, 398);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 24);
            this.label16.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(650, 398);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = "Black and White";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1004, 398);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 24);
            this.label18.TabIndex = 46;
            this.label18.Text = "Mixed Color Edit";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1308, 398);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 24);
            this.label19.TabIndex = 47;
            this.label19.Text = "Specific Color Edit";
            // 
            // blurCheckBox
            // 
            this.blurCheckBox.AutoSize = true;
            this.blurCheckBox.Location = new System.Drawing.Point(1698, 203);
            this.blurCheckBox.Name = "blurCheckBox";
            this.blurCheckBox.Size = new System.Drawing.Size(86, 17);
            this.blurCheckBox.TabIndex = 48;
            this.blurCheckBox.Text = "Gausian Blur";
            this.blurCheckBox.UseVisualStyleBackColor = true;
            this.blurCheckBox.CheckedChanged += new System.EventHandler(this.blurCheckBox_CheckedChanged);
            // 
            // sharpenCheckBox
            // 
            this.sharpenCheckBox.AutoSize = true;
            this.sharpenCheckBox.Location = new System.Drawing.Point(1553, 203);
            this.sharpenCheckBox.Name = "sharpenCheckBox";
            this.sharpenCheckBox.Size = new System.Drawing.Size(108, 17);
            this.sharpenCheckBox.TabIndex = 50;
            this.sharpenCheckBox.Text = "Gausian Sharpen";
            this.sharpenCheckBox.UseVisualStyleBackColor = true;
            this.sharpenCheckBox.CheckedChanged += new System.EventHandler(this.sharpenCheckBox_CheckedChanged);
            // 
            // resfreshBtn
            // 
            this.resfreshBtn.Location = new System.Drawing.Point(1602, 561);
            this.resfreshBtn.Name = "resfreshBtn";
            this.resfreshBtn.Size = new System.Drawing.Size(114, 27);
            this.resfreshBtn.TabIndex = 51;
            this.resfreshBtn.Text = "Refresh";
            this.resfreshBtn.UseVisualStyleBackColor = true;
            this.resfreshBtn.Click += new System.EventHandler(this.resfreshBtn_Click);
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Checked = true;
            this.redCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckBox.Location = new System.Drawing.Point(1525, 538);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(46, 17);
            this.redCheckBox.TabIndex = 52;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            this.redCheckBox.CheckedChanged += new System.EventHandler(this.redCheckBox_CheckedChanged);
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Checked = true;
            this.blueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckBox.Location = new System.Drawing.Point(1636, 538);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(47, 17);
            this.blueCheckBox.TabIndex = 53;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            this.blueCheckBox.CheckedChanged += new System.EventHandler(this.blueCheckBox_CheckedChanged);
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Checked = true;
            this.greenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckBox.Location = new System.Drawing.Point(1742, 538);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(55, 17);
            this.greenCheckBox.TabIndex = 54;
            this.greenCheckBox.Text = "Green";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            this.greenCheckBox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // specificColorFilterationToolStripMenuItem
            // 
            this.specificColorFilterationToolStripMenuItem.Name = "specificColorFilterationToolStripMenuItem";
            this.specificColorFilterationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.specificColorFilterationToolStripMenuItem.Text = "Specific Color Filteration";
            this.specificColorFilterationToolStripMenuItem.Click += new System.EventHandler(this.specificColorFilterationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 809);
            this.Controls.Add(this.greenCheckBox);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.redCheckBox);
            this.Controls.Add(this.resfreshBtn);
            this.Controls.Add(this.sharpenCheckBox);
            this.Controls.Add(this.blurCheckBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.grayLabel);
            this.Controls.Add(this.blkLabel);
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
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Label blkLabel;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.Label greenValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomTools.ScrollableImagePanel scrollableImagePanel5;
        private CustomTools.ScrollableImagePanel scrollableImagePanel4;
        private CustomTools.ScrollableImagePanel scrollableImagePanel3;
        private CustomTools.ScrollableImagePanel scrollableImagePanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem allFiltersToolStripMenuItem;
        private System.Windows.Forms.CheckBox blurCheckBox;
        private System.Windows.Forms.CheckBox sharpenCheckBox;
        private System.Windows.Forms.Button resfreshBtn;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.ToolStripMenuItem specificColorFilterationToolStripMenuItem;
    }
}

