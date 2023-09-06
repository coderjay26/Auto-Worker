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

namespace Auto_Worker.Forms.Passport
{
    public partial class PassportWO : Form
    {
        Bitmap _bitmap;
        public PassportWO()
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
        void ChangeImage(Image image)
        {
            picture1.Image = image;
            pictureBox2.Image = image;
            pictureBox3.Image = image;
            pictureBox4.Image = image;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(toPrint1.Width, toPrint1.Height);
            using (Graphics graphics = Graphics.FromImage(_bitmap))
            {
                graphics.CopyFromScreen(toPrint1.PointToScreen(Point.Empty), Point.Empty, toPrint1.Size);
            }
            ImageUtility.PrintImage(_bitmap);
        }
    }
}
