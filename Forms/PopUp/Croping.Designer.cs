namespace Auto_Worker.Forms.PopUp
{
    partial class Croping
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
            pictureBox = new PictureBox();
            cropButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(205, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(300, 304);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
           
            // 
            // cropButton
            // 
            cropButton.IconChar = FontAwesome.Sharp.IconChar.None;
            cropButton.IconColor = Color.Black;
            cropButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cropButton.Location = new Point(608, 182);
            cropButton.Name = "cropButton";
            cropButton.Size = new Size(75, 23);
            cropButton.TabIndex = 1;
            cropButton.Text = "iconButton1";
            cropButton.UseVisualStyleBackColor = true;
     // 
            // Croping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cropButton);
            Controls.Add(pictureBox);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Croping";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crop Image";
            Load += Croping_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private FontAwesome.Sharp.IconButton cropButton;
    }
}