using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureBox1
{
    public partial class Form1 : Form
    {
        int imgCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = this.imgList.Images[imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.imgCount++;
            if (imgCount >= this.imgList.Images.Count) {
                imgCount = 0;
            }
            this.picImg.Image = this.imgList.Images[imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.imgCount--;
            if (imgCount < 0)
            {
                imgCount = this.imgList.Images.Count-1;
            }
            this.picImg.Image = this.imgList.Images[imgCount];
            this.lblNum.Text = (this.imgCount + 1) + "/" + this.imgList.Images.Count;
        }
    }
}
