using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dietaverse.View
{

    public partial class MainForm : Form
    {
        Form af;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidrhElipse, int nHeightEllipse);
        public MainForm()
        {
            InitializeComponent();
            Launch launchpanel = new Launch(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true/*, FormBorderStyle = FormBorderStyle.None*/ };
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Controls.Clear();
            panel1.Controls.Add(launchpanel);
            launchpanel.Show();
            af = launchpanel;
        }

        public void ChangeForm(Form x)
        {
            if (af != null)
                af.Close();
            af = x;
            panel1.Controls.Clear();
            panel1.Controls.Add(x);
            x.Show();
        }
    }
}
