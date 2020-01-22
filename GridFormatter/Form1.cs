using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace GridFormatter
{
    public partial class Form1 : Form
    {
        Bitmap rawImg;
        Bitmap newImg;
        Color pointColor;
        Color backColor;
        int thredhold = 0;
        int gridSize = 0;
        int pointsCount = 0;
        struct Posi
        {
            public int xVal;
            public int yVal;
        }
        Posi[] posiArray = new Posi[2500];

        public Form1()
        {
            InitializeComponent();
            tbThredhold.MouseUp += TbThredhold_MouseUp;
            tbThredhold.KeyUp += TbThredhold_KeyUp;
            tbGridSize.MouseUp += TbGridSize_MouseUp;
            tbGridSize.KeyUp += TbGridSize_KeyUp;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //initiate images
                rawImg = new Bitmap(openFileDialog1.FileName);
                lImgPath.Text = openFileDialog1.FileName;
                lImgSize.Text = rawImg.Width.ToString() + " * " + rawImg.Height.ToString();
                label3.Text = "Points Count: " + ProcessImage().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            uiRefreshValue();
        }

        private void uiRefreshValue()
        {
            lThredhold.Text = tbThredhold.Value.ToString();
            lGridSize.Text = tbGridSize.Value.ToString();
            thredhold = tbThredhold.Value;
            gridSize = tbGridSize.Value;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newImg.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                MessageBox.Show("Saved to file!", "Grid Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < pointsCount; i++)
                {
                    sw.WriteLine("(" + posiArray[i].xVal + "," + posiArray[i].yVal + ")");
                }
                sw.Close();
                MessageBox.Show("Saved to file!", "Grid Formatter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private int ProcessImage()
        {
            pointsCount = 0;
            bool detectColor;
            if (rbDetectBlackPoints.Checked)
            {
                detectColor = false;
            }
            else
            {
                detectColor = true;
            }
            if (rbDrawBlackPoints.Checked)
            {
                pointColor = Color.Black;
                backColor = Color.White;
            }
            else
            {
                pointColor = Color.White;
                backColor = Color.Black;
            }
            //introduce the grid
            int networkWidth = (int)Math.Floor((double)(rawImg.Width / gridSize));
            int networkHeight = (int)Math.Floor((double)(rawImg.Height / gridSize));
            newImg = new Bitmap((networkWidth + 1) * gridSize, (networkHeight + 1) * gridSize);
            for (int tmpX = 0; tmpX < newImg.Width; tmpX++)
            {
                for (int tmpY = 0; tmpY < newImg.Height; tmpY++)
                {
                    newImg.SetPixel(tmpX, tmpY, backColor);
                }
            }
            //grid searcher in network
            for (int networkX = 0; networkX < networkWidth; networkX++)
            {
                for (int networkY = 0; networkY < networkHeight; networkY++)
                {
                    //section of each grid
                    //get average RGB
                    int totalR = 0;
                    int totalG = 0;
                    int totalB = 0;
                    //grid poll
                    for (int x = networkX * gridSize; x < networkX * gridSize + gridSize; x++)
                    {
                        for (int y = networkY * gridSize; y < networkY * gridSize + gridSize; y++)
                        {
                            totalR += rawImg.GetPixel(x, y).R;
                            totalG += rawImg.GetPixel(x, y).G;
                            totalB += rawImg.GetPixel(x, y).B;
                        }
                    }
                    //calculate network
                    int AvgR = totalR / (gridSize * gridSize);
                    int AvgG = totalG / (gridSize * gridSize);
                    int AvgB = totalB / (gridSize * gridSize);
                    if ((AvgR > thredhold || AvgG > thredhold || AvgB > thredhold) && detectColor || !(AvgR > thredhold || AvgG > thredhold || AvgB > thredhold) && !detectColor)
                    {
                        for (int tmpX = networkX * gridSize + (int)(gridSize * 0.25); tmpX < networkX * gridSize + (gridSize - (int)(gridSize * 0.25)); tmpX++)
                        {
                            for (int tmpY = networkY * gridSize + (int)(gridSize * 0.25); tmpY < networkY * gridSize + (gridSize - (int)(gridSize * 0.25)); tmpY++)
                            {
                                newImg.SetPixel(tmpX, tmpY, pointColor);
                            }
                        }
                        if (pointsCount < 2500)
                        {
                            posiArray[pointsCount].xVal = networkX;
                            posiArray[pointsCount].yVal = networkY;
                        }
                        pointsCount++;
                    }
                }
                progressBar1.Value = (networkX * networkHeight) * 100 / (networkWidth * networkHeight);
                Application.DoEvents();
            }
            pictureBox1.Image = newImg.GetThumbnailImage(newImg.Width, newImg.Height, null, IntPtr.Zero);
            progressBar1.Value = 0;
            if (pointsCount > 2500)
            {
                MessageBox.Show("Number of points has exceeded the maximum limit. Some data are lost.", "Grid Formatter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return pointsCount;
        }

        private void rbDrawBlackPoints_CheckedChanged(object sender, EventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }

        private void rbDetectBlackPoints_CheckedChanged(object sender, EventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }

        private void TbGridSize_KeyUp(object sender, KeyEventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }

        private void TbThredhold_KeyUp(object sender, KeyEventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }

        private void TbGridSize_MouseUp(object sender, MouseEventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }

        private void TbThredhold_MouseUp(object sender, MouseEventArgs e)
        {
            uiRefreshValue();
            label3.Text = "Points Count: " + ProcessImage().ToString();
        }
    }
}
