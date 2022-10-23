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
        bool pass1wasclicked = false;
        bool pass2wasclicked = false;
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

        private void pass1textBox_Validated(object sender, EventArgs e)
        {
            if(!pass1wasclicked)
            {
                pass1textBox.Text = "";
                pass1textBox.PasswordChar = '*';
                pass1textBox.UseSystemPasswordChar = true;
                pass1wasclicked = true;

            }
        }

        private void pass1textBox_Leave(object sender, EventArgs e)
        {
            if(pass1wasclicked && pass1textBox.TextLength == 0 )
            {
                pass1textBox.Text = "Insert new password";
                pass1wasclicked = false;
            }

        }

        private void pass2textBox_Validated(object sender, EventArgs e)
        {
            if (!pass2wasclicked)
            {
                pass2textBox.Text = "";
                pass2textBox.PasswordChar = '*';
                pass2textBox.UseSystemPasswordChar = true;
                pass2wasclicked = true;

            }

        }

        private void pass2textBox_Leave(object sender, EventArgs e)
        {
            if (pass2wasclicked && pass2textBox.TextLength == 0)
            {
                pass2textBox.Text = "Insert new password";
                pass2wasclicked = false;
            }

        }
    }
}
