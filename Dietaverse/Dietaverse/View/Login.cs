using System;
using System.Windows.Forms;
using Dietaverse.Database;
using Dietaverse.Model;

namespace Dietaverse.View
{
    public partial class Login : Form
    {
        MainForm mainform;
        users ub = new users();
        Users u = new Users();
        public Login(MainForm mf)
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
