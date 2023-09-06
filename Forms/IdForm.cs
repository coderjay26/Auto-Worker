﻿using Auto_Worker.Class;
using Auto_Worker.Forms._1x1;
using Auto_Worker.Forms._2x2;
using Auto_Worker.Forms.Passport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Auto_Worker.Forms
{
    public partial class IdForm : Form
    {
        Auto auto = new Auto();
        public IdForm()
        {
            InitializeComponent();
        }

        private void btn2x2_Click(object sender, EventArgs e)
        {
            context2x2.Width = btn2x2.Width;
            Point point = btn2x2.PointToScreen(new Point(0, btn2x2.Height));
            context2x2.Show(point);
        }

        private void btnPassport_Click(object sender, EventArgs e)
        {
            contextPassport.Width = contextPassport.Width;
            Point point = btnPassport.PointToScreen(new Point(0, contextPassport.Height));
            contextPassport.Show(point);
        }

        private void btn1x1_Click(object sender, EventArgs e)
        {
            context1x1.Width = btn1x1.Width;
            Point point = btn1x1.PointToScreen(new Point(0, btn1x1.Height));
            context1x1.Show(point);
        }

        private void twobytwoonebyonename_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new TwoOneW(), this);
        }

        private void twobytwoandonebyone_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new TwoneOneWO(), this);
        }

        private void twobytwo_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new TwoWO(), this);
        }

        private void x2With1x1OnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new TwoW(), this);
        }

        private void x1WoNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new OnebyOne(), this);
        }

        private void passportWONametagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auto.ShowForm(new PassportWO(), this);
        }
    }
}
