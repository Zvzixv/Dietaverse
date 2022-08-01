using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dietaverse.View
{
    public partial class Launch : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidrhElipse, int nHeightEllipse);
        public Launch()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login loginform = new Login() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            loginform.FormBorderStyle = FormBorderStyle.None;
            Controls.Clear();
            Controls.Add(loginform);
            loginform.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerform = new Register() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            registerform.FormBorderStyle = FormBorderStyle.None;
            Controls.Clear();
            Controls.Add(registerform);
            registerform.Show();
        }
    }
}
