namespace Auto_Worker.Forms
{
    partial class IdForm
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
            btn2x2 = new FontAwesome.Sharp.IconButton();
            btnPassport = new FontAwesome.Sharp.IconButton();
            btn1x1 = new FontAwesome.Sharp.IconButton();
            context2x2 = new ContextMenuStrip(components);
            twobytwoandonebyone = new ToolStripMenuItem();
            twobytwoonebyonename = new ToolStripMenuItem();
            twobytwo = new ToolStripMenuItem();
            x2With1x1OnlyToolStripMenuItem = new ToolStripMenuItem();
            context1x1 = new ContextMenuStrip(components);
            x1WoNameToolStripMenuItem = new ToolStripMenuItem();
            x1WithNametagToolStripMenuItem = new ToolStripMenuItem();
            contextPassport = new ContextMenuStrip(components);
            passportWONametagToolStripMenuItem = new ToolStripMenuItem();
            context2x2.SuspendLayout();
            context1x1.SuspendLayout();
            contextPassport.SuspendLayout();
            SuspendLayout();
            // 
            // btn2x2
            // 
            btn2x2.Anchor = AnchorStyles.None;
            btn2x2.FlatStyle = FlatStyle.Flat;
            btn2x2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2x2.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btn2x2.IconColor = Color.Black;
            btn2x2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn2x2.Location = new Point(99, 94);
            btn2x2.Name = "btn2x2";
            btn2x2.Size = new Size(192, 233);
            btn2x2.TabIndex = 0;
            btn2x2.Text = "2x2";
            btn2x2.TextAlign = ContentAlignment.MiddleRight;
            btn2x2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn2x2.UseVisualStyleBackColor = true;
            btn2x2.Click += btn2x2_Click;
            // 
            // btnPassport
            // 
            btnPassport.Anchor = AnchorStyles.None;
            btnPassport.FlatStyle = FlatStyle.Flat;
            btnPassport.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPassport.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnPassport.IconColor = Color.Black;
            btnPassport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassport.Location = new Point(502, 94);
            btnPassport.Name = "btnPassport";
            btnPassport.Size = new Size(192, 233);
            btnPassport.TabIndex = 2;
            btnPassport.Text = "Passport";
            btnPassport.TextAlign = ContentAlignment.MiddleRight;
            btnPassport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPassport.UseVisualStyleBackColor = true;
            btnPassport.Click += btnPassport_Click;
            // 
            // btn1x1
            // 
            btn1x1.Anchor = AnchorStyles.None;
            btn1x1.FlatStyle = FlatStyle.Flat;
            btn1x1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x1.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btn1x1.IconColor = Color.Black;
            btn1x1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn1x1.Location = new Point(304, 94);
            btn1x1.Name = "btn1x1";
            btn1x1.Size = new Size(192, 233);
            btn1x1.TabIndex = 3;
            btn1x1.Text = "1x1";
            btn1x1.TextAlign = ContentAlignment.MiddleRight;
            btn1x1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1x1.UseVisualStyleBackColor = true;
            btn1x1.Click += btn1x1_Click;
            // 
            // context2x2
            // 
            context2x2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            context2x2.Items.AddRange(new ToolStripItem[] { twobytwoandonebyone, twobytwoonebyonename, twobytwo, x2With1x1OnlyToolStripMenuItem });
            context2x2.Name = "contextMenuStrip1";
            context2x2.ShowImageMargin = false;
            context2x2.Size = new Size(239, 108);
            // 
            // twobytwoandonebyone
            // 
            twobytwoandonebyone.DisplayStyle = ToolStripItemDisplayStyle.Text;
            twobytwoandonebyone.Name = "twobytwoandonebyone";
            twobytwoandonebyone.Size = new Size(238, 26);
            twobytwoandonebyone.Text = "2x2 and 1x1";
            twobytwoandonebyone.TextAlign = ContentAlignment.MiddleLeft;
            twobytwoandonebyone.Click += twobytwoandonebyone_Click;
            // 
            // twobytwoonebyonename
            // 
            twobytwoonebyonename.DisplayStyle = ToolStripItemDisplayStyle.Text;
            twobytwoonebyonename.Name = "twobytwoonebyonename";
            twobytwoonebyonename.Size = new Size(238, 26);
            twobytwoonebyonename.Text = "2x2 and 1x1 with nametag";
            twobytwoonebyonename.TextAlign = ContentAlignment.MiddleLeft;
            twobytwoonebyonename.Click += twobytwoonebyonename_Click;
            // 
            // twobytwo
            // 
            twobytwo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            twobytwo.Name = "twobytwo";
            twobytwo.Size = new Size(238, 26);
            twobytwo.Text = "2x2 only";
            twobytwo.TextAlign = ContentAlignment.MiddleLeft;
            twobytwo.Click += twobytwo_Click;
            // 
            // x2With1x1OnlyToolStripMenuItem
            // 
            x2With1x1OnlyToolStripMenuItem.Name = "x2With1x1OnlyToolStripMenuItem";
            x2With1x1OnlyToolStripMenuItem.Size = new Size(238, 26);
            x2With1x1OnlyToolStripMenuItem.Text = "2x2 with nametag only";
            x2With1x1OnlyToolStripMenuItem.Click += x2With1x1OnlyToolStripMenuItem_Click;
            // 
            // context1x1
            // 
            context1x1.Items.AddRange(new ToolStripItem[] { x1WoNameToolStripMenuItem, x1WithNametagToolStripMenuItem });
            context1x1.Name = "context1x1";
            context1x1.ShowImageMargin = false;
            context1x1.Size = new Size(144, 48);
            // 
            // x1WoNameToolStripMenuItem
            // 
            x1WoNameToolStripMenuItem.Name = "x1WoNameToolStripMenuItem";
            x1WoNameToolStripMenuItem.Size = new Size(143, 22);
            x1WoNameToolStripMenuItem.Text = "1x1 w/o nametag";
            x1WoNameToolStripMenuItem.Click += x1WoNameToolStripMenuItem_Click;
            // 
            // x1WithNametagToolStripMenuItem
            // 
            x1WithNametagToolStripMenuItem.Name = "x1WithNametagToolStripMenuItem";
            x1WithNametagToolStripMenuItem.Size = new Size(143, 22);
            x1WithNametagToolStripMenuItem.Text = "1x1 with nametag";
            // 
            // contextPassport
            // 
            contextPassport.Items.AddRange(new ToolStripItem[] { passportWONametagToolStripMenuItem });
            contextPassport.Name = "contextPassport";
            contextPassport.ShowImageMargin = false;
            contextPassport.Size = new Size(173, 48);
            // 
            // passportWONametagToolStripMenuItem
            // 
            passportWONametagToolStripMenuItem.Name = "passportWONametagToolStripMenuItem";
            passportWONametagToolStripMenuItem.Size = new Size(172, 22);
            passportWONametagToolStripMenuItem.Text = "Passport W/O nametag";
            passportWONametagToolStripMenuItem.Click += passportWONametagToolStripMenuItem_Click;
            // 
            // IdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1x1);
            Controls.Add(btnPassport);
            Controls.Add(btn2x2);
            Name = "IdForm";
            Text = "IdForm";
            context2x2.ResumeLayout(false);
            context1x1.ResumeLayout(false);
            contextPassport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn2x2;
        private FontAwesome.Sharp.IconButton btnPassport;
        private FontAwesome.Sharp.IconButton btn1x1;
        private ContextMenuStrip context2x2;
        private ToolStripMenuItem twobytwoandonebyone;
        private ToolStripMenuItem twobytwoonebyonename;
        private ToolStripMenuItem twobytwo;
        private ToolStripMenuItem x2With1x1OnlyToolStripMenuItem;
        private ContextMenuStrip context1x1;
        private ToolStripMenuItem x1WoNameToolStripMenuItem;
        private ToolStripMenuItem x1WithNametagToolStripMenuItem;
        private ContextMenuStrip contextPassport;
        private ToolStripMenuItem passportWONametagToolStripMenuItem;
    }
}