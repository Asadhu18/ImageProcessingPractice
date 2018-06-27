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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1267, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1221, 448);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(962, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 442);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(655, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 442);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(329, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 442);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(320, 442);
            this.videoSourcePlayer1.TabIndex = 15;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gray Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1086, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
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
            this.comboBox1.Location = new System.Drawing.Point(28, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
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
            this.hScrollBar2.Location = new System.Drawing.Point(388, 118);
            this.hScrollBar2.Minimum = 5;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(253, 23);
            this.hScrollBar2.TabIndex = 17;
            this.hScrollBar2.Value = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Black Threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Blob Size";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(31, 118);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(253, 23);
            this.hScrollBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 636);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
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
    }
}

