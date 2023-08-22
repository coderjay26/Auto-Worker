using Auto_Worker.Class;
using Auto_Worker.Forms;
using FontAwesome.Sharp;
namespace Auto_Worker
{
    public partial class MainView : Form
    {
        private Random random;
        private int tempIndex;
        private IconButton currentBtn;
        private Form currentForm;

        public MainView()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            random = new Random();
            currentForm = new IdForm();
        }


        public void ChildForm(Form form, Panel desktopPanel)
        {
            if (form != null && form != currentForm)
            {
                currentForm.Close();
            }
            if (form != currentForm)
            {
                currentForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                desktopPanel.Controls.Add(form);
                desktopPanel.Tag = form;
                form.BringToFront();
                form.Show();
            }

        }


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                DisableColor(currentBtn, sender);
                if (currentBtn != (Button)sender)
                {

                    Color color = SelectThemeColor();
                    currentBtn = (IconButton)sender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
                    currentBtn.IconSize = 32;
                    Header.BackColor = color;
                    labelName.Text = currentBtn.Text;
                    labelIcon.IconChar = currentBtn.IconChar;
                }
            }
        }

        private void DisableColor(object sender, object btn2)
        {
            if (sender != null && sender != btn2)
            {

                IconButton btn = (IconButton)sender;
                btn.ForeColor = Color.Gainsboro;
                btn.BackColor = Color.FromArgb(56, 23, 62);
                btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
                btn.IconSize = 24;
                Header.BackColor = Color.FromArgb(56, 23, 62);
                labelName.Text = "Home";
                labelIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            }
        }

        private void idBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ChildForm(new IdForm(), desktopPanel);
        }

        private void plateBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ChildForm(new PlateForm(), desktopPanel);
        }

        private void pagasaBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ChildForm(new PagasaForm(), desktopPanel);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            DisableColor(currentBtn, null);
        }
    }
}