using Auto_Worker.Class;
using Cropper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Worker.Forms._2x2
{
    public partial class TwoneOneWO : Form
    {
        Bitmap bmp;
        public TwoneOneWO()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(fileDialog.FileName);
                    Image croppedImage = ImageUtility.CropImage(selectedImage);
                    ChangeImage(croppedImage);
                }
            }
        }
        public void ChangeImage(Image image)
        {
            picture1.Image = new Bitmap(image);
            pictureBox2.Image = new Bitmap(image);
            pictureBox3.Image = new Bitmap(image);
            pictureBox4.Image = new Bitmap(image);
            pictureBox5.Image = new Bitmap(image);
            pictureBox6.Image = new Bitmap(image);
            pictureBox7.Image = new Bitmap(image);
            pictureBox8.Image = new Bitmap(image);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(toPrint1.Width, toPrint1.Height);
            using (Graphics mg = Graphics.FromImage(bmp))
            {
                mg.CopyFromScreen(toPrint1.PointToScreen(Point.Empty), Point.Empty, toPrint1.Size);
            }
          
            ImageUtility.PrintImage(bmp);
        }

        private void printImage_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
