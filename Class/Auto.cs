using Auto_Worker.Forms._2x2;
using Cropper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Worker.Class
{
    internal class Auto
    {
        public void ShowForm(Form forms, Form childForm)
        {
            if (childForm.ParentForm is MainView mainview)
            {
                Form form = forms;
                mainview.ChildForm(form, mainview.desktopPanel);
            }
        }

    }
}
