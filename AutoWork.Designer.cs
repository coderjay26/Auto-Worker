namespace Auto_Worker
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            sidePanel = new Panel();
            pagasaBtn = new FontAwesome.Sharp.IconButton();
            plateBtn = new FontAwesome.Sharp.IconButton();
            idBtn = new FontAwesome.Sharp.IconButton();
            logoPanel = new Panel();
            Logo = new PictureBox();
            Header = new Panel();
            labelIcon = new FontAwesome.Sharp.IconPictureBox();
            labelName = new Label();
            desktopPanel = new Panel();
            sidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)labelIcon).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(56, 23, 62);
            sidePanel.Controls.Add(pagasaBtn);
            sidePanel.Controls.Add(plateBtn);
            sidePanel.Controls.Add(idBtn);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(254, 681);
            sidePanel.TabIndex = 0;
            // 
            // pagasaBtn
            // 
            pagasaBtn.Dock = DockStyle.Top;
            pagasaBtn.FlatAppearance.BorderSize = 0;
            pagasaBtn.FlatStyle = FlatStyle.Flat;
            pagasaBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pagasaBtn.ForeColor = Color.Gainsboro;
            pagasaBtn.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            pagasaBtn.IconColor = Color.Gainsboro;
            pagasaBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            pagasaBtn.IconSize = 24;
            pagasaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            pagasaBtn.Location = new Point(0, 234);
            pagasaBtn.Name = "pagasaBtn";
            pagasaBtn.Padding = new Padding(10, 0, 0, 0);
            pagasaBtn.Size = new Size(254, 55);
            pagasaBtn.TabIndex = 3;
            pagasaBtn.Text = "Pag-Asa";
            pagasaBtn.TextAlign = ContentAlignment.MiddleLeft;
            pagasaBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            pagasaBtn.UseVisualStyleBackColor = true;
            pagasaBtn.Click += pagasaBtn_Click;
            // 
            // plateBtn
            // 
            plateBtn.Dock = DockStyle.Top;
            plateBtn.FlatAppearance.BorderSize = 0;
            plateBtn.FlatStyle = FlatStyle.Flat;
            plateBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            plateBtn.ForeColor = Color.Gainsboro;
            plateBtn.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            plateBtn.IconColor = Color.Gainsboro;
            plateBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            plateBtn.IconSize = 24;
            plateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            plateBtn.Location = new Point(0, 179);
            plateBtn.Name = "plateBtn";
            plateBtn.Padding = new Padding(10, 0, 0, 0);
            plateBtn.Size = new Size(254, 55);
            plateBtn.TabIndex = 2;
            plateBtn.Text = "Plate Card";
            plateBtn.TextAlign = ContentAlignment.MiddleLeft;
            plateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            plateBtn.UseVisualStyleBackColor = true;
            plateBtn.Click += plateBtn_Click;
            // 
            // idBtn
            // 
            idBtn.Dock = DockStyle.Top;
            idBtn.FlatAppearance.BorderSize = 0;
            idBtn.FlatStyle = FlatStyle.Flat;
            idBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idBtn.ForeColor = Color.Gainsboro;
            idBtn.IconChar = FontAwesome.Sharp.IconChar.Camera;
            idBtn.IconColor = Color.Gainsboro;
            idBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            idBtn.IconSize = 24;
            idBtn.ImageAlign = ContentAlignment.MiddleLeft;
            idBtn.Location = new Point(0, 124);
            idBtn.Name = "idBtn";
            idBtn.Padding = new Padding(10, 0, 0, 0);
            idBtn.Size = new Size(254, 55);
            idBtn.TabIndex = 1;
            idBtn.Text = "Identification";
            idBtn.TextAlign = ContentAlignment.MiddleLeft;
            idBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            idBtn.UseVisualStyleBackColor = true;
            idBtn.Click += idBtn_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(56, 23, 62);
            logoPanel.Controls.Add(Logo);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(254, 124);
            logoPanel.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Dock = DockStyle.Top;
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(254, 124);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(56, 23, 62);
            Header.Controls.Add(labelIcon);
            Header.Controls.Add(labelName);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(254, 0);
            Header.Name = "Header";
            Header.Size = new Size(810, 67);
            Header.TabIndex = 2;
            // 
            // labelIcon
            // 
            labelIcon.BackColor = Color.FromArgb(56, 23, 62);
            labelIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            labelIcon.IconColor = Color.White;
            labelIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelIcon.Location = new Point(17, 21);
            labelIcon.Name = "labelIcon";
            labelIcon.Size = new Size(32, 32);
            labelIcon.TabIndex = 1;
            labelIcon.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(55, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Home";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // desktopPanel
            // 
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(254, 67);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Padding = new Padding(10, 0, 0, 0);
            desktopPanel.Size = new Size(810, 614);
            desktopPanel.TabIndex = 3;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(desktopPanel);
            Controls.Add(Header);
            Controls.Add(sidePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Work";
            sidePanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)labelIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel logoPanel;
        private PictureBox Logo;
        private FontAwesome.Sharp.IconButton pagasaBtn;
        private FontAwesome.Sharp.IconButton plateBtn;
        private FontAwesome.Sharp.IconButton idBtn;
        private Panel Header;
        public Panel desktopPanel;
        private Label labelName;
        private FontAwesome.Sharp.IconPictureBox labelIcon;
    }
}