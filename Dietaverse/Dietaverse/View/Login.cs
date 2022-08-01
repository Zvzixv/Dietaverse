using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietaverse.View;

namespace Dietaverse.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 startform = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            startform.FormBorderStyle = FormBorderStyle.None;
            Controls.Clear();
            Controls.Add(startform);
            startform.Show();
        }
    }
}
