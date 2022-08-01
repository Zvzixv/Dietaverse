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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Launch launchform = new Launch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            launchform.FormBorderStyle = FormBorderStyle.None;
            Controls.Clear();
            Controls.Add(launchform);
            launchform.Show();
        }
    }
}
