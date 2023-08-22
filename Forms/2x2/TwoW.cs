using Auto_Worker.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Worker.Forms._2x2
{
    public partial class TwoW : Form
    {
        private Bitmap bmp;
        public TwoW()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ChangeName(textBoxName.Text);
        }
        void ChangeName(string name)
        {
            labelBtn.Text = name;
            labelBtn1.Text = name;
            labelBtn2.Text = name;
            labelBtn3.Text = name;
        }
        void ChangeImage(Image image)
        {
            picture1.Image = new Bitmap(image);
            pictureBox2.Image = new Bitmap(image);
            pictureBox3.Image = new Bitmap(image);
            pictureBox4.Image = new Bitmap(image);
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

        private void printImage_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(toPrint1.Height, toPrint1.Width);
            using(Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.CopyFromScreen(toPrint1.PointToScreen(Point.Empty), Point.Empty, toPrint1.Size);
            }
            ImageUtility.PrintImage(bmp);
        }
    }
}
