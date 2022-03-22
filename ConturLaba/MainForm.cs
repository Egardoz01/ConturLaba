using System;
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
                image = new Bitmap(open.FileName);
                pictureBox.Image = image;
            }
        }

        private void btnApplyMask_Click(object sender, EventArgs e)
        {
            image = ImageProcessor.ApplyMask(image, MaskType.HorizontalLineMask);
            pictureBox.Image = image;
        }
    }
}
