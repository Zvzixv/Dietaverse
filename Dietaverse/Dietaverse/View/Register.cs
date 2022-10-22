using Dietaverse.Database;
using Dietaverse.Model;
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
        mainForm mainform;
        string un;
        double weight;
        string pass1;
        string pass2;
        Users newuser = new Users();
        Daily_summary summary = new Daily_summary();
        public Register(mainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(userNametextBox.Text!= "" && weighttextBox.Text!="" && passwordtextBox.Text!= "" && password2textBox.Text!="")//sprawdz czy username jest wolny 
            {
                un = userNametextBox.Text;
                if(!double.TryParse(weighttextBox.Text, out weight))
                {
                    string message = "Weight is not a number";
                    MessageBox.Show(this, message, "Value is wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pass1 = passwordtextBox.Text;
                pass2=password2textBox.Text;

                if(pass1!=pass2)
                {
                    string message = "Passwords are different";
                    MessageBox.Show(this, message, "Value is wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    users u = newuser.CreateAccount(un, weight, pass1);
                    summary.update(weight, 0, u, "");

                }
                catch (CreateAccountFailException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show(this, "Registered successfully", "Finish", MessageBoxButtons.OK, MessageBoxIcon.None);


                Launch launchform = new Launch(mainform) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
                mainform.changeForm(launchform);
            }
            else
            {
                string message = "Records are empty";
                MessageBox.Show(this, message, "Value is wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
