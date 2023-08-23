namespace Auto_Worker.Forms._1x1
{
    partial class OnebyOne
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnebyOne));
            printDialog1 = new PrintDialog();
            printImage = new System.Drawing.Printing.PrintDocument();
            contextMenuStrip1 = new ContextMenuStrip(components);
            iconButton2 = new FontAwesome.Sharp.IconButton();
            OnebyoneWO = new FontAwesome.Sharp.IconButton();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            picture1 = new PictureBox();
            toPrint1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            toPrint1.SuspendLayout();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printImage
            // 
            printImage.PrintPage += printImage_PrintPage;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(559, 492);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(239, 61);
            iconButton2.TabIndex = 12;
            iconButton2.Text = "Print";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // OnebyoneWO
            // 
            OnebyoneWO.Anchor = AnchorStyles.None;
            OnebyoneWO.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            OnebyoneWO.IconChar = FontAwesome.Sharp.IconChar.None;
            OnebyoneWO.IconColor = Color.Black;
            OnebyoneWO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            OnebyoneWO.Location = new Point(145, 492);
            OnebyoneWO.Name = "OnebyoneWO";
            OnebyoneWO.Size = new Size(239, 61);
            OnebyoneWO.TabIndex = 11;
            OnebyoneWO.Text = "Upload";
            OnebyoneWO.UseVisualStyleBackColor = true;
            OnebyoneWO.Click += iconButton1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(291, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(96, 96);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(194, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(97, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printImage;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // picture1
            // 
            picture1.BorderStyle = BorderStyle.FixedSingle;
            picture1.Location = new Point(0, 0);
            picture1.Name = "picture1";
            picture1.Size = new Size(96, 96);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 0;
            picture1.TabStop = false;
            // 
            // toPrint1
            // 
            toPrint1.Anchor = AnchorStyles.None;
            toPrint1.BackColor = Color.White;
            toPrint1.Controls.Add(pictureBox4);
            toPrint1.Controls.Add(pictureBox3);
            toPrint1.Controls.Add(pictureBox2);
            toPrint1.Controls.Add(picture1);
            toPrint1.Location = new Point(76, 48);
            toPrint1.Name = "toPrint1";
            toPrint1.Size = new Size(786, 294);
            toPrint1.TabIndex = 10;
            // 
            // OnebyOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 601);
            Controls.Add(iconButton2);
            Controls.Add(OnebyoneWO);
            Controls.Add(toPrint1);
            Name = "OnebyOne";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            toPrint1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printImage;
        private ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton OnebyoneWO;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox picture1;
        private Panel toPrint1;
    }
}