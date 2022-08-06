using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{

    public partial class mainForm : Form
    {
        Form af;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidrhElipse, int nHeightEllipse);
        public mainForm()
        {
            InitializeComponent();
            Launch launchpanel = new Launch(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true/*, FormBorderStyle = FormBorderStyle.None*/ };
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel1.Controls.Clear();
            panel1.Controls.Add(launchpanel);
            launchpanel.Show();
            af = launchpanel;
        }

        public void changeForm(Form x)
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
