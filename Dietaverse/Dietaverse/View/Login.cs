using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dietaverse.Database;
using Dietaverse.Model;
using Dietaverse.View;

namespace Dietaverse.View
{
    public partial class Login : Form
    {
        mainForm mainform;
        users ub = new users();
        Users u = new Users();
        public Login(mainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                users user = u.Login(logintextBox.Text, passtextBox.Text);
                if (user != null)
                {
                    Form1 startform = new Form1(mainform, user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
                    mainform.changeForm(startform);
                }
            }
            catch (LoginFailException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            mainform.changeForm(launchform);

        }
    }
}
