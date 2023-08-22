namespace Auto_Worker.Forms._2x2
{
    partial class TwoW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoW));
            printDialog1 = new PrintDialog();
            labelBtn3 = new FontAwesome.Sharp.IconButton();
            labelBtn2 = new FontAwesome.Sharp.IconButton();
            labelBtn1 = new FontAwesome.Sharp.IconButton();
            labelBtn = new FontAwesome.Sharp.IconButton();
            printImage = new System.Drawing.Printing.PrintDocument();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxName = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            // labelBtn3
            // 
            labelBtn3.FlatAppearance.BorderSize = 0;
            labelBtn3.FlatStyle = FlatStyle.Flat;
            labelBtn3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBtn3.IconChar = FontAwesome.Sharp.IconChar.None;
            labelBtn3.IconColor = Color.Black;
            labelBtn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelBtn3.Location = new Point(580, 151);
            labelBtn3.Name = "labelBtn3";
            labelBtn3.Size = new Size(190, 40);
            labelBtn3.TabIndex = 18;
            labelBtn3.UseVisualStyleBackColor = true;
            // 
            // labelBtn2
            // 
            labelBtn2.FlatAppearance.BorderSize = 0;
            labelBtn2.FlatStyle = FlatStyle.Flat;
            labelBtn2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBtn2.IconChar = FontAwesome.Sharp.IconChar.None;
            labelBtn2.IconColor = Color.Black;
            labelBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelBtn2.Location = new Point(387, 151);
            labelBtn2.Name = "labelBtn2";
            labelBtn2.Size = new Size(190, 40);
            labelBtn2.TabIndex = 17;
            labelBtn2.UseVisualStyleBackColor = true;
            // 
            // labelBtn1
            // 
            labelBtn1.FlatAppearance.BorderSize = 0;
            labelBtn1.FlatStyle = FlatStyle.Flat;
            labelBtn1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            labelBtn1.IconColor = Color.Black;
            labelBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelBtn1.Location = new Point(194, 151);
            labelBtn1.Name = "labelBtn1";
            labelBtn1.Size = new Size(190, 40);
            labelBtn1.TabIndex = 16;
            labelBtn1.UseVisualStyleBackColor = true;
            // 
            // labelBtn
            // 
            labelBtn.FlatAppearance.BorderSize = 0;
            labelBtn.FlatStyle = FlatStyle.Flat;
            labelBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            labelBtn.IconColor = Color.Black;
            labelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelBtn.Location = new Point(1, 151);
            labelBtn.Name = "labelBtn";
            labelBtn.Size = new Size(190, 40);
            labelBtn.TabIndex = 15;
            labelBtn.UseVisualStyleBackColor = true;
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
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(356, 420);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Juan Dela Cruz";
            textBoxName.Size = new Size(175, 23);
            textBoxName.TabIndex = 7;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(534, 471);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(239, 61);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "Print";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(120, 471);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(239, 61);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Upload";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(579, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(386, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 192);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(193, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 192);
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
            picture1.Size = new Size(192, 192);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 0;
            picture1.TabStop = false;
            // 
            // toPrint1
            // 
            toPrint1.Anchor = AnchorStyles.None;
            toPrint1.BackColor = Color.White;
            toPrint1.Controls.Add(labelBtn3);
            toPrint1.Controls.Add(labelBtn2);
            toPrint1.Controls.Add(labelBtn1);
            toPrint1.Controls.Add(labelBtn);
            toPrint1.Controls.Add(pictureBox4);
            toPrint1.Controls.Add(pictureBox3);
            toPrint1.Controls.Add(pictureBox2);
            toPrint1.Controls.Add(picture1);
            toPrint1.Location = new Point(51, 27);
            toPrint1.Name = "toPrint1";
            toPrint1.Size = new Size(786, 294);
            toPrint1.TabIndex = 4;
            // 
            // TwoW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 558);
            Controls.Add(textBoxName);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(toPrint1);
            Name = "TwoW";
            Text = "TwoW";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            toPrint1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintDialog printDialog1;
        private FontAwesome.Sharp.IconButton labelBtn3;
        private FontAwesome.Sharp.IconButton labelBtn2;
        private FontAwesome.Sharp.IconButton labelBtn1;
        private FontAwesome.Sharp.IconButton labelBtn;
        private System.Drawing.Printing.PrintDocument printImage;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxName;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox picture1;
        private Panel toPrint1;
    }
}