using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dietaverse.View
{
    public partial class Settings : Form
    {
        mainForm mainform;
        public Settings(mainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.changeForm(launchform);
        }
    }
}
