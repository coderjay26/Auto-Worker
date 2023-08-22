using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Worker.Forms.PopUp
{
    public partial class Croping : Form
    {
        private Point startPoint;
        private Point endPoint;
        private Rectangle selectionRectangle;

        public Croping()
        {
            InitializeComponent();
            InitializeCropArea();
        }
        private void Croping_Load(object sender, EventArgs e)
        {
          
        }

        private void InitializeCropArea()
        {
            // Initialize crop area
            startPoint = Point.Empty;
            endPoint = Point.Empty;
            selectionRectangle = Rectangle.Empty;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the crop area (selection rectangle)
            if (selectionRectangle != Rectangle.Empty)
            {
                e.Graphics.DrawRectangle(Pens.Black, selectionRectangle);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Handle mouse down event for starting the selection
            startPoint = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Handle mouse move event for resizing the selection
            if (e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                UpdateSelectionRectangle();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Handle mouse up event for finalizing the selection
            endPoint = e.Location;
            UpdateSelectionRectangle();
        }

        private void UpdateSelectionRectangle()
        {
            // Update the selection rectangle based on the start and end points
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            selectionRectangle = new Rectangle(x, y, width, height);

            // Redraw the control
            Invalidate();
        }

        public Rectangle CropArea
        {
            get { return selectionRectangle; }
        }
    }
}
