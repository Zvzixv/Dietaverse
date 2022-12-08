using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dietaverse.View
{
    public partial class Launch : Form
    {
        MainForm mainform;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidrhElipse, int nHeightEllipse);
        public Launch(MainForm mf)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            mainform = mf;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login loginform = new Login(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true , FormBorderStyle = FormBorderStyle.None };
            mainform.ChangeForm(loginform);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerform = new Register(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.ChangeForm(registerform);
        }
    }
}
