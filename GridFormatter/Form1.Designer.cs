namespace GridFormatter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rbDrawBlackPoints = new System.Windows.Forms.RadioButton();
            this.rbDrawWhitePoints = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThredhold = new System.Windows.Forms.TrackBar();
            this.tbGridSize = new System.Windows.Forms.TrackBar();
            this.lThredhold = new System.Windows.Forms.Label();
            this.lGridSize = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lImgPath = new System.Windows.Forms.Label();
            this.lImgSize = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDetectWhitePoints = new System.Windows.Forms.RadioButton();
            this.rbDetectBlackPoints = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbThredhold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(141, 35);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "BMP Files|*.bmp";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Open BMP files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "R/G/B Thredhold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grid Size:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "BMP Files|*.bmp";
            this.saveFileDialog1.Title = "Save BMP files";
            // 
            // rbDrawBlackPoints
            // 
            this.rbDrawBlackPoints.AutoSize = true;
            this.rbDrawBlackPoints.Checked = true;
            this.rbDrawBlackPoints.Location = new System.Drawing.Point(6, 35);
            this.rbDrawBlackPoints.Name = "rbDrawBlackPoints";
            this.rbDrawBlackPoints.Size = new System.Drawing.Size(215, 16);
            this.rbDrawBlackPoints.TabIndex = 5;
            this.rbDrawBlackPoints.TabStop = true;
            this.rbDrawBlackPoints.Text = "Black Points on White Background";
            this.rbDrawBlackPoints.UseVisualStyleBackColor = true;
            this.rbDrawBlackPoints.CheckedChanged += new System.EventHandler(this.rbDrawBlackPoints_CheckedChanged);
            // 
            // rbDrawWhitePoints
            // 
            this.rbDrawWhitePoints.AutoSize = true;
            this.rbDrawWhitePoints.Location = new System.Drawing.Point(6, 57);
            this.rbDrawWhitePoints.Name = "rbDrawWhitePoints";
            this.rbDrawWhitePoints.Size = new System.Drawing.Size(215, 16);
            this.rbDrawWhitePoints.TabIndex = 6;
            this.rbDrawWhitePoints.Text = "White Points on Black Background";
            this.rbDrawWhitePoints.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Points Count: No Data";
            // 
            // tbThredhold
            // 
            this.tbThredhold.Location = new System.Drawing.Point(132, 170);
            this.tbThredhold.Maximum = 255;
            this.tbThredhold.Name = "tbThredhold";
            this.tbThredhold.Size = new System.Drawing.Size(208, 45);
            this.tbThredhold.TabIndex = 8;
            this.tbThredhold.TickFrequency = 10;
            this.tbThredhold.Value = 125;
            // 
            // tbGridSize
            // 
            this.tbGridSize.Location = new System.Drawing.Point(132, 243);
            this.tbGridSize.Maximum = 50;
            this.tbGridSize.Minimum = 1;
            this.tbGridSize.Name = "tbGridSize";
            this.tbGridSize.Size = new System.Drawing.Size(208, 45);
            this.tbGridSize.TabIndex = 9;
            this.tbGridSize.TickFrequency = 5;
            this.tbGridSize.Value = 20;
            // 
            // lThredhold
            // 
            this.lThredhold.AutoSize = true;
            this.lThredhold.Location = new System.Drawing.Point(346, 178);
            this.lThredhold.Name = "lThredhold";
            this.lThredhold.Size = new System.Drawing.Size(41, 12);
            this.lThredhold.TabIndex = 10;
            this.lThredhold.Text = "label4";
            // 
            // lGridSize
            // 
            this.lGridSize.AutoSize = true;
            this.lGridSize.Location = new System.Drawing.Point(346, 243);
            this.lGridSize.Name = "lGridSize";
            this.lGridSize.Size = new System.Drawing.Size(41, 12);
            this.lGridSize.TabIndex = 11;
            this.lGridSize.Text = "label5";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(12, 400);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(141, 35);
            this.btnSaveImage.TabIndex = 12;
            this.btnSaveImage.Text = "Save Image...";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(421, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lImgPath
            // 
            this.lImgPath.AutoSize = true;
            this.lImgPath.Location = new System.Drawing.Point(169, 12);
            this.lImgPath.Name = "lImgPath";
            this.lImgPath.Size = new System.Drawing.Size(11, 12);
            this.lImgPath.TabIndex = 14;
            this.lImgPath.Text = " ";
            // 
            // lImgSize
            // 
            this.lImgSize.AutoSize = true;
            this.lImgSize.Location = new System.Drawing.Point(167, 35);
            this.lImgSize.Name = "lImgSize";
            this.lImgSize.Size = new System.Drawing.Size(11, 12);
            this.lImgSize.TabIndex = 15;
            this.lImgSize.Text = " ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetectWhitePoints);
            this.groupBox1.Controls.Add(this.rbDetectBlackPoints);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Options";
            // 
            // rbDetectWhitePoints
            // 
            this.rbDetectWhitePoints.AutoSize = true;
            this.rbDetectWhitePoints.Location = new System.Drawing.Point(6, 59);
            this.rbDetectWhitePoints.Name = "rbDetectWhitePoints";
            this.rbDetectWhitePoints.Size = new System.Drawing.Size(95, 16);
            this.rbDetectWhitePoints.TabIndex = 1;
            this.rbDetectWhitePoints.Text = "Detect White";
            this.rbDetectWhitePoints.UseVisualStyleBackColor = true;
            // 
            // rbDetectBlackPoints
            // 
            this.rbDetectBlackPoints.AutoSize = true;
            this.rbDetectBlackPoints.Checked = true;
            this.rbDetectBlackPoints.Location = new System.Drawing.Point(6, 36);
            this.rbDetectBlackPoints.Name = "rbDetectBlackPoints";
            this.rbDetectBlackPoints.Size = new System.Drawing.Size(95, 16);
            this.rbDetectBlackPoints.TabIndex = 0;
            this.rbDetectBlackPoints.TabStop = true;
            this.rbDetectBlackPoints.Text = "Detect Black";
            this.rbDetectBlackPoints.UseVisualStyleBackColor = true;
            this.rbDetectBlackPoints.CheckedChanged += new System.EventHandler(this.rbDetectBlackPoints_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDrawBlackPoints);
            this.groupBox2.Controls.Add(this.rbDrawWhitePoints);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Options";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(159, 400);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(141, 35);
            this.btnSaveData.TabIndex = 19;
            this.btnSaveData.Text = "Save Data...";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "TXT Files|*.txt";
            this.saveFileDialog2.Title = "Save TXT data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 531);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lImgSize);
            this.Controls.Add(this.lImgPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lGridSize);
            this.Controls.Add(this.lThredhold);
            this.Controls.Add(this.tbGridSize);
            this.Controls.Add(this.tbThredhold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1070, 570);
            this.Name = "Form1";
            this.Text = "Grid Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbThredhold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rbDrawBlackPoints;
        private System.Windows.Forms.RadioButton rbDrawWhitePoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbThredhold;
        private System.Windows.Forms.TrackBar tbGridSize;
        private System.Windows.Forms.Label lThredhold;
        private System.Windows.Forms.Label lGridSize;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lImgPath;
        private System.Windows.Forms.Label lImgSize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDetectWhitePoints;
        private System.Windows.Forms.RadioButton rbDetectBlackPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

