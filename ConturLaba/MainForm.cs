﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConturLaba
{
    public partial class MainForm : Form
    {

        private Bitmap image;
        private Bitmap originalImage;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.pcx)|*.jpg; *.jpeg; *.gif; *.bmp; *.pcx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                image = (Bitmap)originalImage.Clone();
                pictureBox.Image = image;
            }
        }

        private void btnApplyMask_Click(object sender, EventArgs e)
        {
            MaskType mask;
            Enum.TryParse<MaskType>(cmbMask.SelectedValue.ToString(), out mask);

            image = ImageProcessor.ApplyMask(image, mask);
            pictureBox.Image = image;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbMask.DataSource = Enum.GetValues(typeof(MaskType));
        }

        private void btnBackToOriginal_Click(object sender, EventArgs e)
        {
            image = (Bitmap)originalImage.Clone();
            pictureBox.Image = image;
        }
    }
}
